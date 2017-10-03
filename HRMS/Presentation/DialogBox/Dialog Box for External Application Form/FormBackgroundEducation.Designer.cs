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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.btn_add_save = new System.Windows.Forms.Button();
            this.btn_add_reset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.date_add_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_add_from = new System.Windows.Forms.Label();
            this.tbx_add_program = new System.Windows.Forms.TextBox();
            this.lbl_add_program = new System.Windows.Forms.Label();
            this.lbl_add_school = new System.Windows.Forms.Label();
            this.lbl_add_location = new System.Windows.Forms.Label();
            this.lbl_add_degree = new System.Windows.Forms.Label();
            this.tbx_add_school = new System.Windows.Forms.TextBox();
            this.tbx_add_location = new System.Windows.Forms.TextBox();
            this.cbx_add_degree = new System.Windows.Forms.ComboBox();
            this.lbl_add_to = new System.Windows.Forms.Label();
            this.date_add_from = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_edit_save = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.date_edit_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_edit_from = new System.Windows.Forms.Label();
            this.tbx_edit_program = new System.Windows.Forms.TextBox();
            this.lbl_edit_program = new System.Windows.Forms.Label();
            this.lbl_edit_school = new System.Windows.Forms.Label();
            this.lbl_edit_location = new System.Windows.Forms.Label();
            this.lbl_edit_degree = new System.Windows.Forms.Label();
            this.tbx_edit_school = new System.Windows.Forms.TextBox();
            this.tbx_edit_location = new System.Windows.Forms.TextBox();
            this.cbx_edit_degree = new System.Windows.Forms.ComboBox();
            this.lbl_edit_to = new System.Windows.Forms.Label();
            this.date_edit_from = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.view_educ = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_educ)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "green_dot.png");
            this.imageList.Images.SetKeyName(1, "red_dot.png");
            // 
            // btn_add_save
            // 
            this.btn_add_save.BackColor = System.Drawing.Color.Green;
            this.btn_add_save.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_add_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_save.ForeColor = System.Drawing.Color.White;
            this.helpProvider.SetHelpString(this.btn_add_save, "Put input values on fields first before saving");
            this.btn_add_save.Location = new System.Drawing.Point(193, 217);
            this.btn_add_save.Name = "btn_add_save";
            this.helpProvider.SetShowHelp(this.btn_add_save, true);
            this.btn_add_save.Size = new System.Drawing.Size(75, 33);
            this.btn_add_save.TabIndex = 10;
            this.btn_add_save.Text = "Save";
            this.btn_add_save.UseVisualStyleBackColor = false;
            this.btn_add_save.Click += new System.EventHandler(this.btn_add_save_Click);
            // 
            // btn_add_reset
            // 
            this.btn_add_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.btn_add_reset.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_add_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_reset.ForeColor = System.Drawing.Color.White;
            this.helpProvider.SetHelpString(this.btn_add_reset, "Put input values on fields first before saving");
            this.btn_add_reset.Location = new System.Drawing.Point(112, 217);
            this.btn_add_reset.Name = "btn_add_reset";
            this.helpProvider.SetShowHelp(this.btn_add_reset, true);
            this.btn_add_reset.Size = new System.Drawing.Size(75, 33);
            this.btn_add_reset.TabIndex = 11;
            this.btn_add_reset.Text = "Reset";
            this.btn_add_reset.UseVisualStyleBackColor = false;
            this.btn_add_reset.Click += new System.EventHandler(this.btn_add_reset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 33);
            this.panel1.TabIndex = 6;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(789, 8);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 25);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 315);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.main);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(414, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.main.Controls.Add(this.btn_add_reset);
            this.main.Controls.Add(this.btn_add_save);
            this.main.Controls.Add(this.tableLayoutPanel1);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(10, 10);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(394, 265);
            this.main.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.64306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.35694F));
            this.tableLayoutPanel1.Controls.Add(this.date_add_to, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_add_from, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbx_add_program, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_add_program, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_add_school, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_add_location, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_add_degree, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbx_add_school, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_add_location, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_add_degree, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_add_to, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.date_add_from, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 201);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // date_add_to
            // 
            this.date_add_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_add_to.Location = new System.Drawing.Point(162, 150);
            this.date_add_to.Margin = new System.Windows.Forms.Padding(0);
            this.date_add_to.Name = "date_add_to";
            this.date_add_to.Size = new System.Drawing.Size(228, 25);
            this.date_add_to.TabIndex = 115;
            this.date_add_to.ValueChanged += new System.EventHandler(this.date_add_to_ValueChanged);
            // 
            // lbl_add_from
            // 
            this.lbl_add_from.AutoSize = true;
            this.lbl_add_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_from.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_from.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_from.ImageIndex = 1;
            this.lbl_add_from.ImageList = this.imageList;
            this.lbl_add_from.Location = new System.Drawing.Point(3, 120);
            this.lbl_add_from.Name = "lbl_add_from";
            this.lbl_add_from.Size = new System.Drawing.Size(156, 30);
            this.lbl_add_from.TabIndex = 112;
            this.lbl_add_from.Text = "From Date:";
            // 
            // tbx_add_program
            // 
            this.tbx_add_program.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_add_program.Location = new System.Drawing.Point(162, 90);
            this.tbx_add_program.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_program.Name = "tbx_add_program";
            this.tbx_add_program.Size = new System.Drawing.Size(228, 25);
            this.tbx_add_program.TabIndex = 111;
            this.tbx_add_program.Tag = "required";
            this.tbx_add_program.TextChanged += new System.EventHandler(this.tbx_add_program_TextChanged);
            // 
            // lbl_add_program
            // 
            this.lbl_add_program.AutoSize = true;
            this.lbl_add_program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_program.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_program.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_program.ImageIndex = 1;
            this.lbl_add_program.ImageList = this.imageList;
            this.lbl_add_program.Location = new System.Drawing.Point(3, 90);
            this.lbl_add_program.Name = "lbl_add_program";
            this.lbl_add_program.Size = new System.Drawing.Size(156, 30);
            this.lbl_add_program.TabIndex = 90;
            this.lbl_add_program.Text = "Course/Program:";
            // 
            // lbl_add_school
            // 
            this.lbl_add_school.AutoSize = true;
            this.lbl_add_school.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_school.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_school.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_school.ImageIndex = 1;
            this.lbl_add_school.ImageList = this.imageList;
            this.lbl_add_school.Location = new System.Drawing.Point(3, 0);
            this.lbl_add_school.Name = "lbl_add_school";
            this.lbl_add_school.Size = new System.Drawing.Size(156, 30);
            this.lbl_add_school.TabIndex = 51;
            this.lbl_add_school.Text = "School/University:";
            // 
            // lbl_add_location
            // 
            this.lbl_add_location.AutoSize = true;
            this.lbl_add_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_location.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_location.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_location.ImageIndex = 1;
            this.lbl_add_location.ImageList = this.imageList;
            this.lbl_add_location.Location = new System.Drawing.Point(3, 30);
            this.lbl_add_location.Name = "lbl_add_location";
            this.lbl_add_location.Size = new System.Drawing.Size(156, 30);
            this.lbl_add_location.TabIndex = 52;
            this.lbl_add_location.Text = "Location:";
            // 
            // lbl_add_degree
            // 
            this.lbl_add_degree.AutoSize = true;
            this.lbl_add_degree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_degree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_degree.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_degree.ImageIndex = 1;
            this.lbl_add_degree.ImageList = this.imageList;
            this.lbl_add_degree.Location = new System.Drawing.Point(3, 60);
            this.lbl_add_degree.Name = "lbl_add_degree";
            this.lbl_add_degree.Size = new System.Drawing.Size(156, 30);
            this.lbl_add_degree.TabIndex = 83;
            this.lbl_add_degree.Text = "Academic Degree:";
            // 
            // tbx_add_school
            // 
            this.tbx_add_school.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_add_school.Location = new System.Drawing.Point(162, 0);
            this.tbx_add_school.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_school.MaxLength = 99;
            this.tbx_add_school.Name = "tbx_add_school";
            this.tbx_add_school.Size = new System.Drawing.Size(228, 25);
            this.tbx_add_school.TabIndex = 108;
            this.tbx_add_school.Tag = "required";
            this.tbx_add_school.TextChanged += new System.EventHandler(this.tbx_add_school_TextChanged);
            // 
            // tbx_add_location
            // 
            this.tbx_add_location.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_add_location.Location = new System.Drawing.Point(162, 30);
            this.tbx_add_location.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_location.MaxLength = 99;
            this.tbx_add_location.Name = "tbx_add_location";
            this.tbx_add_location.Size = new System.Drawing.Size(228, 25);
            this.tbx_add_location.TabIndex = 109;
            this.tbx_add_location.Tag = "required";
            this.tbx_add_location.TextChanged += new System.EventHandler(this.tbx_add_location_TextChanged);
            // 
            // cbx_add_degree
            // 
            this.cbx_add_degree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_add_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_add_degree.FormattingEnabled = true;
            this.cbx_add_degree.Items.AddRange(new object[] {
            "Diploma",
            "Bachelor",
            "Masteral",
            "Doctorate",
            "Others"});
            this.cbx_add_degree.Location = new System.Drawing.Point(162, 60);
            this.cbx_add_degree.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_add_degree.Name = "cbx_add_degree";
            this.cbx_add_degree.Size = new System.Drawing.Size(228, 25);
            this.cbx_add_degree.TabIndex = 110;
            this.cbx_add_degree.SelectedIndexChanged += new System.EventHandler(this.cbx_add_degree_SelectedIndexChanged);
            // 
            // lbl_add_to
            // 
            this.lbl_add_to.AutoSize = true;
            this.lbl_add_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_to.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_to.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_to.ImageIndex = 1;
            this.lbl_add_to.ImageList = this.imageList;
            this.lbl_add_to.Location = new System.Drawing.Point(3, 150);
            this.lbl_add_to.Name = "lbl_add_to";
            this.lbl_add_to.Size = new System.Drawing.Size(156, 51);
            this.lbl_add_to.TabIndex = 113;
            this.lbl_add_to.Text = "To Date:";
            // 
            // date_add_from
            // 
            this.date_add_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_add_from.Location = new System.Drawing.Point(162, 120);
            this.date_add_from.Margin = new System.Windows.Forms.Padding(0);
            this.date_add_from.Name = "date_add_from";
            this.date_add_from.Size = new System.Drawing.Size(228, 25);
            this.date_add_from.TabIndex = 114;
            this.date_add_from.Value = new System.DateTime(2017, 9, 18, 20, 0, 8, 0);
            this.date_add_from.ValueChanged += new System.EventHandler(this.date_add_from_ValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(142, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(414, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_edit_save);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 265);
            this.panel2.TabIndex = 9;
            // 
            // btn_edit_save
            // 
            this.btn_edit_save.BackColor = System.Drawing.Color.Green;
            this.btn_edit_save.Enabled = false;
            this.btn_edit_save.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_edit_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_save.ForeColor = System.Drawing.Color.White;
            this.btn_edit_save.Location = new System.Drawing.Point(163, 218);
            this.btn_edit_save.Name = "btn_edit_save";
            this.btn_edit_save.Size = new System.Drawing.Size(75, 33);
            this.btn_edit_save.TabIndex = 10;
            this.btn_edit_save.Text = "Save";
            this.btn_edit_save.UseVisualStyleBackColor = false;
            this.btn_edit_save.Click += new System.EventHandler(this.btn_edit_save_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.64306F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.35694F));
            this.tableLayoutPanel2.Controls.Add(this.date_edit_to, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_edit_from, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbx_edit_program, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_edit_program, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_edit_school, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_edit_location, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_edit_degree, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbx_edit_school, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbx_edit_location, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbx_edit_degree, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_edit_to, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.date_edit_from, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(390, 201);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // date_edit_to
            // 
            this.date_edit_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_edit_to.Location = new System.Drawing.Point(162, 150);
            this.date_edit_to.Margin = new System.Windows.Forms.Padding(0);
            this.date_edit_to.Name = "date_edit_to";
            this.date_edit_to.Size = new System.Drawing.Size(228, 25);
            this.date_edit_to.TabIndex = 115;
            this.date_edit_to.ValueChanged += new System.EventHandler(this.date_edit_to_ValueChanged);
            // 
            // lbl_edit_from
            // 
            this.lbl_edit_from.AutoSize = true;
            this.lbl_edit_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_from.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_from.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_from.ImageIndex = 1;
            this.lbl_edit_from.ImageList = this.imageList;
            this.lbl_edit_from.Location = new System.Drawing.Point(3, 120);
            this.lbl_edit_from.Name = "lbl_edit_from";
            this.lbl_edit_from.Size = new System.Drawing.Size(156, 30);
            this.lbl_edit_from.TabIndex = 112;
            this.lbl_edit_from.Text = "From Date:";
            // 
            // tbx_edit_program
            // 
            this.tbx_edit_program.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_edit_program.Location = new System.Drawing.Point(162, 90);
            this.tbx_edit_program.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_program.Name = "tbx_edit_program";
            this.tbx_edit_program.Size = new System.Drawing.Size(228, 25);
            this.tbx_edit_program.TabIndex = 111;
            this.tbx_edit_program.Tag = "required";
            this.tbx_edit_program.TextChanged += new System.EventHandler(this.tbx_edit_program_TextChanged);
            // 
            // lbl_edit_program
            // 
            this.lbl_edit_program.AutoSize = true;
            this.lbl_edit_program.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_program.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_program.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_program.ImageIndex = 1;
            this.lbl_edit_program.ImageList = this.imageList;
            this.lbl_edit_program.Location = new System.Drawing.Point(3, 90);
            this.lbl_edit_program.Name = "lbl_edit_program";
            this.lbl_edit_program.Size = new System.Drawing.Size(156, 30);
            this.lbl_edit_program.TabIndex = 90;
            this.lbl_edit_program.Text = "Course/Program:";
            // 
            // lbl_edit_school
            // 
            this.lbl_edit_school.AutoSize = true;
            this.lbl_edit_school.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_school.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_school.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_school.ImageIndex = 1;
            this.lbl_edit_school.ImageList = this.imageList;
            this.lbl_edit_school.Location = new System.Drawing.Point(3, 0);
            this.lbl_edit_school.Name = "lbl_edit_school";
            this.lbl_edit_school.Size = new System.Drawing.Size(156, 30);
            this.lbl_edit_school.TabIndex = 51;
            this.lbl_edit_school.Text = "School/University:";
            // 
            // lbl_edit_location
            // 
            this.lbl_edit_location.AutoSize = true;
            this.lbl_edit_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_location.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_location.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_location.ImageIndex = 1;
            this.lbl_edit_location.ImageList = this.imageList;
            this.lbl_edit_location.Location = new System.Drawing.Point(3, 30);
            this.lbl_edit_location.Name = "lbl_edit_location";
            this.lbl_edit_location.Size = new System.Drawing.Size(156, 30);
            this.lbl_edit_location.TabIndex = 52;
            this.lbl_edit_location.Text = "Location:";
            // 
            // lbl_edit_degree
            // 
            this.lbl_edit_degree.AutoSize = true;
            this.lbl_edit_degree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_degree.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_degree.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_degree.ImageIndex = 1;
            this.lbl_edit_degree.ImageList = this.imageList;
            this.lbl_edit_degree.Location = new System.Drawing.Point(3, 60);
            this.lbl_edit_degree.Name = "lbl_edit_degree";
            this.lbl_edit_degree.Size = new System.Drawing.Size(156, 30);
            this.lbl_edit_degree.TabIndex = 83;
            this.lbl_edit_degree.Text = "Academic Degree:";
            // 
            // tbx_edit_school
            // 
            this.tbx_edit_school.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_edit_school.Location = new System.Drawing.Point(162, 0);
            this.tbx_edit_school.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_school.Name = "tbx_edit_school";
            this.tbx_edit_school.Size = new System.Drawing.Size(228, 25);
            this.tbx_edit_school.TabIndex = 108;
            this.tbx_edit_school.Tag = "required";
            this.tbx_edit_school.TextChanged += new System.EventHandler(this.tbx_edit_school_TextChanged);
            // 
            // tbx_edit_location
            // 
            this.tbx_edit_location.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_edit_location.Location = new System.Drawing.Point(162, 30);
            this.tbx_edit_location.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_location.Name = "tbx_edit_location";
            this.tbx_edit_location.Size = new System.Drawing.Size(228, 25);
            this.tbx_edit_location.TabIndex = 109;
            this.tbx_edit_location.Tag = "required";
            this.tbx_edit_location.TextChanged += new System.EventHandler(this.tbx_edit_location_TextChanged);
            // 
            // cbx_edit_degree
            // 
            this.cbx_edit_degree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_edit_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_edit_degree.FormattingEnabled = true;
            this.cbx_edit_degree.Items.AddRange(new object[] {
            "Diploma",
            "Bachelor",
            "Masteral",
            "Doctorate",
            "Others"});
            this.cbx_edit_degree.Location = new System.Drawing.Point(162, 60);
            this.cbx_edit_degree.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_edit_degree.Name = "cbx_edit_degree";
            this.cbx_edit_degree.Size = new System.Drawing.Size(228, 25);
            this.cbx_edit_degree.TabIndex = 110;
            this.cbx_edit_degree.SelectedIndexChanged += new System.EventHandler(this.cbx_edit_degree_SelectedIndexChanged);
            // 
            // lbl_edit_to
            // 
            this.lbl_edit_to.AutoSize = true;
            this.lbl_edit_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_to.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_to.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_to.ImageIndex = 1;
            this.lbl_edit_to.ImageList = this.imageList;
            this.lbl_edit_to.Location = new System.Drawing.Point(3, 150);
            this.lbl_edit_to.Name = "lbl_edit_to";
            this.lbl_edit_to.Size = new System.Drawing.Size(156, 51);
            this.lbl_edit_to.TabIndex = 113;
            this.lbl_edit_to.Text = "To Date:";
            // 
            // date_edit_from
            // 
            this.date_edit_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_edit_from.Location = new System.Drawing.Point(162, 120);
            this.date_edit_from.Margin = new System.Windows.Forms.Padding(0);
            this.date_edit_from.Name = "date_edit_from";
            this.date_edit_from.Size = new System.Drawing.Size(228, 25);
            this.date_edit_from.TabIndex = 114;
            this.date_edit_from.Value = new System.DateTime(2017, 9, 18, 20, 0, 8, 0);
            this.date_edit_from.ValueChanged += new System.EventHandler(this.date_edit_from_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(434, 12);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 10, 10, 14);
            this.panel3.Size = new System.Drawing.Size(442, 315);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.view_educ);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(422, 291);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_delete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 238);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(422, 53);
            this.panel5.TabIndex = 28;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_delete.Enabled = false;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(181, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 33);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(218, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // view_educ
            // 
            this.view_educ.AllowUserToAddRows = false;
            this.view_educ.AllowUserToDeleteRows = false;
            this.view_educ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.view_educ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.view_educ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_educ.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_educ.Location = new System.Drawing.Point(0, 31);
            this.view_educ.Name = "view_educ";
            this.view_educ.ReadOnly = true;
            this.view_educ.RowHeadersVisible = false;
            this.view_educ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_educ.Size = new System.Drawing.Size(422, 207);
            this.view_educ.TabIndex = 2;
            this.view_educ.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.view_educ_RowsAdded);
            this.view_educ.SelectionChanged += new System.EventHandler(this.view_educ_SelectionChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Teal;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(422, 31);
            this.label13.TabIndex = 27;
            this.label13.Text = "History";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBackgroundEducation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 372);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackgroundEducation";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Education Background";
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_educ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Button btn_add_save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker date_add_to;
        private System.Windows.Forms.Label lbl_add_from;
        private System.Windows.Forms.TextBox tbx_add_program;
        private System.Windows.Forms.Label lbl_add_program;
        private System.Windows.Forms.Label lbl_add_school;
        private System.Windows.Forms.Label lbl_add_location;
        private System.Windows.Forms.Label lbl_add_degree;
        private System.Windows.Forms.TextBox tbx_add_school;
        private System.Windows.Forms.TextBox tbx_add_location;
        private System.Windows.Forms.ComboBox cbx_add_degree;
        private System.Windows.Forms.Label lbl_add_to;
        private System.Windows.Forms.DateTimePicker date_add_from;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_edit_save;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker date_edit_to;
        private System.Windows.Forms.Label lbl_edit_from;
        private System.Windows.Forms.TextBox tbx_edit_program;
        private System.Windows.Forms.Label lbl_edit_program;
        private System.Windows.Forms.Label lbl_edit_school;
        private System.Windows.Forms.Label lbl_edit_location;
        private System.Windows.Forms.Label lbl_edit_degree;
        private System.Windows.Forms.TextBox tbx_edit_school;
        private System.Windows.Forms.TextBox tbx_edit_location;
        private System.Windows.Forms.ComboBox cbx_edit_degree;
        private System.Windows.Forms.Label lbl_edit_to;
        private System.Windows.Forms.DateTimePicker date_edit_from;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView view_educ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add_reset;
    }
}