namespace Presentation
{
    partial class FormMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Interview Evaluation");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Employee Registration");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Employee Performance Appraisal");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Recruitment", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Training Schedule");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Training Feedback & Assesment");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Training", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Employee Resignation");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Reliving", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Reporting");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("5th Month");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Contract");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Notifications", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.modPanel = new System.Windows.Forms.Panel();
            this.viewsPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.controlCurrentUserOnUse1 = new Presentation.Miscellaneous.ControlCurrentUserOnUse();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.Window;
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(12, 67);
            this.treeView.Name = "treeView";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Node2";
            treeNode1.Text = "Interview Evaluation";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Node3";
            treeNode2.Text = "Employee Registration";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Employee Performance Appraisal";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "Node0";
            treeNode4.Text = "Recruitment";
            treeNode5.ImageIndex = 0;
            treeNode5.Name = "Node4";
            treeNode5.Text = "Training Schedule";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "Node6";
            treeNode6.Text = "Training Feedback & Assesment";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "Node1";
            treeNode7.Text = "Training";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "Node9";
            treeNode8.Text = "Employee Resignation";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "Node8";
            treeNode9.Text = "Reliving";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "Node11";
            treeNode10.Text = "Reporting";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "Node18";
            treeNode11.Text = "5th Month";
            treeNode12.ImageIndex = 0;
            treeNode12.Name = "Node20";
            treeNode12.Text = "Contract";
            treeNode13.ImageIndex = 0;
            treeNode13.Name = "Node17";
            treeNode13.Text = "Notifications";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode9,
            treeNode10,
            treeNode13});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(243, 555);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnTreeViewAfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "user.png");
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 24);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1366, 25);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.userToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.userToolStripMenuItem.Text = "&User";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.signOutToolStripMenuItem.Text = "Sign-Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.OnSignoutToolStripMenuItemClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.auditLogsToolStripMenuItem,
            this.manageReferencesToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.Visible = false;
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.customizeToolStripMenuItem.Text = "&Manage Users";
            this.customizeToolStripMenuItem.Click += new System.EventHandler(this.customizeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.optionsToolStripMenuItem.Text = "Job Posting";
            // 
            // auditLogsToolStripMenuItem
            // 
            this.auditLogsToolStripMenuItem.Name = "auditLogsToolStripMenuItem";
            this.auditLogsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.auditLogsToolStripMenuItem.Text = "Audit Logs";
            this.auditLogsToolStripMenuItem.Click += new System.EventHandler(this.auditLogsToolStripMenuItem_Click);
            // 
            // manageReferencesToolStripMenuItem
            // 
            this.manageReferencesToolStripMenuItem.Name = "manageReferencesToolStripMenuItem";
            this.manageReferencesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.manageReferencesToolStripMenuItem.Text = "Manage References";
            this.manageReferencesToolStripMenuItem.Click += new System.EventHandler(this.manageReferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem,
            this.aboutUserToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutUserToolStripMenuItem
            // 
            this.aboutUserToolStripMenuItem.Name = "aboutUserToolStripMenuItem";
            this.aboutUserToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.aboutUserToolStripMenuItem.Text = "&About User...";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(261, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 686);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer);
            this.panel2.Location = new System.Drawing.Point(261, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 686);
            this.panel2.TabIndex = 5;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.modPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.viewsPanel);
            this.splitContainer.Size = new System.Drawing.Size(1093, 686);
            this.splitContainer.SplitterDistance = 405;
            this.splitContainer.TabIndex = 0;
            // 
            // modPanel
            // 
            this.modPanel.AutoScroll = true;
            this.modPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modPanel.Location = new System.Drawing.Point(0, 0);
            this.modPanel.Name = "modPanel";
            this.modPanel.Size = new System.Drawing.Size(1093, 405);
            this.modPanel.TabIndex = 0;
            // 
            // viewsPanel
            // 
            this.viewsPanel.AutoScroll = true;
            this.viewsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewsPanel.Location = new System.Drawing.Point(0, 0);
            this.viewsPanel.Name = "viewsPanel";
            this.viewsPanel.Size = new System.Drawing.Size(1093, 277);
            this.viewsPanel.TabIndex = 0;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.header.Controls.Add(this.label3);
            this.header.Controls.Add(this.x1);
            this.header.Controls.Add(this.x3);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1366, 24);
            this.header.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "  Main - Arvato HRMS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.Color.Transparent;
            this.x1.Dock = System.Windows.Forms.DockStyle.Right;
            this.x1.FlatAppearance.BorderSize = 0;
            this.x1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.x1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(151)))), ((int)(((byte)(206)))));
            this.x1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x1.ForeColor = System.Drawing.Color.Transparent;
            this.x1.Image = global::Presentation.Properties.Resources.minimize;
            this.x1.Location = new System.Drawing.Point(1312, 0);
            this.x1.Margin = new System.Windows.Forms.Padding(0);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(27, 24);
            this.x1.TabIndex = 5;
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.minimizeClick);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.Transparent;
            this.x3.Dock = System.Windows.Forms.DockStyle.Right;
            this.x3.FlatAppearance.BorderSize = 0;
            this.x3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.x3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(151)))), ((int)(((byte)(206)))));
            this.x3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x3.ForeColor = System.Drawing.Color.Transparent;
            this.x3.Image = global::Presentation.Properties.Resources.exit;
            this.x3.Location = new System.Drawing.Point(1339, 0);
            this.x3.Margin = new System.Windows.Forms.Padding(0);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(27, 24);
            this.x3.TabIndex = 3;
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.closeClick);
            // 
            // controlCurrentUserOnUse1
            // 
            this.controlCurrentUserOnUse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlCurrentUserOnUse1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.controlCurrentUserOnUse1.Location = new System.Drawing.Point(12, 628);
            this.controlCurrentUserOnUse1.Name = "controlCurrentUserOnUse1";
            this.controlCurrentUserOnUse1.Size = new System.Drawing.Size(243, 125);
            this.controlCurrentUserOnUse1.TabIndex = 19;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.controlCurrentUserOnUse1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoad);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer;
        public System.Windows.Forms.Panel modPanel;
        public System.Windows.Forms.Panel viewsPanel;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.ToolStripMenuItem auditLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUserToolStripMenuItem;
        private Miscellaneous.ControlCurrentUserOnUse controlCurrentUserOnUse1;
        public System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    }
}

