namespace Presentation.DialogBox.ApplicantEvaluation
{
    partial class ControlApplicantEvaluationDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlApplicantEvaluationDetails));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_managerID = new System.Windows.Forms.ComboBox();
            this.cbx_arvatoLevel = new System.Windows.Forms.ComboBox();
            this.cbx_languageRequirement = new System.Windows.Forms.ComboBox();
            this.cbx_titanTitle = new System.Windows.Forms.ComboBox();
            this.lbl_jobTitle = new System.Windows.Forms.Label();
            this.lbl_bucket = new System.Windows.Forms.Label();
            this.lbl_titanTitle = new System.Windows.Forms.Label();
            this.lbl_langRequirement = new System.Windows.Forms.Label();
            this.lbl_arvatoLevel = new System.Windows.Forms.Label();
            this.lbl_managerID = new System.Windows.Forms.Label();
            this.cbx_bucket = new System.Windows.Forms.ComboBox();
            this.cbx_position = new System.Windows.Forms.ComboBox();
            this.gbxAppInfo = new System.Windows.Forms.GroupBox();
            this.applicantInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_applicationDate = new System.Windows.Forms.Label();
            this.lbl_positionApplied = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbxAppInfo.SuspendLayout();
            this.applicantInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_next);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(12, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 91);
            this.panel2.TabIndex = 60;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(459, 32);
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
            this.btn_clear.Location = new System.Drawing.Point(378, 32);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 35);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "green_dot.png");
            this.imageList.Images.SetKeyName(1, "red_dot.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 249);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Details";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0179F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.9821F));
            this.tableLayoutPanel3.Controls.Add(this.cbx_managerID, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.cbx_arvatoLevel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbx_languageRequirement, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbx_titanTitle, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_jobTitle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_bucket, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_titanTitle, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_langRequirement, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_arvatoLevel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_managerID, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.cbx_bucket, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbx_position, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(25, 43);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 140);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // cbx_managerID
            // 
            this.cbx_managerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_managerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_managerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_managerID.FormattingEnabled = true;
            this.cbx_managerID.Location = new System.Drawing.Point(184, 117);
            this.cbx_managerID.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_managerID.MaxLength = 10;
            this.cbx_managerID.Name = "cbx_managerID";
            this.cbx_managerID.Size = new System.Drawing.Size(320, 21);
            this.cbx_managerID.TabIndex = 82;
            this.cbx_managerID.SelectedIndexChanged += new System.EventHandler(this.cbx_managerID_SelectedIndexChanged);
            // 
            // cbx_arvatoLevel
            // 
            this.cbx_arvatoLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_arvatoLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_arvatoLevel.FormattingEnabled = true;
            this.cbx_arvatoLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbx_arvatoLevel.Location = new System.Drawing.Point(184, 94);
            this.cbx_arvatoLevel.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_arvatoLevel.Name = "cbx_arvatoLevel";
            this.cbx_arvatoLevel.Size = new System.Drawing.Size(320, 21);
            this.cbx_arvatoLevel.TabIndex = 81;
            this.cbx_arvatoLevel.SelectedIndexChanged += new System.EventHandler(this.cbx_arvatoLevel_SelectedIndexChanged);
            // 
            // cbx_languageRequirement
            // 
            this.cbx_languageRequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_languageRequirement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_languageRequirement.FormattingEnabled = true;
            this.cbx_languageRequirement.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbx_languageRequirement.Location = new System.Drawing.Point(184, 71);
            this.cbx_languageRequirement.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_languageRequirement.Name = "cbx_languageRequirement";
            this.cbx_languageRequirement.Size = new System.Drawing.Size(320, 21);
            this.cbx_languageRequirement.TabIndex = 80;
            this.cbx_languageRequirement.SelectedIndexChanged += new System.EventHandler(this.cbx_languageRequirement_SelectedIndexChanged);
            // 
            // cbx_titanTitle
            // 
            this.cbx_titanTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_titanTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_titanTitle.FormattingEnabled = true;
            this.cbx_titanTitle.Location = new System.Drawing.Point(184, 48);
            this.cbx_titanTitle.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_titanTitle.Name = "cbx_titanTitle";
            this.cbx_titanTitle.Size = new System.Drawing.Size(320, 21);
            this.cbx_titanTitle.TabIndex = 79;
            this.cbx_titanTitle.SelectedIndexChanged += new System.EventHandler(this.cbx_titanTitle_SelectedIndexChanged);
            // 
            // lbl_jobTitle
            // 
            this.lbl_jobTitle.AutoSize = true;
            this.lbl_jobTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_jobTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jobTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_jobTitle.ImageIndex = 1;
            this.lbl_jobTitle.ImageList = this.imageList;
            this.lbl_jobTitle.Location = new System.Drawing.Point(5, 2);
            this.lbl_jobTitle.Name = "lbl_jobTitle";
            this.lbl_jobTitle.Size = new System.Drawing.Size(174, 21);
            this.lbl_jobTitle.TabIndex = 51;
            this.lbl_jobTitle.Text = "Job Title:";
            this.lbl_jobTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_bucket
            // 
            this.lbl_bucket.AutoSize = true;
            this.lbl_bucket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bucket.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bucket.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_bucket.ImageIndex = 1;
            this.lbl_bucket.ImageList = this.imageList;
            this.lbl_bucket.Location = new System.Drawing.Point(5, 25);
            this.lbl_bucket.Name = "lbl_bucket";
            this.lbl_bucket.Size = new System.Drawing.Size(174, 21);
            this.lbl_bucket.TabIndex = 52;
            this.lbl_bucket.Text = "Bucket:";
            this.lbl_bucket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_titanTitle
            // 
            this.lbl_titanTitle.AutoSize = true;
            this.lbl_titanTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_titanTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titanTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_titanTitle.ImageIndex = 1;
            this.lbl_titanTitle.ImageList = this.imageList;
            this.lbl_titanTitle.Location = new System.Drawing.Point(5, 48);
            this.lbl_titanTitle.Name = "lbl_titanTitle";
            this.lbl_titanTitle.Size = new System.Drawing.Size(174, 21);
            this.lbl_titanTitle.TabIndex = 53;
            this.lbl_titanTitle.Text = "Titan Title:";
            this.lbl_titanTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_langRequirement
            // 
            this.lbl_langRequirement.AutoSize = true;
            this.lbl_langRequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_langRequirement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_langRequirement.ImageIndex = 1;
            this.lbl_langRequirement.ImageList = this.imageList;
            this.lbl_langRequirement.Location = new System.Drawing.Point(5, 71);
            this.lbl_langRequirement.Name = "lbl_langRequirement";
            this.lbl_langRequirement.Size = new System.Drawing.Size(174, 21);
            this.lbl_langRequirement.TabIndex = 63;
            this.lbl_langRequirement.Text = "Language Requirement:";
            this.lbl_langRequirement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_arvatoLevel
            // 
            this.lbl_arvatoLevel.AutoSize = true;
            this.lbl_arvatoLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_arvatoLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_arvatoLevel.ImageIndex = 1;
            this.lbl_arvatoLevel.ImageList = this.imageList;
            this.lbl_arvatoLevel.Location = new System.Drawing.Point(5, 94);
            this.lbl_arvatoLevel.Name = "lbl_arvatoLevel";
            this.lbl_arvatoLevel.Size = new System.Drawing.Size(174, 21);
            this.lbl_arvatoLevel.TabIndex = 64;
            this.lbl_arvatoLevel.Text = "Arvato Level:";
            this.lbl_arvatoLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_managerID
            // 
            this.lbl_managerID.AutoSize = true;
            this.lbl_managerID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_managerID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_managerID.ImageIndex = 1;
            this.lbl_managerID.ImageList = this.imageList;
            this.lbl_managerID.Location = new System.Drawing.Point(5, 117);
            this.lbl_managerID.Name = "lbl_managerID";
            this.lbl_managerID.Size = new System.Drawing.Size(174, 21);
            this.lbl_managerID.TabIndex = 65;
            this.lbl_managerID.Text = "Hiring Manager ID:";
            this.lbl_managerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_bucket
            // 
            this.cbx_bucket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_bucket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_bucket.FormattingEnabled = true;
            this.cbx_bucket.Location = new System.Drawing.Point(184, 25);
            this.cbx_bucket.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_bucket.Name = "cbx_bucket";
            this.cbx_bucket.Size = new System.Drawing.Size(320, 21);
            this.cbx_bucket.TabIndex = 78;
            this.cbx_bucket.SelectedIndexChanged += new System.EventHandler(this.cbx_bucket_SelectedIndexChanged);
            // 
            // cbx_position
            // 
            this.cbx_position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_position.FormattingEnabled = true;
            this.cbx_position.Location = new System.Drawing.Point(184, 2);
            this.cbx_position.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_position.Name = "cbx_position";
            this.cbx_position.Size = new System.Drawing.Size(320, 21);
            this.cbx_position.TabIndex = 84;
            this.cbx_position.SelectedIndexChanged += new System.EventHandler(this.cbx_position_SelectedIndexChanged);
            // 
            // gbxAppInfo
            // 
            this.gbxAppInfo.Controls.Add(this.applicantInfo);
            this.gbxAppInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxAppInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAppInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxAppInfo.Name = "gbxAppInfo";
            this.gbxAppInfo.Size = new System.Drawing.Size(563, 157);
            this.gbxAppInfo.TabIndex = 61;
            this.gbxAppInfo.TabStop = false;
            this.gbxAppInfo.Text = "Info";
            // 
            // applicantInfo
            // 
            this.applicantInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.applicantInfo.ColumnCount = 2;
            this.applicantInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0179F));
            this.applicantInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.9821F));
            this.applicantInfo.Controls.Add(this.label1, 0, 0);
            this.applicantInfo.Controls.Add(this.label2, 0, 1);
            this.applicantInfo.Controls.Add(this.label3, 0, 2);
            this.applicantInfo.Controls.Add(this.lbl_name, 1, 0);
            this.applicantInfo.Controls.Add(this.lbl_applicationDate, 1, 1);
            this.applicantInfo.Controls.Add(this.lbl_positionApplied, 1, 2);
            this.applicantInfo.Location = new System.Drawing.Point(25, 46);
            this.applicantInfo.Margin = new System.Windows.Forms.Padding(1);
            this.applicantInfo.Name = "applicantInfo";
            this.applicantInfo.RowCount = 3;
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.Size = new System.Drawing.Size(506, 68);
            this.applicantInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Application Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Applied Position:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(184, 2);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(320, 20);
            this.lbl_name.TabIndex = 60;
            this.lbl_name.Text = "<----->";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_applicationDate
            // 
            this.lbl_applicationDate.AutoSize = true;
            this.lbl_applicationDate.BackColor = System.Drawing.Color.White;
            this.lbl_applicationDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_applicationDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_applicationDate.Location = new System.Drawing.Point(184, 24);
            this.lbl_applicationDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_applicationDate.Name = "lbl_applicationDate";
            this.lbl_applicationDate.Size = new System.Drawing.Size(320, 20);
            this.lbl_applicationDate.TabIndex = 61;
            this.lbl_applicationDate.Text = "<----->";
            this.lbl_applicationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_positionApplied
            // 
            this.lbl_positionApplied.AutoSize = true;
            this.lbl_positionApplied.BackColor = System.Drawing.Color.White;
            this.lbl_positionApplied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_positionApplied.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_positionApplied.Location = new System.Drawing.Point(184, 46);
            this.lbl_positionApplied.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_positionApplied.Name = "lbl_positionApplied";
            this.lbl_positionApplied.Size = new System.Drawing.Size(320, 20);
            this.lbl_positionApplied.TabIndex = 62;
            this.lbl_positionApplied.Text = "<----->";
            this.lbl_positionApplied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ControlApplicantEvaluationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxAppInfo);
            this.Controls.Add(this.panel2);
            this.Name = "ControlApplicantEvaluationDetails";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(587, 521);
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbxAppInfo.ResumeLayout(false);
            this.applicantInfo.ResumeLayout(false);
            this.applicantInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbx_arvatoLevel;
        private System.Windows.Forms.ComboBox cbx_languageRequirement;
        private System.Windows.Forms.ComboBox cbx_titanTitle;
        private System.Windows.Forms.Label lbl_jobTitle;
        private System.Windows.Forms.Label lbl_bucket;
        private System.Windows.Forms.Label lbl_titanTitle;
        private System.Windows.Forms.Label lbl_langRequirement;
        private System.Windows.Forms.Label lbl_arvatoLevel;
        private System.Windows.Forms.Label lbl_managerID;
        private System.Windows.Forms.ComboBox cbx_bucket;
        private System.Windows.Forms.GroupBox gbxAppInfo;
        private System.Windows.Forms.TableLayoutPanel applicantInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lbl_applicationDate;
        public System.Windows.Forms.Label lbl_positionApplied;
        private System.Windows.Forms.ComboBox cbx_position;
        private System.Windows.Forms.ComboBox cbx_managerID;
    }
}
