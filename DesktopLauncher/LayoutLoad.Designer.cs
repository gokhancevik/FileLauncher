
namespace DesktopLauncher
{
    partial class LayoutLoad
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
            this.label1 = new System.Windows.Forms.Label();
            this.layoutNames = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataLayoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbllc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Layout Name";
            // 
            // layoutNames
            // 
            this.layoutNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layoutNames.FormattingEnabled = true;
            this.layoutNames.Location = new System.Drawing.Point(153, 18);
            this.layoutNames.Name = "layoutNames";
            this.layoutNames.Size = new System.Drawing.Size(315, 24);
            this.layoutNames.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(356, 71);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 38);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataLayoutBindingSource
            // 
            this.dataLayoutBindingSource.DataMember = "filePathList";
            this.dataLayoutBindingSource.DataSource = typeof(DesktopLauncher.DataLayout);
            // 
            // lbllc
            // 
            this.lbllc.AutoSize = true;
            this.lbllc.Location = new System.Drawing.Point(160, 82);
            this.lbllc.Name = "lbllc";
            this.lbllc.Size = new System.Drawing.Size(0, 17);
            this.lbllc.TabIndex = 0;
            // 
            // LayoutLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 138);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.layoutNames);
            this.Controls.Add(this.lbllc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LayoutLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Layout Load";
            this.Load += new System.EventHandler(this.LayoutLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox layoutNames;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource dataLayoutBindingSource;
        private System.Windows.Forms.Label lbllc;
    }
}