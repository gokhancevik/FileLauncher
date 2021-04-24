using DesktopLauncher.Utilities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DesktopLauncher
{
    public partial class LayoutDetail : Form
    {
        DataLayout dl;
        public LayoutDetail(DataLayout ld)
        {
            dl = ld;
            InitializeComponent();
        }

        private void LayoutDetail_Load(object sender, EventArgs e)
        {
            txtlayoutName.Text = dl.layoutName;
            if (SetDefault.Default.defaultPath != null)
            {
                if (dl.basePath == SetDefault.Default.defaultPath)
                {
                    cbDefault.Checked = true;
                }
                else
                {
                    cbDefault.Checked = false;
                }
            }
            else
            {
                cbDefault.Checked = dl.isDefault;
            }
            for (int i = 0; i < dl.filePathList.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = dl.filePathList[i];
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> pl = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    pl.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }
            DataLayout dd = new DataLayout()
            {
                basePath = dl.basePath,
                layoutId = dl.layoutId,
                isDefault = cbDefault.Checked,
                layoutDate = DateTime.Now,
                layoutName = txtlayoutName.Text,
                filePathList = pl
            };
            if (XmlHelper.UpdateLayout(dl.layoutName, dd))
            {
                MessageBox.Show("Success", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cbDefault.Checked)
                {
                    SetDefault.Default.defaultPath = Path.Combine(XmlHelper.basePath, $"{txtlayoutName.Text}.xml");
                    SetDefault.Default.Save();

                }
                (System.Windows.Forms.Application.OpenForms["LayoutDeleteOrUprdate"] as LayoutDeleteOrUprdate).LoadLayoutDatas();
            }
            else
            {
                MessageBox.Show("Fail", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}