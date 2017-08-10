namespace UI
{
    partial class TrainingFeedbackAssesmentForm
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
            this.gbxShortlist = new System.Windows.Forms.GroupBox();
            this.cbxAppliedBefore = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxReviewer = new System.Windows.Forms.ComboBox();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
            this.tbxJobTitle = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gbxPerformance = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxSummary = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFailed = new System.Windows.Forms.Button();
            this.btnPassed = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnChangeEmployee = new System.Windows.Forms.Button();
            this.gbxShortlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxInfo.SuspendLayout();
            this.gbxPerformance.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxSummary.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxShortlist
            // 
            this.gbxShortlist.Controls.Add(this.cbxAppliedBefore);
            this.gbxShortlist.Controls.Add(this.textBox2);
            this.gbxShortlist.Controls.Add(this.dataGridView1);
            this.gbxShortlist.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShortlist.Location = new System.Drawing.Point(12, 12);
            this.gbxShortlist.Name = "gbxShortlist";
            this.gbxShortlist.Size = new System.Drawing.Size(357, 286);
            this.gbxShortlist.TabIndex = 1;
            this.gbxShortlist.TabStop = false;
            this.gbxShortlist.Text = "Employee List";
            // 
            // cbxAppliedBefore
            // 
            this.cbxAppliedBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAppliedBefore.FormattingEnabled = true;
            this.cbxAppliedBefore.Items.AddRange(new object[] {
            "ID",
            "Firstname",
            "Lastname",
            "Date Evaluated",
            "Job Title"});
            this.cbxAppliedBefore.Location = new System.Drawing.Point(215, 33);
            this.cbxAppliedBefore.Name = "cbxAppliedBefore";
            this.cbxAppliedBefore.Size = new System.Drawing.Size(127, 21);
            this.cbxAppliedBefore.TabIndex = 0;
            this.cbxAppliedBefore.Tag = "required";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 22);
            this.textBox2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 201);
            this.dataGridView1.TabIndex = 2;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.btnProceed);
            this.gbxInfo.Controls.Add(this.textBox1);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Controls.Add(this.cbxReviewer);
            this.gbxInfo.Controls.Add(this.tbxEmployeeName);
            this.gbxInfo.Controls.Add(this.tbxJobTitle);
            this.gbxInfo.Controls.Add(this.dateTimePicker1);
            this.gbxInfo.Controls.Add(this.label4);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.label9);
            this.gbxInfo.Controls.Add(this.label19);
            this.gbxInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfo.Location = new System.Drawing.Point(12, 304);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(357, 202);
            this.gbxInfo.TabIndex = 2;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Info";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(261, 162);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 69;
            this.btnProceed.Text = "Proceed...";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.OnProceedClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox1.Location = new System.Drawing.Point(136, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Reviewer:";
            // 
            // cbxReviewer
            // 
            this.cbxReviewer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxReviewer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxReviewer.FormattingEnabled = true;
            this.cbxReviewer.Location = new System.Drawing.Point(136, 75);
            this.cbxReviewer.Name = "cbxReviewer";
            this.cbxReviewer.Size = new System.Drawing.Size(200, 21);
            this.cbxReviewer.TabIndex = 66;
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Enabled = false;
            this.tbxEmployeeName.ForeColor = System.Drawing.Color.MediumBlue;
            this.tbxEmployeeName.Location = new System.Drawing.Point(136, 23);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.ReadOnly = true;
            this.tbxEmployeeName.Size = new System.Drawing.Size(200, 22);
            this.tbxEmployeeName.TabIndex = 65;
            // 
            // tbxJobTitle
            // 
            this.tbxJobTitle.Enabled = false;
            this.tbxJobTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.tbxJobTitle.Location = new System.Drawing.Point(136, 49);
            this.tbxJobTitle.Name = "tbxJobTitle";
            this.tbxJobTitle.ReadOnly = true;
            this.tbxJobTitle.Size = new System.Drawing.Size(200, 22);
            this.tbxJobTitle.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Review Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Reviewer Emp ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Job Title:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "Employee Name:";
            // 
            // gbxPerformance
            // 
            this.gbxPerformance.Controls.Add(this.label26);
            this.gbxPerformance.Controls.Add(this.tableLayoutPanel1);
            this.gbxPerformance.Controls.Add(this.comboBox14);
            this.gbxPerformance.Controls.Add(this.label3);
            this.gbxPerformance.Controls.Add(this.comboBox13);
            this.gbxPerformance.Controls.Add(this.label18);
            this.gbxPerformance.Controls.Add(this.comboBox12);
            this.gbxPerformance.Controls.Add(this.label17);
            this.gbxPerformance.Controls.Add(this.comboBox11);
            this.gbxPerformance.Controls.Add(this.label16);
            this.gbxPerformance.Controls.Add(this.comboBox10);
            this.gbxPerformance.Controls.Add(this.label15);
            this.gbxPerformance.Controls.Add(this.comboBox9);
            this.gbxPerformance.Controls.Add(this.label14);
            this.gbxPerformance.Controls.Add(this.comboBox8);
            this.gbxPerformance.Controls.Add(this.label6);
            this.gbxPerformance.Controls.Add(this.comboBox7);
            this.gbxPerformance.Controls.Add(this.label5);
            this.gbxPerformance.Controls.Add(this.comboBox6);
            this.gbxPerformance.Controls.Add(this.label7);
            this.gbxPerformance.Controls.Add(this.comboBox5);
            this.gbxPerformance.Controls.Add(this.label8);
            this.gbxPerformance.Enabled = false;
            this.gbxPerformance.Location = new System.Drawing.Point(375, 12);
            this.gbxPerformance.Name = "gbxPerformance";
            this.gbxPerformance.Size = new System.Drawing.Size(281, 494);
            this.gbxPerformance.TabIndex = 3;
            this.gbxPerformance.TabStop = false;
            this.gbxPerformance.Text = "Performance";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(39, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 13);
            this.label26.TabIndex = 80;
            this.label26.Text = "LEGEND:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81F));
            this.tableLayoutPanel1.Controls.Add(this.label25, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label24, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label23, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label22, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label21, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 108);
            this.tableLayoutPanel1.TabIndex = 79;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Location = new System.Drawing.Point(42, 87);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(154, 20);
            this.label25.TabIndex = 9;
            this.label25.Text = "Poor";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(42, 66);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(154, 20);
            this.label24.TabIndex = 8;
            this.label24.Text = "Fair";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(42, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 20);
            this.label23.TabIndex = 7;
            this.label23.Text = "Good";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(42, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(154, 21);
            this.label22.TabIndex = 6;
            this.label22.Text = "Very Good";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "5";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "4";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "3";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 20);
            this.label20.TabIndex = 4;
            this.label20.Text = "1";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(42, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 21);
            this.label21.TabIndex = 5;
            this.label21.Text = "Excellent";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox14.Location = new System.Drawing.Point(191, 427);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(67, 21);
            this.comboBox14.TabIndex = 68;
            this.comboBox14.Tag = "required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Others";
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox13.Location = new System.Drawing.Point(191, 403);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(67, 21);
            this.comboBox13.TabIndex = 67;
            this.comboBox13.Tag = "required";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 405);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 13);
            this.label18.TabIndex = 77;
            this.label18.Text = "Achievements of Goals";
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox12.Location = new System.Drawing.Point(191, 379);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(67, 21);
            this.comboBox12.TabIndex = 66;
            this.comboBox12.Tag = "required";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 76;
            this.label17.Text = "Productivity";
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox11.Location = new System.Drawing.Point(191, 355);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(67, 21);
            this.comboBox11.TabIndex = 65;
            this.comboBox11.Tag = "required";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 357);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 13);
            this.label16.TabIndex = 75;
            this.label16.Text = "Contribution to the group";
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox10.Location = new System.Drawing.Point(191, 331);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(67, 21);
            this.comboBox10.TabIndex = 64;
            this.comboBox10.Tag = "required";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 74;
            this.label15.Text = "Management Ability";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox9.Location = new System.Drawing.Point(191, 307);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(67, 21);
            this.comboBox9.TabIndex = 63;
            this.comboBox9.Tag = "required";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "Personality:";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox8.Location = new System.Drawing.Point(191, 283);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(67, 21);
            this.comboBox8.TabIndex = 62;
            this.comboBox8.Tag = "required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Communication Skills";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox7.Location = new System.Drawing.Point(191, 259);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(67, 21);
            this.comboBox7.TabIndex = 61;
            this.comboBox7.Tag = "required";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "Job Knowledge";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox6.Location = new System.Drawing.Point(191, 235);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(67, 21);
            this.comboBox6.TabIndex = 60;
            this.comboBox6.Tag = "required";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Dependability";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox5.Location = new System.Drawing.Point(191, 211);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(67, 21);
            this.comboBox5.TabIndex = 59;
            this.comboBox5.Tag = "required";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "General Quality of Work:";
            // 
            // gbxSummary
            // 
            this.gbxSummary.Controls.Add(this.btnChangeEmployee);
            this.gbxSummary.Controls.Add(this.btnReset);
            this.gbxSummary.Controls.Add(this.btnFailed);
            this.gbxSummary.Controls.Add(this.btnPassed);
            this.gbxSummary.Controls.Add(this.tableLayoutPanel2);
            this.gbxSummary.Enabled = false;
            this.gbxSummary.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSummary.Location = new System.Drawing.Point(662, 12);
            this.gbxSummary.Name = "gbxSummary";
            this.gbxSummary.Size = new System.Drawing.Size(447, 494);
            this.gbxSummary.TabIndex = 4;
            this.gbxSummary.TabStop = false;
            this.gbxSummary.Text = "Performance Summary";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(117, 450);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 27);
            this.btnReset.TabIndex = 89;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnFailed
            // 
            this.btnFailed.BackColor = System.Drawing.Color.Gold;
            this.btnFailed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFailed.Location = new System.Drawing.Point(215, 450);
            this.btnFailed.Name = "btnFailed";
            this.btnFailed.Size = new System.Drawing.Size(104, 27);
            this.btnFailed.TabIndex = 88;
            this.btnFailed.Text = "Failed";
            this.btnFailed.UseVisualStyleBackColor = false;
            // 
            // btnPassed
            // 
            this.btnPassed.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPassed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPassed.Location = new System.Drawing.Point(325, 450);
            this.btnPassed.Name = "btnPassed";
            this.btnPassed.Size = new System.Drawing.Size(104, 27);
            this.btnPassed.TabIndex = 87;
            this.btnPassed.Text = "Passed";
            this.btnPassed.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.738095F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.2619F));
            this.tableLayoutPanel2.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label27, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label29, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label30, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label31, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label32, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label33, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label34, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox7, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 392);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(3, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 23);
            this.label28.TabIndex = 1;
            this.label28.Text = "1.";
            this.label28.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(34, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(376, 23);
            this.label27.TabIndex = 0;
            this.label27.Text = "What is the employee\'s strongest points?";
            this.label27.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(3, 98);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(25, 23);
            this.label29.TabIndex = 2;
            this.label29.Text = "2.";
            this.label29.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(34, 98);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(376, 23);
            this.label30.TabIndex = 3;
            this.label30.Text = "What are the employee\'s weakest points?";
            this.label30.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Location = new System.Drawing.Point(3, 196);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(25, 23);
            this.label31.TabIndex = 4;
            this.label31.Text = "3.";
            this.label31.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Location = new System.Drawing.Point(34, 196);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(376, 23);
            this.label32.TabIndex = 5;
            this.label32.Text = "What can employee do to be more effective or to make improvements?";
            this.label32.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Location = new System.Drawing.Point(3, 294);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(25, 23);
            this.label33.TabIndex = 6;
            this.label33.Text = "4.";
            this.label33.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Location = new System.Drawing.Point(34, 294);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(376, 23);
            this.label34.TabIndex = 7;
            this.label34.Text = "What additional training would benefit the employee?";
            this.label34.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(34, 320);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(376, 69);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(34, 26);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(376, 69);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(34, 124);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(376, 69);
            this.textBox5.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(34, 222);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(376, 69);
            this.textBox7.TabIndex = 13;
            // 
            // btnChangeEmployee
            // 
            this.btnChangeEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeEmployee.Location = new System.Drawing.Point(19, 450);
            this.btnChangeEmployee.Name = "btnChangeEmployee";
            this.btnChangeEmployee.Size = new System.Drawing.Size(92, 27);
            this.btnChangeEmployee.TabIndex = 90;
            this.btnChangeEmployee.Text = "Employee...";
            this.btnChangeEmployee.UseVisualStyleBackColor = false;
            // 
            // TrainingFeedbackAssesmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 516);
            this.Controls.Add(this.gbxSummary);
            this.Controls.Add(this.gbxPerformance);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.gbxShortlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrainingFeedbackAssesmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Feedback and Assesment Form";
            this.gbxShortlist.ResumeLayout(false);
            this.gbxShortlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.gbxPerformance.ResumeLayout(false);
            this.gbxPerformance.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbxSummary.ResumeLayout(false);
            this.gbxSummary.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxShortlist;
        private System.Windows.Forms.ComboBox cbxAppliedBefore;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxPerformance;
        private System.Windows.Forms.TextBox tbxEmployeeName;
        private System.Windows.Forms.TextBox tbxJobTitle;
        private System.Windows.Forms.ComboBox cbxReviewer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnFailed;
        private System.Windows.Forms.Button btnPassed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnChangeEmployee;
    }
}