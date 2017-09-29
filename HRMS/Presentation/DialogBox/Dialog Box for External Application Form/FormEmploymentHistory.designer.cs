namespace Presentation.DialogBox.ExternalApplicationForm
{
    partial class FormEmploymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmploymentHistory));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.btn_add_save = new System.Windows.Forms.Button();
            this.btn_add_reset = new System.Windows.Forms.Button();
            this.btn_edit_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.date_add_to = new System.Windows.Forms.DateTimePicker();
            this.tbx_add_reason = new System.Windows.Forms.TextBox();
            this.tbx_add_nature = new System.Windows.Forms.TextBox();
            this.tbx_add_supervisor = new System.Windows.Forms.TextBox();
            this.lbl_add_supervisor = new System.Windows.Forms.Label();
            this.lbl_add_position = new System.Windows.Forms.Label();
            this.lbl_add_company = new System.Windows.Forms.Label();
            this.lbl_add_location = new System.Windows.Forms.Label();
            this.tbx_add_postionTitle = new System.Windows.Forms.TextBox();
            this.tbx_add_company = new System.Windows.Forms.TextBox();
            this.lbl_add_from = new System.Windows.Forms.Label();
            this.lbl_add_to = new System.Windows.Forms.Label();
            this.lbl_add_nature = new System.Windows.Forms.Label();
            this.lbl_add_compensation = new System.Windows.Forms.Label();
            this.tbx_add_location = new System.Windows.Forms.TextBox();
            this.lbl_add_reasonLeaving = new System.Windows.Forms.Label();
            this.date_add_from = new System.Windows.Forms.DateTimePicker();
            this.tbx_add_compensation = new Presentation.Miscellaneous.CustomTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.date_edit_to = new System.Windows.Forms.DateTimePicker();
            this.tbx_edit_reason = new System.Windows.Forms.TextBox();
            this.tbx_edit_nature = new System.Windows.Forms.TextBox();
            this.tbx_edit_supervisor = new System.Windows.Forms.TextBox();
            this.lbl_edit_supervisor = new System.Windows.Forms.Label();
            this.lbl_edit_position = new System.Windows.Forms.Label();
            this.lbl_edit_company = new System.Windows.Forms.Label();
            this.lbl_edit_location = new System.Windows.Forms.Label();
            this.tbx_edit_position = new System.Windows.Forms.TextBox();
            this.tbx_edit_company = new System.Windows.Forms.TextBox();
            this.lbl_date_from = new System.Windows.Forms.Label();
            this.lbl_date_to = new System.Windows.Forms.Label();
            this.lbl_edit_nature = new System.Windows.Forms.Label();
            this.lbl_edit_compensation = new System.Windows.Forms.Label();
            this.tbx_edit_location = new System.Windows.Forms.TextBox();
            this.lbl_edit_reason = new System.Windows.Forms.Label();
            this.date_edit_from = new System.Windows.Forms.DateTimePicker();
            this.tbx_edit_compensation = new Presentation.Miscellaneous.CustomTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.view_employee = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.main.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_employee)).BeginInit();
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
            this.btn_add_save.Location = new System.Drawing.Point(240, 389);
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
            this.btn_add_reset.Location = new System.Drawing.Point(159, 389);
            this.btn_add_reset.Name = "btn_add_reset";
            this.helpProvider.SetShowHelp(this.btn_add_reset, true);
            this.btn_add_reset.Size = new System.Drawing.Size(75, 33);
            this.btn_add_reset.TabIndex = 11;
            this.btn_add_reset.Text = "Reset";
            this.btn_add_reset.UseVisualStyleBackColor = false;
            this.btn_add_reset.Click += new System.EventHandler(this.btn_add_reset_Click);
            // 
            // btn_edit_save
            // 
            this.btn_edit_save.BackColor = System.Drawing.Color.Green;
            this.btn_edit_save.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_edit_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_save.ForeColor = System.Drawing.Color.White;
            this.helpProvider.SetHelpString(this.btn_edit_save, "Put input values on fields first before saving");
            this.btn_edit_save.Location = new System.Drawing.Point(211, 389);
            this.btn_edit_save.Name = "btn_edit_save";
            this.helpProvider.SetShowHelp(this.btn_edit_save, true);
            this.btn_edit_save.Size = new System.Drawing.Size(75, 33);
            this.btn_edit_save.TabIndex = 11;
            this.btn_edit_save.Text = "Save";
            this.btn_edit_save.UseVisualStyleBackColor = false;
            this.btn_edit_save.Click += new System.EventHandler(this.btn_edit_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 33);
            this.panel1.TabIndex = 6;
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(871, 8);
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
            this.tabControl1.Size = new System.Drawing.Size(481, 487);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.main);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(473, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.main.Controls.Add(this.tableLayoutPanel6);
            this.main.Controls.Add(this.btn_add_reset);
            this.main.Controls.Add(this.btn_add_save);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(10, 10);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(453, 437);
            this.main.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.89235F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.10765F));
            this.tableLayoutPanel6.Controls.Add(this.date_add_to, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.tbx_add_reason, 1, 8);
            this.tableLayoutPanel6.Controls.Add(this.tbx_add_nature, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.tbx_add_supervisor, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_supervisor, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_position, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_company, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_location, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tbx_add_postionTitle, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbx_add_company, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_from, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_to, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_nature, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_compensation, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.tbx_add_location, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbl_add_reasonLeaving, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.date_add_from, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.tbx_add_compensation, 1, 7);
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(19, 19);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 9;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(419, 345);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // date_add_to
            // 
            this.date_add_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_add_to.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_add_to.Location = new System.Drawing.Point(192, 150);
            this.date_add_to.Margin = new System.Windows.Forms.Padding(0);
            this.date_add_to.Name = "date_add_to";
            this.date_add_to.Size = new System.Drawing.Size(227, 25);
            this.date_add_to.TabIndex = 123;
            this.date_add_to.ValueChanged += new System.EventHandler(this.date_add_to_ValueChanged);
            // 
            // tbx_add_reason
            // 
            this.tbx_add_reason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_add_reason.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_reason.Location = new System.Drawing.Point(192, 240);
            this.tbx_add_reason.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_reason.MaxLength = 199;
            this.tbx_add_reason.Multiline = true;
            this.tbx_add_reason.Name = "tbx_add_reason";
            this.tbx_add_reason.Size = new System.Drawing.Size(227, 105);
            this.tbx_add_reason.TabIndex = 121;
            this.tbx_add_reason.TextChanged += new System.EventHandler(this.tbx_add_reason_TextChanged);
            // 
            // tbx_add_nature
            // 
            this.tbx_add_nature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_add_nature.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_nature.Location = new System.Drawing.Point(192, 180);
            this.tbx_add_nature.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_nature.MaxLength = 99;
            this.tbx_add_nature.Name = "tbx_add_nature";
            this.tbx_add_nature.Size = new System.Drawing.Size(227, 25);
            this.tbx_add_nature.TabIndex = 118;
            this.tbx_add_nature.TextChanged += new System.EventHandler(this.tbx_add_nature_TextChanged);
            // 
            // tbx_add_supervisor
            // 
            this.tbx_add_supervisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_add_supervisor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_supervisor.Location = new System.Drawing.Point(192, 90);
            this.tbx_add_supervisor.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_supervisor.MaxLength = 99;
            this.tbx_add_supervisor.Name = "tbx_add_supervisor";
            this.tbx_add_supervisor.Size = new System.Drawing.Size(227, 25);
            this.tbx_add_supervisor.TabIndex = 115;
            // 
            // lbl_add_supervisor
            // 
            this.lbl_add_supervisor.AutoSize = true;
            this.lbl_add_supervisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_supervisor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_supervisor.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_supervisor.ImageList = this.imageList;
            this.lbl_add_supervisor.Location = new System.Drawing.Point(3, 90);
            this.lbl_add_supervisor.Name = "lbl_add_supervisor";
            this.lbl_add_supervisor.Size = new System.Drawing.Size(186, 30);
            this.lbl_add_supervisor.TabIndex = 90;
            this.lbl_add_supervisor.Text = "Supervisor Name:";
            // 
            // lbl_add_position
            // 
            this.lbl_add_position.AutoSize = true;
            this.lbl_add_position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_position.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_position.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_position.ImageIndex = 1;
            this.lbl_add_position.ImageList = this.imageList;
            this.lbl_add_position.Location = new System.Drawing.Point(3, 0);
            this.lbl_add_position.Name = "lbl_add_position";
            this.lbl_add_position.Size = new System.Drawing.Size(186, 30);
            this.lbl_add_position.TabIndex = 51;
            this.lbl_add_position.Text = "Position Title:";
            // 
            // lbl_add_company
            // 
            this.lbl_add_company.AutoSize = true;
            this.lbl_add_company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_company.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_company.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_company.ImageIndex = 1;
            this.lbl_add_company.ImageList = this.imageList;
            this.lbl_add_company.Location = new System.Drawing.Point(3, 30);
            this.lbl_add_company.Name = "lbl_add_company";
            this.lbl_add_company.Size = new System.Drawing.Size(186, 30);
            this.lbl_add_company.TabIndex = 52;
            this.lbl_add_company.Text = "Company:";
            // 
            // lbl_add_location
            // 
            this.lbl_add_location.AutoSize = true;
            this.lbl_add_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_location.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_location.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_location.ImageIndex = 1;
            this.lbl_add_location.ImageList = this.imageList;
            this.lbl_add_location.Location = new System.Drawing.Point(3, 60);
            this.lbl_add_location.Name = "lbl_add_location";
            this.lbl_add_location.Size = new System.Drawing.Size(186, 30);
            this.lbl_add_location.TabIndex = 83;
            this.lbl_add_location.Text = "Location:";
            // 
            // tbx_add_postionTitle
            // 
            this.tbx_add_postionTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_add_postionTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_postionTitle.Location = new System.Drawing.Point(192, 0);
            this.tbx_add_postionTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_postionTitle.MaxLength = 99;
            this.tbx_add_postionTitle.Name = "tbx_add_postionTitle";
            this.tbx_add_postionTitle.Size = new System.Drawing.Size(227, 25);
            this.tbx_add_postionTitle.TabIndex = 108;
            this.tbx_add_postionTitle.Tag = "required";
            this.tbx_add_postionTitle.TextChanged += new System.EventHandler(this.tbx_add_postionTitle_TextChanged);
            // 
            // tbx_add_company
            // 
            this.tbx_add_company.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_add_company.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_company.Location = new System.Drawing.Point(192, 30);
            this.tbx_add_company.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_company.MaxLength = 99;
            this.tbx_add_company.Name = "tbx_add_company";
            this.tbx_add_company.Size = new System.Drawing.Size(227, 25);
            this.tbx_add_company.TabIndex = 109;
            this.tbx_add_company.Tag = "required";
            this.tbx_add_company.TextChanged += new System.EventHandler(this.tbx_add_company_TextChanged);
            // 
            // lbl_add_from
            // 
            this.lbl_add_from.AutoSize = true;
            this.lbl_add_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_from.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_from.ImageIndex = 1;
            this.lbl_add_from.ImageList = this.imageList;
            this.lbl_add_from.Location = new System.Drawing.Point(3, 120);
            this.lbl_add_from.Name = "lbl_add_from";
            this.lbl_add_from.Size = new System.Drawing.Size(186, 30);
            this.lbl_add_from.TabIndex = 110;
            this.lbl_add_from.Text = "From Date:";
            // 
            // lbl_add_to
            // 
            this.lbl_add_to.AutoSize = true;
            this.lbl_add_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_to.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_to.ImageIndex = 1;
            this.lbl_add_to.ImageList = this.imageList;
            this.lbl_add_to.Location = new System.Drawing.Point(3, 150);
            this.lbl_add_to.Name = "lbl_add_to";
            this.lbl_add_to.Size = new System.Drawing.Size(186, 30);
            this.lbl_add_to.TabIndex = 111;
            this.lbl_add_to.Text = "To Date:";
            // 
            // lbl_add_nature
            // 
            this.lbl_add_nature.AutoSize = true;
            this.lbl_add_nature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_nature.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_nature.ImageIndex = 1;
            this.lbl_add_nature.ImageList = this.imageList;
            this.lbl_add_nature.Location = new System.Drawing.Point(3, 180);
            this.lbl_add_nature.Name = "lbl_add_nature";
            this.lbl_add_nature.Size = new System.Drawing.Size(186, 30);
            this.lbl_add_nature.TabIndex = 112;
            this.lbl_add_nature.Text = "Nature:";
            // 
            // lbl_add_compensation
            // 
            this.lbl_add_compensation.AutoSize = true;
            this.lbl_add_compensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_compensation.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_compensation.ImageList = this.imageList;
            this.lbl_add_compensation.Location = new System.Drawing.Point(3, 210);
            this.lbl_add_compensation.Name = "lbl_add_compensation";
            this.lbl_add_compensation.Size = new System.Drawing.Size(186, 30);
            this.lbl_add_compensation.TabIndex = 113;
            this.lbl_add_compensation.Text = "Monthly Compensation:";
            // 
            // tbx_add_location
            // 
            this.tbx_add_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_add_location.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_location.Location = new System.Drawing.Point(192, 60);
            this.tbx_add_location.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_location.MaxLength = 149;
            this.tbx_add_location.Name = "tbx_add_location";
            this.tbx_add_location.Size = new System.Drawing.Size(227, 25);
            this.tbx_add_location.TabIndex = 114;
            this.tbx_add_location.TextChanged += new System.EventHandler(this.tbx_add_location_TextChanged);
            // 
            // lbl_add_reasonLeaving
            // 
            this.lbl_add_reasonLeaving.AutoSize = true;
            this.lbl_add_reasonLeaving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_add_reasonLeaving.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_add_reasonLeaving.ImageIndex = 1;
            this.lbl_add_reasonLeaving.ImageList = this.imageList;
            this.lbl_add_reasonLeaving.Location = new System.Drawing.Point(3, 240);
            this.lbl_add_reasonLeaving.Name = "lbl_add_reasonLeaving";
            this.lbl_add_reasonLeaving.Size = new System.Drawing.Size(186, 105);
            this.lbl_add_reasonLeaving.TabIndex = 120;
            this.lbl_add_reasonLeaving.Text = "Reason For Leaving:";
            // 
            // date_add_from
            // 
            this.date_add_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_add_from.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_add_from.Location = new System.Drawing.Point(192, 120);
            this.date_add_from.Margin = new System.Windows.Forms.Padding(0);
            this.date_add_from.Name = "date_add_from";
            this.date_add_from.Size = new System.Drawing.Size(227, 25);
            this.date_add_from.TabIndex = 122;
            this.date_add_from.ValueChanged += new System.EventHandler(this.date_add_from_ValueChanged);
            // 
            // tbx_add_compensation
            // 
            this.tbx_add_compensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_add_compensation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbx_add_compensation.Location = new System.Drawing.Point(192, 210);
            this.tbx_add_compensation.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_compensation.MaxLength = 10;
            this.tbx_add_compensation.Name = "tbx_add_compensation";
            this.tbx_add_compensation.Size = new System.Drawing.Size(227, 25);
            this.tbx_add_compensation.TabIndex = 124;
            this.tbx_add_compensation.TextInputType = Presentation.Miscellaneous.CustomTextbox.InputType.Decimals;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(473, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.btn_edit_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 437);
            this.panel2.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.11F));
            this.tableLayoutPanel1.Controls.Add(this.date_edit_to, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbx_edit_reason, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbx_edit_nature, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbx_edit_supervisor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_edit_supervisor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_edit_position, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_edit_company, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_edit_location, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbx_edit_position, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_edit_company, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_date_from, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_date_to, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_edit_nature, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_edit_compensation, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbx_edit_location, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_edit_reason, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.date_edit_from, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbx_edit_compensation, 1, 7);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 345);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // date_edit_to
            // 
            this.date_edit_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_edit_to.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_edit_to.Location = new System.Drawing.Point(192, 150);
            this.date_edit_to.Margin = new System.Windows.Forms.Padding(0);
            this.date_edit_to.Name = "date_edit_to";
            this.date_edit_to.Size = new System.Drawing.Size(227, 25);
            this.date_edit_to.TabIndex = 123;
            this.date_edit_to.ValueChanged += new System.EventHandler(this.date_edit_to_ValueChanged);
            // 
            // tbx_edit_reason
            // 
            this.tbx_edit_reason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_edit_reason.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_reason.Location = new System.Drawing.Point(192, 240);
            this.tbx_edit_reason.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_reason.MaxLength = 199;
            this.tbx_edit_reason.Multiline = true;
            this.tbx_edit_reason.Name = "tbx_edit_reason";
            this.tbx_edit_reason.Size = new System.Drawing.Size(227, 105);
            this.tbx_edit_reason.TabIndex = 121;
            this.tbx_edit_reason.TextChanged += new System.EventHandler(this.tbx_edit_reason_TextChanged);
            // 
            // tbx_edit_nature
            // 
            this.tbx_edit_nature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_edit_nature.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_nature.Location = new System.Drawing.Point(192, 180);
            this.tbx_edit_nature.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_nature.MaxLength = 99;
            this.tbx_edit_nature.Name = "tbx_edit_nature";
            this.tbx_edit_nature.Size = new System.Drawing.Size(227, 25);
            this.tbx_edit_nature.TabIndex = 118;
            this.tbx_edit_nature.TextChanged += new System.EventHandler(this.tbx_edit_nature_TextChanged);
            // 
            // tbx_edit_supervisor
            // 
            this.tbx_edit_supervisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_edit_supervisor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_supervisor.Location = new System.Drawing.Point(192, 90);
            this.tbx_edit_supervisor.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_supervisor.MaxLength = 99;
            this.tbx_edit_supervisor.Name = "tbx_edit_supervisor";
            this.tbx_edit_supervisor.Size = new System.Drawing.Size(227, 25);
            this.tbx_edit_supervisor.TabIndex = 115;
            // 
            // lbl_edit_supervisor
            // 
            this.lbl_edit_supervisor.AutoSize = true;
            this.lbl_edit_supervisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_supervisor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_supervisor.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_supervisor.ImageList = this.imageList;
            this.lbl_edit_supervisor.Location = new System.Drawing.Point(3, 90);
            this.lbl_edit_supervisor.Name = "lbl_edit_supervisor";
            this.lbl_edit_supervisor.Size = new System.Drawing.Size(186, 30);
            this.lbl_edit_supervisor.TabIndex = 90;
            this.lbl_edit_supervisor.Text = "Supervisor Name:";
            // 
            // lbl_edit_position
            // 
            this.lbl_edit_position.AutoSize = true;
            this.lbl_edit_position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_position.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_position.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_position.ImageIndex = 1;
            this.lbl_edit_position.ImageList = this.imageList;
            this.lbl_edit_position.Location = new System.Drawing.Point(3, 0);
            this.lbl_edit_position.Name = "lbl_edit_position";
            this.lbl_edit_position.Size = new System.Drawing.Size(186, 30);
            this.lbl_edit_position.TabIndex = 51;
            this.lbl_edit_position.Text = "Position Title:";
            // 
            // lbl_edit_company
            // 
            this.lbl_edit_company.AutoSize = true;
            this.lbl_edit_company.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_company.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_company.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_company.ImageIndex = 1;
            this.lbl_edit_company.ImageList = this.imageList;
            this.lbl_edit_company.Location = new System.Drawing.Point(3, 30);
            this.lbl_edit_company.Name = "lbl_edit_company";
            this.lbl_edit_company.Size = new System.Drawing.Size(186, 30);
            this.lbl_edit_company.TabIndex = 52;
            this.lbl_edit_company.Text = "Company:";
            // 
            // lbl_edit_location
            // 
            this.lbl_edit_location.AutoSize = true;
            this.lbl_edit_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_location.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_location.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_location.ImageIndex = 1;
            this.lbl_edit_location.ImageList = this.imageList;
            this.lbl_edit_location.Location = new System.Drawing.Point(3, 60);
            this.lbl_edit_location.Name = "lbl_edit_location";
            this.lbl_edit_location.Size = new System.Drawing.Size(186, 30);
            this.lbl_edit_location.TabIndex = 83;
            this.lbl_edit_location.Text = "Location:";
            // 
            // tbx_edit_position
            // 
            this.tbx_edit_position.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_edit_position.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_position.Location = new System.Drawing.Point(192, 0);
            this.tbx_edit_position.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_position.MaxLength = 99;
            this.tbx_edit_position.Name = "tbx_edit_position";
            this.tbx_edit_position.Size = new System.Drawing.Size(227, 25);
            this.tbx_edit_position.TabIndex = 108;
            this.tbx_edit_position.Tag = "required";
            this.tbx_edit_position.TextChanged += new System.EventHandler(this.tbx_edit_position_TextChanged);
            // 
            // tbx_edit_company
            // 
            this.tbx_edit_company.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_edit_company.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_company.Location = new System.Drawing.Point(192, 30);
            this.tbx_edit_company.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_company.MaxLength = 99;
            this.tbx_edit_company.Name = "tbx_edit_company";
            this.tbx_edit_company.Size = new System.Drawing.Size(227, 25);
            this.tbx_edit_company.TabIndex = 109;
            this.tbx_edit_company.Tag = "required";
            this.tbx_edit_company.TextChanged += new System.EventHandler(this.tbx_edit_company_TextChanged);
            // 
            // lbl_date_from
            // 
            this.lbl_date_from.AutoSize = true;
            this.lbl_date_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_date_from.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_date_from.ImageIndex = 1;
            this.lbl_date_from.ImageList = this.imageList;
            this.lbl_date_from.Location = new System.Drawing.Point(3, 120);
            this.lbl_date_from.Name = "lbl_date_from";
            this.lbl_date_from.Size = new System.Drawing.Size(186, 30);
            this.lbl_date_from.TabIndex = 110;
            this.lbl_date_from.Text = "From Date:";
            // 
            // lbl_date_to
            // 
            this.lbl_date_to.AutoSize = true;
            this.lbl_date_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_date_to.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_date_to.ImageIndex = 1;
            this.lbl_date_to.ImageList = this.imageList;
            this.lbl_date_to.Location = new System.Drawing.Point(3, 150);
            this.lbl_date_to.Name = "lbl_date_to";
            this.lbl_date_to.Size = new System.Drawing.Size(186, 30);
            this.lbl_date_to.TabIndex = 111;
            this.lbl_date_to.Text = "To Date:";
            // 
            // lbl_edit_nature
            // 
            this.lbl_edit_nature.AutoSize = true;
            this.lbl_edit_nature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_nature.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_nature.ImageIndex = 1;
            this.lbl_edit_nature.ImageList = this.imageList;
            this.lbl_edit_nature.Location = new System.Drawing.Point(3, 180);
            this.lbl_edit_nature.Name = "lbl_edit_nature";
            this.lbl_edit_nature.Size = new System.Drawing.Size(186, 30);
            this.lbl_edit_nature.TabIndex = 112;
            this.lbl_edit_nature.Text = "Nature:";
            // 
            // lbl_edit_compensation
            // 
            this.lbl_edit_compensation.AutoSize = true;
            this.lbl_edit_compensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_compensation.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_compensation.Location = new System.Drawing.Point(3, 210);
            this.lbl_edit_compensation.Name = "lbl_edit_compensation";
            this.lbl_edit_compensation.Size = new System.Drawing.Size(186, 30);
            this.lbl_edit_compensation.TabIndex = 113;
            this.lbl_edit_compensation.Text = "Monthly Compensation:";
            // 
            // tbx_edit_location
            // 
            this.tbx_edit_location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_edit_location.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_location.Location = new System.Drawing.Point(192, 60);
            this.tbx_edit_location.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_location.MaxLength = 149;
            this.tbx_edit_location.Name = "tbx_edit_location";
            this.tbx_edit_location.Size = new System.Drawing.Size(227, 25);
            this.tbx_edit_location.TabIndex = 114;
            this.tbx_edit_location.TextChanged += new System.EventHandler(this.tbx_edit_location_TextChanged);
            // 
            // lbl_edit_reason
            // 
            this.lbl_edit_reason.AutoSize = true;
            this.lbl_edit_reason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_edit_reason.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_edit_reason.ImageIndex = 1;
            this.lbl_edit_reason.ImageList = this.imageList;
            this.lbl_edit_reason.Location = new System.Drawing.Point(3, 240);
            this.lbl_edit_reason.Name = "lbl_edit_reason";
            this.lbl_edit_reason.Size = new System.Drawing.Size(186, 105);
            this.lbl_edit_reason.TabIndex = 120;
            this.lbl_edit_reason.Text = "Reason For Leaving:";
            // 
            // date_edit_from
            // 
            this.date_edit_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_edit_from.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_edit_from.Location = new System.Drawing.Point(192, 120);
            this.date_edit_from.Margin = new System.Windows.Forms.Padding(0);
            this.date_edit_from.Name = "date_edit_from";
            this.date_edit_from.Size = new System.Drawing.Size(227, 25);
            this.date_edit_from.TabIndex = 122;
            this.date_edit_from.ValueChanged += new System.EventHandler(this.date_edit_from_ValueChanged);
            // 
            // tbx_edit_compensation
            // 
            this.tbx_edit_compensation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_edit_compensation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbx_edit_compensation.Location = new System.Drawing.Point(192, 210);
            this.tbx_edit_compensation.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_compensation.MaxLength = 10;
            this.tbx_edit_compensation.Name = "tbx_edit_compensation";
            this.tbx_edit_compensation.Size = new System.Drawing.Size(227, 25);
            this.tbx_edit_compensation.TabIndex = 124;
            this.tbx_edit_compensation.TextInputType = Presentation.Miscellaneous.CustomTextbox.InputType.Decimals;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(493, 12);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 10, 10, 14);
            this.panel3.Size = new System.Drawing.Size(465, 487);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.view_employee);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 463);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_delete);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(445, 54);
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
            // view_employee
            // 
            this.view_employee.AllowUserToAddRows = false;
            this.view_employee.AllowUserToDeleteRows = false;
            this.view_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.view_employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.view_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_employee.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_employee.Location = new System.Drawing.Point(0, 31);
            this.view_employee.Name = "view_employee";
            this.view_employee.ReadOnly = true;
            this.view_employee.RowHeadersVisible = false;
            this.view_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_employee.Size = new System.Drawing.Size(445, 378);
            this.view_employee.TabIndex = 2;
            this.view_employee.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.view_employee_RowsAdded);
            this.view_employee.SelectionChanged += new System.EventHandler(this.view_employee_SelectionChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Teal;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(445, 31);
            this.label13.TabIndex = 27;
            this.label13.Text = "History";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEmploymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmploymentHistory";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Employment History";
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_employee)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView view_employee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add_reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DateTimePicker date_add_to;
        private System.Windows.Forms.TextBox tbx_add_nature;
        private System.Windows.Forms.TextBox tbx_add_supervisor;
        private System.Windows.Forms.Label lbl_add_supervisor;
        private System.Windows.Forms.Label lbl_add_position;
        private System.Windows.Forms.Label lbl_add_company;
        private System.Windows.Forms.Label lbl_add_location;
        private System.Windows.Forms.TextBox tbx_add_postionTitle;
        private System.Windows.Forms.TextBox tbx_add_company;
        private System.Windows.Forms.Label lbl_add_from;
        private System.Windows.Forms.Label lbl_add_to;
        private System.Windows.Forms.TextBox tbx_add_location;
        private System.Windows.Forms.DateTimePicker date_add_from;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker date_edit_to;
        private System.Windows.Forms.TextBox tbx_edit_reason;
        private System.Windows.Forms.TextBox tbx_edit_nature;
        private System.Windows.Forms.TextBox tbx_edit_supervisor;
        private System.Windows.Forms.Label lbl_edit_supervisor;
        private System.Windows.Forms.Label lbl_edit_position;
        private System.Windows.Forms.Label lbl_edit_company;
        private System.Windows.Forms.Label lbl_edit_location;
        private System.Windows.Forms.TextBox tbx_edit_position;
        private System.Windows.Forms.TextBox tbx_edit_company;
        private System.Windows.Forms.Label lbl_date_from;
        private System.Windows.Forms.Label lbl_date_to;
        private System.Windows.Forms.Label lbl_edit_nature;
        private System.Windows.Forms.Label lbl_edit_compensation;
        private System.Windows.Forms.TextBox tbx_edit_location;
        private System.Windows.Forms.Label lbl_edit_reason;
        private System.Windows.Forms.DateTimePicker date_edit_from;
        private System.Windows.Forms.Button btn_edit_save;
        private System.Windows.Forms.TextBox tbx_add_reason;
        private System.Windows.Forms.Label lbl_add_nature;
        private System.Windows.Forms.Label lbl_add_compensation;
        private System.Windows.Forms.Label lbl_add_reasonLeaving;
        private Miscellaneous.CustomTextbox tbx_edit_compensation;
        private Miscellaneous.CustomTextbox tbx_add_compensation;
    }
}