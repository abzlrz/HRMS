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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Interview Evaluation");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Employee Registration");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Employee Registration (Existing)");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Employee Performance Appraisal");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Employee PER Checklist");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Recruitment", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Training Schedule");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Training Feedback & Assesment");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Training", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Employee Resignation");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Reliving", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Reporting");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("5th Month");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Contract");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Notifications", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(12, 27);
            this.treeView.Name = "treeView";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Node2";
            treeNode1.Text = "Interview Evaluation";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "Node3";
            treeNode2.Text = "Employee Registration";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Node0";
            treeNode3.Text = "Employee Registration (Existing)";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Employee Performance Appraisal";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Employee PER Checklist";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "Node0";
            treeNode6.Text = "Recruitment";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "Node4";
            treeNode7.Text = "Training Schedule";
            treeNode8.ImageIndex = 0;
            treeNode8.Name = "Node6";
            treeNode8.Text = "Training Feedback & Assesment";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "Node1";
            treeNode9.Text = "Training";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "Node9";
            treeNode10.Text = "Employee Resignation";
            treeNode11.ImageIndex = 0;
            treeNode11.Name = "Node8";
            treeNode11.Text = "Reliving";
            treeNode12.ImageIndex = 0;
            treeNode12.Name = "Node11";
            treeNode12.Text = "Reporting";
            treeNode13.ImageIndex = 0;
            treeNode13.Name = "Node18";
            treeNode13.Text = "5th Month";
            treeNode14.ImageIndex = 0;
            treeNode14.Name = "Node20";
            treeNode14.Text = "Contract";
            treeNode15.ImageIndex = 0;
            treeNode15.Name = "Node17";
            treeNode15.Text = "Notifications";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9,
            treeNode11,
            treeNode12,
            treeNode15});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(243, 691);
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
            this.splitContainer1.Size = new System.Drawing.Size(1093, 691);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.signOutToolStripMenuItem.Text = "Sign-Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.OnSignoutToolStripMenuItemClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}

