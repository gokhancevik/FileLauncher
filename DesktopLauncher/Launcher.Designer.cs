
namespace DesktopLauncher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateOrDeleteLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addManuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.currentLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 444);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlAdded);
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlRemoved);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // bms
            // 
            this.bms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.bms.Name = "bms";
            this.bms.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.currentLayout});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShowShortcutKeys = false;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLayoutToolStripMenuItem,
            this.loadLayoutToolStripMenuItem,
            this.updateOrDeleteLayoutToolStripMenuItem,
            this.clearLayoutToolStripMenuItem,
            this.fitLayoutToolStripMenuItem,
            this.addManuelToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShowShortcutKeys = false;
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // saveLayoutToolStripMenuItem
            // 
            this.saveLayoutToolStripMenuItem.Name = "saveLayoutToolStripMenuItem";
            this.saveLayoutToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.saveLayoutToolStripMenuItem.Text = "Save Layout";
            this.saveLayoutToolStripMenuItem.Click += new System.EventHandler(this.saveLayoutToolStripMenuItem_Click);
            // 
            // loadLayoutToolStripMenuItem
            // 
            this.loadLayoutToolStripMenuItem.Name = "loadLayoutToolStripMenuItem";
            this.loadLayoutToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.loadLayoutToolStripMenuItem.Text = "Load Layout";
            this.loadLayoutToolStripMenuItem.Click += new System.EventHandler(this.loadLayoutToolStripMenuItem_Click);
            // 
            // updateOrDeleteLayoutToolStripMenuItem
            // 
            this.updateOrDeleteLayoutToolStripMenuItem.Name = "updateOrDeleteLayoutToolStripMenuItem";
            this.updateOrDeleteLayoutToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.updateOrDeleteLayoutToolStripMenuItem.Text = "Update Or Delete Layout";
            this.updateOrDeleteLayoutToolStripMenuItem.Click += new System.EventHandler(this.updateOrDeleteLayoutToolStripMenuItem_Click);
            // 
            // clearLayoutToolStripMenuItem
            // 
            this.clearLayoutToolStripMenuItem.Name = "clearLayoutToolStripMenuItem";
            this.clearLayoutToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.clearLayoutToolStripMenuItem.Text = "Clear Layout";
            this.clearLayoutToolStripMenuItem.Click += new System.EventHandler(this.clearLayoutToolStripMenuItem_Click);
            // 
            // fitLayoutToolStripMenuItem
            // 
            this.fitLayoutToolStripMenuItem.Name = "fitLayoutToolStripMenuItem";
            this.fitLayoutToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.fitLayoutToolStripMenuItem.Text = "Fit Layout";
            this.fitLayoutToolStripMenuItem.Click += new System.EventHandler(this.fitLayoutToolStripMenuItem_Click);
            // 
            // addManuelToolStripMenuItem
            // 
            this.addManuelToolStripMenuItem.Name = "addManuelToolStripMenuItem";
            this.addManuelToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.addManuelToolStripMenuItem.Text = "Add Manuel";
            this.addManuelToolStripMenuItem.Click += new System.EventHandler(this.addManuelToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // currentLayout
            // 
            this.currentLayout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.currentLayout.AutoToolTip = true;
            this.currentLayout.Checked = true;
            this.currentLayout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.currentLayout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.currentLayout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.currentLayout.ForeColor = System.Drawing.Color.DarkBlue;
            this.currentLayout.Name = "currentLayout";
            this.currentLayout.ShowShortcutKeys = false;
            this.currentLayout.Size = new System.Drawing.Size(118, 24);
            this.currentLayout.Text = "Current Layout";
            this.currentLayout.ToolTipText = "Current Layout";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Launch Files";
            this.notifyIcon1.BalloonTipTitle = "You can close program here.";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Launch Files";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 52);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Launcher
            // 
            this.AccessibleName = " ";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launch Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_FormClosing);
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.bms.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip bms;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateOrDeleteLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addManuelToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem currentLayout;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

