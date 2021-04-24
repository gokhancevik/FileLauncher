using DesktopLauncher.Utilities;

using System;
using System.IO;
using System.Windows.Forms;

namespace DesktopLauncher
{
    public partial class LayoutLoad : Form
    {
        public LayoutLoad()
        {
            InitializeComponent();
        }

        private void LayoutLoad_Load(object sender, EventArgs e)
        {
            lbllc.Text = $"{XmlHelper.GetLayoutId() - 1} layout found.";
            layoutNames.Items.Clear();
            string filePath = Path.Combine(Application.StartupPath, "LayoutDatas");
            int c = Directory.GetFiles(filePath).Length;
            string[] list = new string[c];
            for (int i = 0; i < c; i++)
            {
                list[i] = Path.GetFileNameWithoutExtension(Directory.GetFiles(filePath)[i]);
            }
            layoutNames.Items.AddRange(list);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            AppUtilities._loadName = layoutNames.SelectedItem.ToString();
            this.Close();
        }
    }
}
