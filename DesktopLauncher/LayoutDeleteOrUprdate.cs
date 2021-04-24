using DesktopLauncher.Utilities;

using System;
using System.IO;
using System.Windows.Forms;

namespace DesktopLauncher
{
    public partial class LayoutDeleteOrUprdate : Form
    {
        public LayoutDeleteOrUprdate()
        {
            InitializeComponent();
        }

        private void LayoutDeleteOrUprdate_Load(object sender, EventArgs e)
        {
            LoadLayoutDatas();
        }


        public void LoadLayoutDatas()
        {
            dataGridView1.Rows.Clear();
            int c = Directory.GetFiles(XmlHelper.basePath).Length;
            string[] list = Directory.GetFiles(XmlHelper.basePath);
            for (int i = 0; i < c; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = Path.GetFileNameWithoutExtension(list[i]);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["layoutUpdate"].Index && e.RowIndex >= 0)
            {
                LayoutDetail dl = new LayoutDetail(XmlHelper.GetLayout(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                dl.ShowDialog();

            }
            if (e.ColumnIndex == dataGridView1.Columns["LayoutDelete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show($"Are you sure this setting {dataGridView1.Rows[e.RowIndex].Cells[0].Value} will be deleted?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool deleted = XmlHelper.DeleteLayout(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (deleted)
                    {
                        MessageBox.Show("Fail can't deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Success", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLayoutDatas();
                    }
                }
            }
        }
    }
}