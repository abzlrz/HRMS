namespace Presentation.Modules
{
    partial class ControlInterviewEvaluation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.evaluateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.view_internalApplicant = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.view_employee = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbx_employee_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.view_external_applicant = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbx_applicant_search = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.panel4.SuspendLayout();
            this.view_internalApplicant.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_employee)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_external_applicant)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 400);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.view_internalApplicant);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 373);
            this.panel1.TabIndex = 1;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evaluateToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // evaluateToolStripMenuItem
            // 
            this.evaluateToolStripMenuItem.Name = "evaluateToolStripMenuItem";
            this.evaluateToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.evaluateToolStripMenuItem.Text = "Evaluate";
            this.evaluateToolStripMenuItem.Click += new System.EventHandler(this.OnEvaluateToolStripMenuItemClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1073, 23);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1073, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interview Evaluation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // view_internalApplicant
            // 
            this.view_internalApplicant.Controls.Add(this.tabPage1);
            this.view_internalApplicant.Controls.Add(this.tabPage2);
            this.view_internalApplicant.Controls.Add(this.tabPage3);
            this.view_internalApplicant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_internalApplicant.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_internalApplicant.HotTrack = true;
            this.view_internalApplicant.Location = new System.Drawing.Point(0, 0);
            this.view_internalApplicant.Name = "view_internalApplicant";
            this.view_internalApplicant.SelectedIndex = 0;
            this.view_internalApplicant.Size = new System.Drawing.Size(1073, 373);
            this.view_internalApplicant.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.view_employee);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1065, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accepted";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // view_employee
            // 
            this.view_employee.AllowUserToAddRows = false;
            this.view_employee.AllowUserToDeleteRows = false;
            this.view_employee.AllowUserToResizeRows = false;
            this.view_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_employee.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.view_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_employee.Location = new System.Drawing.Point(0, 27);
            this.view_employee.MultiSelect = false;
            this.view_employee.Name = "view_employee";
            this.view_employee.ReadOnly = true;
            this.view_employee.RowHeadersVisible = false;
            this.view_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_employee.Size = new System.Drawing.Size(1065, 320);
            this.view_employee.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbx_employee_search);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 27);
            this.panel3.TabIndex = 6;
            // 
            // tbx_employee_search
            // 
            this.tbx_employee_search.Location = new System.Drawing.Point(52, 3);
            this.tbx_employee_search.Name = "tbx_employee_search";
            this.tbx_employee_search.Size = new System.Drawing.Size(186, 22);
            this.tbx_employee_search.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.view_external_applicant);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1065, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rejected";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // view_external_applicant
            // 
            this.view_external_applicant.AllowUserToAddRows = false;
            this.view_external_applicant.AllowUserToDeleteRows = false;
            this.view_external_applicant.AllowUserToResizeRows = false;
            this.view_external_applicant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_external_applicant.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.view_external_applicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_external_applicant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_external_applicant.Location = new System.Drawing.Point(0, 27);
            this.view_external_applicant.MultiSelect = false;
            this.view_external_applicant.Name = "view_external_applicant";
            this.view_external_applicant.ReadOnly = true;
            this.view_external_applicant.RowHeadersVisible = false;
            this.view_external_applicant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_external_applicant.Size = new System.Drawing.Size(1065, 320);
            this.view_external_applicant.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbx_applicant_search);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 27);
            this.panel2.TabIndex = 7;
            // 
            // tbx_applicant_search
            // 
            this.tbx_applicant_search.Location = new System.Drawing.Point(52, 3);
            this.tbx_applicant_search.Name = "tbx_applicant_search";
            this.tbx_applicant_search.Size = new System.Drawing.Size(186, 22);
            this.tbx_applicant_search.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1065, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Shortlisted";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ControlInterviewEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ControlInterviewEvaluation";
            this.Size = new System.Drawing.Size(1075, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.view_internalApplicant.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_employee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_external_applicant)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem evaluateToolStripMenuItem;
        private System.Windows.Forms.TabControl view_internalApplicant;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView view_employee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbx_employee_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView view_external_applicant;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbx_applicant_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
