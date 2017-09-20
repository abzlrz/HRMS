﻿namespace Presentation.DialogBox.ExternalApplication
{
    partial class ControlApplicationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlApplicationDetails));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_preferredSite = new System.Windows.Forms.ComboBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_position = new System.Windows.Forms.ComboBox();
            this.lbl_preferredSite = new System.Windows.Forms.Label();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_employeeName = new System.Windows.Forms.ComboBox();
            this.lbl_employeeName = new System.Windows.Forms.Label();
            this.lbl_source = new System.Windows.Forms.Label();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.cbx_source = new System.Windows.Forms.ComboBox();
            this.cbx_employeeID = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 400);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Details";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.34471F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.65529F));
            this.tableLayoutPanel2.Controls.Add(this.cbx_preferredSite, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_position, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbx_position, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_preferredSite, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker8, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(53, 202);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(496, 71);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cbx_preferredSite
            // 
            this.cbx_preferredSite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_preferredSite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_preferredSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_preferredSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_preferredSite.FormattingEnabled = true;
            this.cbx_preferredSite.Items.AddRange(new object[] {
            "Alabang",
            "Eastwood",
            "Clark, Pampanga"});
            this.cbx_preferredSite.Location = new System.Drawing.Point(216, 48);
            this.cbx_preferredSite.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_preferredSite.Name = "cbx_preferredSite";
            this.cbx_preferredSite.Size = new System.Drawing.Size(278, 21);
            this.cbx_preferredSite.TabIndex = 89;
            this.cbx_preferredSite.SelectedIndexChanged += new System.EventHandler(this.cbx_preferredSite_SelectedIndexChanged);
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_position.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_position.ImageIndex = 1;
            this.lbl_position.ImageList = this.imageList;
            this.lbl_position.Location = new System.Drawing.Point(5, 2);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(206, 21);
            this.lbl_position.TabIndex = 51;
            this.lbl_position.Text = "Position:";
            this.lbl_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "green_dot.png");
            this.imageList.Images.SetKeyName(1, "red_dot.png");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "Application Date:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_position
            // 
            this.cbx_position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_position.FormattingEnabled = true;
            this.cbx_position.Items.AddRange(new object[] {
            "Applicant Referral",
            "Employee Referral",
            "Word of Mouth",
            "Jobstreet",
            "Social Media",
            "Billboards",
            "Banner/Poster/Flyer",
            "TV/Radio/Newspaper Ad",
            "Recruitment Events/Job Fair",
            "Recruitment Partners/Vendors",
            "Former Employee",
            "Others"});
            this.cbx_position.Location = new System.Drawing.Point(216, 2);
            this.cbx_position.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_position.Name = "cbx_position";
            this.cbx_position.Size = new System.Drawing.Size(278, 21);
            this.cbx_position.TabIndex = 76;
            this.cbx_position.SelectedIndexChanged += new System.EventHandler(this.cbx_position_SelectedIndexChanged);
            // 
            // lbl_preferredSite
            // 
            this.lbl_preferredSite.AutoSize = true;
            this.lbl_preferredSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_preferredSite.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preferredSite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_preferredSite.ImageIndex = 1;
            this.lbl_preferredSite.ImageList = this.imageList;
            this.lbl_preferredSite.Location = new System.Drawing.Point(5, 48);
            this.lbl_preferredSite.Name = "lbl_preferredSite";
            this.lbl_preferredSite.Size = new System.Drawing.Size(206, 21);
            this.lbl_preferredSite.TabIndex = 83;
            this.lbl_preferredSite.Text = "Preffered Site:";
            this.lbl_preferredSite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker8.Location = new System.Drawing.Point(216, 25);
            this.dateTimePicker8.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.Size = new System.Drawing.Size(278, 22);
            this.dateTimePicker8.TabIndex = 88;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.34471F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.65529F));
            this.tableLayoutPanel3.Controls.Add(this.cbx_employeeName, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_employeeName, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_source, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_employeeID, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbx_source, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbx_employeeID, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(53, 109);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(496, 71);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // cbx_employeeName
            // 
            this.cbx_employeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_employeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_employeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_employeeName.Enabled = false;
            this.cbx_employeeName.FormattingEnabled = true;
            this.cbx_employeeName.Location = new System.Drawing.Point(216, 49);
            this.cbx_employeeName.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_employeeName.Name = "cbx_employeeName";
            this.cbx_employeeName.Size = new System.Drawing.Size(278, 21);
            this.cbx_employeeName.TabIndex = 83;
            this.cbx_employeeName.TextChanged += new System.EventHandler(this.cbx_employeeName_TextChanged);
            // 
            // lbl_employeeName
            // 
            this.lbl_employeeName.AutoSize = true;
            this.lbl_employeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_employeeName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeeName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_employeeName.ImageList = this.imageList;
            this.lbl_employeeName.Location = new System.Drawing.Point(5, 49);
            this.lbl_employeeName.Name = "lbl_employeeName";
            this.lbl_employeeName.Size = new System.Drawing.Size(206, 20);
            this.lbl_employeeName.TabIndex = 80;
            this.lbl_employeeName.Text = "Name:";
            this.lbl_employeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_source.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_source.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_source.ImageIndex = 1;
            this.lbl_source.ImageList = this.imageList;
            this.lbl_source.Location = new System.Drawing.Point(5, 2);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(206, 21);
            this.lbl_source.TabIndex = 51;
            this.lbl_source.Text = "Source:";
            this.lbl_source.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_employeeID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeeID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_employeeID.ImageList = this.imageList;
            this.lbl_employeeID.Location = new System.Drawing.Point(5, 25);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(206, 22);
            this.lbl_employeeID.TabIndex = 52;
            this.lbl_employeeID.Text = "Employee ID:";
            this.lbl_employeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_source
            // 
            this.cbx_source.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_source.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_source.FormattingEnabled = true;
            this.cbx_source.Items.AddRange(new object[] {
            "Applicant Referral",
            "Employee Referral",
            "Word of Mouth",
            "Jobstreet",
            "Social Media",
            "Billboards",
            "Banner/Poster/Flyer",
            "TV/Radio/Newspaper Ad",
            "Recruitment Events/Job Fair",
            "Recruitment Partners/Vendors",
            "Former Employee",
            "Others"});
            this.cbx_source.Location = new System.Drawing.Point(216, 2);
            this.cbx_source.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_source.Name = "cbx_source";
            this.cbx_source.Size = new System.Drawing.Size(278, 21);
            this.cbx_source.TabIndex = 76;
            this.cbx_source.SelectedIndexChanged += new System.EventHandler(this.cbx_source_SelectedIndexChanged);
            // 
            // cbx_employeeID
            // 
            this.cbx_employeeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_employeeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_employeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_employeeID.Enabled = false;
            this.cbx_employeeID.FormattingEnabled = true;
            this.cbx_employeeID.Location = new System.Drawing.Point(216, 25);
            this.cbx_employeeID.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_employeeID.Name = "cbx_employeeID";
            this.cbx_employeeID.Size = new System.Drawing.Size(278, 21);
            this.cbx_employeeID.TabIndex = 82;
            this.cbx_employeeID.SelectedIndexChanged += new System.EventHandler(this.cbx_employeeID_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_next);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_previous);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(12, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 91);
            this.panel2.TabIndex = 3;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(492, 35);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 35);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DimGray;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(330, 35);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 35);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_previous.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(411, 35);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 35);
            this.btn_previous.TabIndex = 13;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // ControlApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Name = "ControlApplicationDetails";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(641, 515);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_employeeName;
        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.ComboBox cbx_source;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbx_preferredSite;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_position;
        private System.Windows.Forms.Label lbl_preferredSite;
        private System.Windows.Forms.DateTimePicker dateTimePicker8;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.ComboBox cbx_employeeName;
        private System.Windows.Forms.ComboBox cbx_employeeID;
    }
}
