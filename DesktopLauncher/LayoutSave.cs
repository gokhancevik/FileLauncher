using DesktopLauncher.Utilities;

using System;
using System.IO;
using System.Windows.Forms;

namespace DesktopLauncher
{
    public partial class LayoutSave : Form
    {
        public LayoutSave()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(layoutName.Text) || string.IsNullOrWhiteSpace(layoutName.Text))
                return;
            string file = Path.Combine(Application.StartupPath, "LayoutDatas", layoutName.Text+".xml");
            if (File.Exists(file))
            {
                MessageBox.Show($"This layout name {layoutName.Text} has been used before. Please change name.","File name exists",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            AppUtilities._fileName = layoutName.Text;
            AppUtilities._isDefault = checkBox1.Checked;
            string filePath = Path.Combine(Application.StartupPath, "LayoutDatas");
            int c = Directory.GetFiles(filePath).Length;
            c++;
            AppUtilities._layoutId = c;
            MessageBox.Show($"{layoutName.Text} saved","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (checkBox1.Checked)
            {
                SetDefault.Default.defaultPath = Path.Combine(XmlHelper.basePath, $"{layoutName.Text}.xml");
                SetDefault.Default.Save();
            }
            this.Close();
        }
    }
}
