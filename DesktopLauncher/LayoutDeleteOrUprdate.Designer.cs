
namespace DesktopLauncher
{
    partial class LayoutDeleteOrUprdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataLayoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LayoutName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LayoutDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LayoutName,
            this.layoutUpdate,
            this.LayoutDelete});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataLayoutBindingSource
            // 
            this.dataLayoutBindingSource.DataSource = typeof(DesktopLauncher.DataLayout);
            // 
            // LayoutName
            // 
            this.LayoutName.HeaderText = "Layout Name";
            this.LayoutName.MinimumWidth = 6;
            this.LayoutName.Name = "LayoutName";
            this.LayoutName.ReadOnly = true;
            // 
            // layoutUpdate
            // 
            this.layoutUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.layoutUpdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.layoutUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.layoutUpdate.HeaderText = "Update";
            this.layoutUpdate.MinimumWidth = 6;
            this.layoutUpdate.Name = "layoutUpdate";
            this.layoutUpdate.ReadOnly = true;
            this.layoutUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.layoutUpdate.Text = "Update";
            this.layoutUpdate.UseColumnTextForButtonValue = true;
            // 
            // LayoutDelete
            // 
            this.LayoutDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.LayoutDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.LayoutDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayoutDelete.HeaderText = "Delete";
            this.LayoutDelete.MinimumWidth = 6;
            this.LayoutDelete.Name = "LayoutDelete";
            this.LayoutDelete.ReadOnly = true;
            this.LayoutDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LayoutDelete.Text = "Delete";
            this.LayoutDelete.UseColumnTextForButtonValue = true;
            // 
            // LayoutDeleteOrUprdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LayoutDeleteOrUprdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LayoutDelete";
            this.Load += new System.EventHandler(this.LayoutDeleteOrUprdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataLayoutBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn LayoutName;
        private System.Windows.Forms.DataGridViewButtonColumn layoutUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn LayoutDelete;
    }
}