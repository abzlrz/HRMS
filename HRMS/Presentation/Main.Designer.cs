namespace Presentation
{
    partial class Main
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
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Interview Evaluation");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Employee Registration");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Employee Registration (Existing)");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Recruitment", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Training Schedule");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Training Feedback & Assesment");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Training", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Performance Appraisal");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Employee Resignation");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Exit Interview");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Reliving", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Recruitment");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Training");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Performance Appraisal");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Reliving");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Reporting", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("5th Month");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Contract");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Notifications", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHRMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(12, 27);
            this.treeView.Name = "treeView";
            treeNode20.ImageIndex = 0;
            treeNode20.Name = "Node2";
            treeNode20.Text = "Interview Evaluation";
            treeNode21.ImageIndex = 0;
            treeNode21.Name = "Node3";
            treeNode21.Text = "Employee Registration";
            treeNode22.ImageIndex = 0;
            treeNode22.Name = "Node0";
            treeNode22.Text = "Employee Registration (Existing)";
            treeNode23.ImageIndex = 0;
            treeNode23.Name = "Node0";
            treeNode23.Text = "Recruitment";
            treeNode24.ImageIndex = 0;
            treeNode24.Name = "Node4";
            treeNode24.Text = "Training Schedule";
            treeNode25.ImageIndex = 0;
            treeNode25.Name = "Node6";
            treeNode25.Text = "Training Feedback & Assesment";
            treeNode26.ImageIndex = 0;
            treeNode26.Name = "Node1";
            treeNode26.Text = "Training";
            treeNode27.ImageIndex = 0;
            treeNode27.Name = "Node7";
            treeNode27.Text = "Performance Appraisal";
            treeNode28.ImageIndex = 0;
            treeNode28.Name = "Node9";
            treeNode28.Text = "Employee Resignation";
            treeNode29.ImageIndex = 0;
            treeNode29.Name = "Node10";
            treeNode29.Text = "Exit Interview";
            treeNode30.ImageIndex = 0;
            treeNode30.Name = "Node8";
            treeNode30.Text = "Reliving";
            treeNode31.ImageIndex = 0;
            treeNode31.Name = "Node12";
            treeNode31.Text = "Recruitment";
            treeNode32.ImageIndex = 0;
            treeNode32.Name = "Node14";
            treeNode32.Text = "Training";
            treeNode33.ImageIndex = 0;
            treeNode33.Name = "Node15";
            treeNode33.Text = "Performance Appraisal";
            treeNode34.ImageIndex = 0;
            treeNode34.Name = "Node16";
            treeNode34.Text = "Reliving";
            treeNode35.ImageIndex = 0;
            treeNode35.Name = "Node11";
            treeNode35.Text = "Reporting";
            treeNode36.ImageIndex = 0;
            treeNode36.Name = "Node18";
            treeNode36.Text = "5th Month";
            treeNode37.ImageIndex = 0;
            treeNode37.Name = "Node20";
            treeNode37.Text = "Contract";
            treeNode38.ImageIndex = 0;
            treeNode38.Name = "Node17";
            treeNode38.Text = "Notifications";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode26,
            treeNode27,
            treeNode30,
            treeNode35,
            treeNode38});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(243, 690);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnTreeViewAfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "user.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(261, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1077, 690);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.AutoSize = false;
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signoutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // signoutToolStripMenuItem
            // 
            this.signoutToolStripMenuItem.Name = "signoutToolStripMenuItem";
            this.signoutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.signoutToolStripMenuItem.Text = "Sign-out";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // fileManagementToolStripMenuItem
            // 
            this.fileManagementToolStripMenuItem.Name = "fileManagementToolStripMenuItem";
            this.fileManagementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.fileManagementToolStripMenuItem.Text = "File Management";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutHRMSToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.viewHelpToolStripMenuItem.Text = "Manual";
            // 
            // aboutHRMSToolStripMenuItem
            // 
            this.aboutHRMSToolStripMenuItem.Name = "aboutHRMSToolStripMenuItem";
            this.aboutHRMSToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aboutHRMSToolStripMenuItem.Text = "About HRMS";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 728);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHRMSToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
    }
}

