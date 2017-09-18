namespace Presentation.DialogBox.ExternalApplicationForm
{
    partial class FormBackgroundEducation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackgroundEducation));
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_fromdate = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tbx_course = new System.Windows.Forms.TextBox();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_school = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.tbx_school = new System.Windows.Forms.TextBox();
            this.tbx_location = new System.Windows.Forms.TextBox();
            this.cbx_degree = new System.Windows.Forms.ComboBox();
            this.lbl_todate = new System.Windows.Forms.Label();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.view_education = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.main = new System.Windows.Forms.Panel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view_education)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date_to
            // 
            this.date_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_to.Location = new System.Drawing.Point(146, 150);
            this.date_to.Margin = new System.Windows.Forms.Padding(0);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(207, 20);
            this.date_to.TabIndex = 115;
            this.date_to.ValueChanged += new System.EventHandler(this.date_to_ValueChanged);
            // 
            // lbl_fromdate
            // 
            this.lbl_fromdate.AutoSize = true;
            this.lbl_fromdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_fromdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpString(this.lbl_fromdate, "This field is required to fill up");
            this.lbl_fromdate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_fromdate.ImageIndex = 1;
            this.lbl_fromdate.ImageList = this.imageList;
            this.lbl_fromdate.Location = new System.Drawing.Point(3, 120);
            this.lbl_fromdate.Name = "lbl_fromdate";
            this.helpProvider.SetShowHelp(this.lbl_fromdate, true);
            this.lbl_fromdate.Size = new System.Drawing.Size(140, 30);
            this.lbl_fromdate.TabIndex = 112;
            this.lbl_fromdate.Text = "From Date:";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "green_dot.png");
            this.imageList.Images.SetKeyName(1, "red_dot.png");
            // 
            // tbx_course
            // 
            this.tbx_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_course.Location = new System.Drawing.Point(146, 90);
            this.tbx_course.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_course.Name = "tbx_course";
            this.tbx_course.Size = new System.Drawing.Size(207, 20);
            this.tbx_course.TabIndex = 111;
            this.tbx_course.Tag = "required";
            this.tbx_course.TextChanged += new System.EventHandler(this.tbx_course_TextChanged);
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_course.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpString(this.lbl_course, "This field is required to fill up");
            this.lbl_course.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_course.ImageIndex = 1;
            this.lbl_course.ImageList = this.imageList;
            this.lbl_course.Location = new System.Drawing.Point(3, 90);
            this.lbl_course.Name = "lbl_course";
            this.helpProvider.SetShowHelp(this.lbl_course, true);
            this.lbl_course.Size = new System.Drawing.Size(140, 30);
            this.lbl_course.TabIndex = 90;
            this.lbl_course.Text = "Course/Program:";
            // 
            // lbl_school
            // 
            this.lbl_school.AutoSize = true;
            this.lbl_school.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_school.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpString(this.lbl_school, "This field is required to fill up");
            this.lbl_school.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_school.ImageIndex = 1;
            this.lbl_school.ImageList = this.imageList;
            this.lbl_school.Location = new System.Drawing.Point(3, 0);
            this.lbl_school.Name = "lbl_school";
            this.helpProvider.SetShowHelp(this.lbl_school, true);
            this.lbl_school.Size = new System.Drawing.Size(140, 30);
            this.lbl_school.TabIndex = 51;
            this.lbl_school.Text = "School/University:";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_location.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpString(this.lbl_location, "This field is required to fill up");
            this.lbl_location.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_location.ImageIndex = 1;
            this.lbl_location.ImageList = this.imageList;
            this.lbl_location.Location = new System.Drawing.Point(3, 30);
            this.lbl_location.Name = "lbl_location";
            this.helpProvider.SetShowHelp(this.lbl_location, true);
            this.lbl_location.Size = new System.Drawing.Size(140, 30);
            this.lbl_location.TabIndex = 52;
            this.lbl_location.Text = "Location:";
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_degree.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpString(this.lbl_degree, "This field is required to fill up");
            this.lbl_degree.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_degree.ImageIndex = 1;
            this.lbl_degree.ImageList = this.imageList;
            this.lbl_degree.Location = new System.Drawing.Point(3, 60);
            this.lbl_degree.Name = "lbl_degree";
            this.helpProvider.SetShowHelp(this.lbl_degree, true);
            this.lbl_degree.Size = new System.Drawing.Size(140, 30);
            this.lbl_degree.TabIndex = 83;
            this.lbl_degree.Text = "Academic Degree:";
            // 
            // tbx_school
            // 
            this.tbx_school.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_school.Location = new System.Drawing.Point(146, 0);
            this.tbx_school.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_school.Name = "tbx_school";
            this.tbx_school.Size = new System.Drawing.Size(207, 20);
            this.tbx_school.TabIndex = 108;
            this.tbx_school.Tag = "required";
            this.tbx_school.TextChanged += new System.EventHandler(this.tbx_school_TextChanged);
            // 
            // tbx_location
            // 
            this.tbx_location.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_location.Location = new System.Drawing.Point(146, 30);
            this.tbx_location.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_location.Name = "tbx_location";
            this.tbx_location.Size = new System.Drawing.Size(207, 20);
            this.tbx_location.TabIndex = 109;
            this.tbx_location.Tag = "required";
            this.tbx_location.TextChanged += new System.EventHandler(this.tbx_location_TextChanged);
            // 
            // cbx_degree
            // 
            this.cbx_degree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_degree.FormattingEnabled = true;
            this.cbx_degree.Items.AddRange(new object[] {
            "Diploma",
            "Bachelor",
            "Masteral",
            "Doctorate",
            "Others"});
            this.cbx_degree.Location = new System.Drawing.Point(146, 60);
            this.cbx_degree.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_degree.Name = "cbx_degree";
            this.cbx_degree.Size = new System.Drawing.Size(207, 21);
            this.cbx_degree.TabIndex = 110;
            this.cbx_degree.SelectedIndexChanged += new System.EventHandler(this.cbx_degree_SelectedIndexChanged);
            // 
            // lbl_todate
            // 
            this.lbl_todate.AutoSize = true;
            this.lbl_todate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_todate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpString(this.lbl_todate, "This field is required to fill up");
            this.lbl_todate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_todate.ImageIndex = 1;
            this.lbl_todate.ImageList = this.imageList;
            this.lbl_todate.Location = new System.Drawing.Point(3, 150);
            this.lbl_todate.Name = "lbl_todate";
            this.helpProvider.SetShowHelp(this.lbl_todate, true);
            this.lbl_todate.Size = new System.Drawing.Size(140, 51);
            this.lbl_todate.TabIndex = 113;
            this.lbl_todate.Text = "To Date:";
            // 
            // date_from
            // 
            this.date_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_from.Location = new System.Drawing.Point(146, 120);
            this.date_from.Margin = new System.Windows.Forms.Padding(0);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(207, 20);
            this.date_from.TabIndex = 114;
            this.date_from.Value = new System.DateTime(2017, 9, 18, 20, 0, 8, 0);
            this.date_from.ValueChanged += new System.EventHandler(this.date_from_ValueChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(300, 260);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(138, 260);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Green;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(219, 260);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Save";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // view_education
            // 
            this.view_education.BackgroundColor = System.Drawing.Color.White;
            this.view_education.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_education.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_education.Location = new System.Drawing.Point(5, 5);
            this.view_education.Name = "view_education";
            this.view_education.Size = new System.Drawing.Size(186, 284);
            this.view_education.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.view_education);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(196, 294);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.64306F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.35694F));
            this.tableLayoutPanel6.Controls.Add(this.date_to, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.lbl_fromdate, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.tbx_course, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_course, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_school, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_location, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_degree, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tbx_school, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbx_location, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.cbx_degree, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbl_todate, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.date_from, 1, 4);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(353, 201);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // main
            // 
            this.main.Controls.Add(this.btn_delete);
            this.main.Controls.Add(this.btn_add);
            this.main.Controls.Add(this.btn_edit);
            this.main.Controls.Add(this.tableLayoutPanel6);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(208, 12);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(408, 294);
            this.main.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 52);
            this.panel1.TabIndex = 6;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(529, 27);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 25);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(448, 27);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 25);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // FormBackgroundEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 370);
            this.Controls.Add(this.main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackgroundEducation";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Education Background";
            ((System.ComponentModel.ISupportInitialize)(this.view_education)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.Label lbl_fromdate;
        private System.Windows.Forms.TextBox tbx_course;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_school;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.TextBox tbx_school;
        private System.Windows.Forms.TextBox tbx_location;
        private System.Windows.Forms.ComboBox cbx_degree;
        private System.Windows.Forms.Label lbl_todate;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridView view_education;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}