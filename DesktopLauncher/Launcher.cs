using DesktopLauncher.Utilities;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DesktopLauncher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }


        private string GetFilename(out string filename, DragEventArgs e)
        {
            string ret = "";
            filename = String.Empty;

            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileName") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        ret = data.GetValue(0).ToString();
                    }
                }
            }
            return ret;
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                string filename = GetFilename(out filename, e);
                Button b = new Button();
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                b.Text = Path.GetFileNameWithoutExtension(filePaths[0]);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control);
                b.AutoSize = true;
                b.ContextMenuStrip = bms;
                b.Height = 50;
                b.Width = 100;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Image = System.Drawing.Icon.ExtractAssociatedIcon(filePaths[0]).ToBitmap();
                b.Tag = filePaths[0].ToString();
                b.Click += B_Click;
                flowLayoutPanel1.Controls.Add(b);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please drag and drop it on desktop or try manuel add option", ex.Message);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            FileInfo fi = new FileInfo(b.Tag.ToString());

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = fi.FullName;

            Process processTemp = new Process();
            processTemp.StartInfo = startInfo;
            processTemp.EnableRaisingEvents = true;

            try
            {
                processTemp.Start();
                this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(b.Tag + " " + ex.Message);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    Control sourceControl = owner.SourceControl;
                    flowLayoutPanel1.Controls.Remove(sourceControl);
                }
            }

        }

        private void saveLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutSave ls = new LayoutSave();
            ls.ShowDialog();
            SaveNewLayout();

        }

        private void SaveNewLayout()
        {
            string filename = AppUtilities._fileName;
            if (string.IsNullOrEmpty(filename))
                return;
            DataLayout dl = new DataLayout();
            dl.isDefault = AppUtilities._isDefault;
            dl.layoutDate = DateTime.Now;
            dl.layoutName = filename;
            dl.layoutId = AppUtilities._layoutId;
            dl.filePathList = new List<string>();
            try
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    if (item is Button)
                    {
                        Button b = (Button)item;
                        dl.filePathList.Add(b.Tag.ToString());
                    }
                }
                if (!XmlHelper.SaveLayout(dl))
                    MessageBox.Show("New layout could not be created.", "New Layout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateOrDeleteLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutDeleteOrUprdate ldop = new LayoutDeleteOrUprdate();
            ldop.ShowDialog();
        }

        private void loadLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutLoad ll = new LayoutLoad();
            ll.ShowDialog();
            if (string.IsNullOrEmpty(AppUtilities._loadName) || string.IsNullOrWhiteSpace(AppUtilities._loadName))
                return;
            string filePath = Path.Combine(XmlHelper.basePath, AppUtilities._loadName + ".xml");
            DataLayout dl = null;
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataLayout));
            dl = (DataLayout)xmlSerializer.Deserialize(fileStream);
            flowLayoutPanel1.Controls.Clear();
            fileStream.Close();
            currentLayout.Text = AppUtilities._loadName;
            for (int i = 0; i < dl.filePathList.Count; i++)
            {
                Button b = new Button();
                b.Text = Path.GetFileNameWithoutExtension(dl.filePathList[i]);
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control);
                b.AutoSize = true;
                b.ContextMenuStrip = bms;
                b.Height = 50;
                b.Width = 100;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Image = System.Drawing.Icon.ExtractAssociatedIcon(dl.filePathList[i]).ToBitmap();
                b.Tag = dl.filePathList[i].ToString();
                b.Click += B_Click;
                flowLayoutPanel1.Controls.Add(b);
            }
            AppUtilities._loadName = string.Empty;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(XmlHelper.basePath))
            {
                Directory.CreateDirectory(XmlHelper.basePath);
            }

            if (SetDefault.Default.defaultPath != null)
            {
                if (File.Exists(SetDefault.Default.defaultPath))
                {
                    DataLayout dl = null;
                    FileStream fileStream = new FileStream(SetDefault.Default.defaultPath, FileMode.Open);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataLayout));
                    dl = (DataLayout)xmlSerializer.Deserialize(fileStream);
                    fileStream.Close();
                    currentLayout.Text = dl.layoutName;
                    flowLayoutPanel1.Controls.Clear();
                    for (int i = 0; i < dl.filePathList.Count; i++)
                    {
                        Button b = new Button();
                        b.Text = Path.GetFileNameWithoutExtension(dl.filePathList[i]);
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderSize = 0;
                        b.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control);
                        b.AutoSize = true;
                        b.TextAlign = ContentAlignment.MiddleRight;
                        b.ContextMenuStrip = bms;
                        b.Height = 50;
                        b.Width = 100;
                        b.TextImageRelation = TextImageRelation.ImageBeforeText;
                        b.Image = System.Drawing.Icon.ExtractAssociatedIcon(dl.filePathList[i]).ToBitmap();
                        b.Tag = dl.filePathList[i].ToString();
                        b.Click += B_Click;
                        flowLayoutPanel1.Controls.Add(b);
                    }
                }
            }
        }

        private void clearLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private void fitLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Button> btnList = new List<Button>();
            btnList.Clear();
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item is Button)
                {
                    btnList.Add((Button)item);
                }
            }
            int bMax = btnList.Max(x => x.Width);
            btnList.ForEach(x => x.Width = bMax);
            btnList.ForEach(x => x.Height = 50);
            this.Width = bMax + 20;
            this.Height = (btnList.Count * 50) + 90;
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count < 1)
            {
                clearLayoutToolStripMenuItem.Enabled = false;
                fitLayoutToolStripMenuItem.Enabled = false;
                saveLayoutToolStripMenuItem.Enabled = false;
            }
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            clearLayoutToolStripMenuItem.Enabled = true;
            fitLayoutToolStripMenuItem.Enabled = true;
            saveLayoutToolStripMenuItem.Enabled = true;
        }

        private void addManuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    Button b = new Button();
                    b.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileNames[i].ToString());
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control);
                    b.AutoSize = true;
                    b.BackColor = Color.Red;
                    b.TextAlign = ContentAlignment.MiddleRight;
                    b.ContextMenuStrip = bms;
                    b.Height = 50;
                    b.Width = 100;
                    b.BackColor = Color.Lime;
                    b.TextImageRelation = TextImageRelation.ImageBeforeText;
                    b.Image = System.Drawing.Icon.ExtractAssociatedIcon(openFileDialog1.FileNames[i].ToString()).ToBitmap();
                    b.Tag = openFileDialog1.FileNames[i].ToString();
                    b.Click += B_Click;
                    flowLayoutPanel1.Controls.Add(b);
                }

            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count < 1)
            {
                clearLayoutToolStripMenuItem.Enabled = false;
                fitLayoutToolStripMenuItem.Enabled = false;
                saveLayoutToolStripMenuItem.Enabled = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Directory.GetFiles(XmlHelper.basePath).Length > 0)
            {
                updateOrDeleteLayoutToolStripMenuItem.Enabled = true;
                loadLayoutToolStripMenuItem.Enabled = true;
            }
            else
            {
                updateOrDeleteLayoutToolStripMenuItem.Enabled = false;
                loadLayoutToolStripMenuItem.Enabled = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe ab = new AboutMe();
            ab.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutMe ab = new AboutMe();
            ab.ShowDialog();
        }

        private void Launcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
        }
    }
}