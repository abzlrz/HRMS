namespace UI
{
    partial class InterviewEvaluationForm
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
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.cbxAppliedBefore = new System.Windows.Forms.ComboBox();
            this.gdv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxArvatoLevel = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxManagerID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxLanguageReq = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxBucket = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTitanTitle = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxJobTitle = new System.Windows.Forms.ComboBox();
            this.applicantName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxEvaluationAnalysis = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox27 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).BeginInit();
            this.gbxInfo.SuspendLayout();
            this.gbxEvaluationAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxView
            // 
            this.gbxView.Controls.Add(this.cbxAppliedBefore);
            this.gbxView.Controls.Add(this.gdv);
            this.gbxView.Controls.Add(this.textBox1);
            this.gbxView.Location = new System.Drawing.Point(12, 12);
            this.gbxView.Name = "gbxView";
            this.gbxView.Size = new System.Drawing.Size(349, 294);
            this.gbxView.TabIndex = 0;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "List of Applicants";
            // 
            // cbxAppliedBefore
            // 
            this.cbxAppliedBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAppliedBefore.FormattingEnabled = true;
            this.cbxAppliedBefore.Items.AddRange(new object[] {
            "ID",
            "Firstname",
            "Lastname",
            "Application Date",
            "Job Title",
            "Hiring Manager",
            "Bucket"});
            this.cbxAppliedBefore.Location = new System.Drawing.Point(196, 32);
            this.cbxAppliedBefore.Name = "cbxAppliedBefore";
            this.cbxAppliedBefore.Size = new System.Drawing.Size(133, 21);
            this.cbxAppliedBefore.TabIndex = 0;
            this.cbxAppliedBefore.Tag = "required";
            // 
            // gdv
            // 
            this.gdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv.Location = new System.Drawing.Point(27, 61);
            this.gdv.Name = "gdv";
            this.gdv.Size = new System.Drawing.Size(302, 211);
            this.gdv.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 1;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.btnEvaluate);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.cbxArvatoLevel);
            this.gbxInfo.Controls.Add(this.label13);
            this.gbxInfo.Controls.Add(this.tbxManagerID);
            this.gbxInfo.Controls.Add(this.label12);
            this.gbxInfo.Controls.Add(this.label11);
            this.gbxInfo.Controls.Add(this.cbxLanguageReq);
            this.gbxInfo.Controls.Add(this.label10);
            this.gbxInfo.Controls.Add(this.cbxBucket);
            this.gbxInfo.Controls.Add(this.label9);
            this.gbxInfo.Controls.Add(this.cbxTitanTitle);
            this.gbxInfo.Controls.Add(this.label8);
            this.gbxInfo.Controls.Add(this.label7);
            this.gbxInfo.Controls.Add(this.cbxJobTitle);
            this.gbxInfo.Controls.Add(this.applicantName);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Location = new System.Drawing.Point(12, 312);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(349, 334);
            this.gbxInfo.TabIndex = 1;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Evaluation Info";
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(233, 291);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluate.TabIndex = 40;
            this.btnEvaluate.Text = "Proceed...";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.OnBtnEvaluateClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Arvato level:";
            // 
            // cbxArvatoLevel
            // 
            this.cbxArvatoLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArvatoLevel.FormattingEnabled = true;
            this.cbxArvatoLevel.Location = new System.Drawing.Point(172, 194);
            this.cbxArvatoLevel.Name = "cbxArvatoLevel";
            this.cbxArvatoLevel.Size = new System.Drawing.Size(136, 21);
            this.cbxArvatoLevel.TabIndex = 4;
            this.cbxArvatoLevel.Tag = "required";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(318, 19);
            this.label13.TabIndex = 37;
            this.label13.Text = "Hiring Manager [Lastname, Firstname Middlename]";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxManagerID
            // 
            this.tbxManagerID.Enabled = false;
            this.tbxManagerID.Location = new System.Drawing.Point(172, 218);
            this.tbxManagerID.Name = "tbxManagerID";
            this.tbxManagerID.Size = new System.Drawing.Size(136, 22);
            this.tbxManagerID.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Hiring Manager ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Language Requirement:";
            // 
            // cbxLanguageReq
            // 
            this.cbxLanguageReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguageReq.FormattingEnabled = true;
            this.cbxLanguageReq.Location = new System.Drawing.Point(172, 170);
            this.cbxLanguageReq.Name = "cbxLanguageReq";
            this.cbxLanguageReq.Size = new System.Drawing.Size(136, 21);
            this.cbxLanguageReq.TabIndex = 3;
            this.cbxLanguageReq.Tag = "required";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Bucket:";
            // 
            // cbxBucket
            // 
            this.cbxBucket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBucket.FormattingEnabled = true;
            this.cbxBucket.Location = new System.Drawing.Point(172, 122);
            this.cbxBucket.Name = "cbxBucket";
            this.cbxBucket.Size = new System.Drawing.Size(136, 21);
            this.cbxBucket.TabIndex = 1;
            this.cbxBucket.Tag = "required";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Titan Title:";
            // 
            // cbxTitanTitle
            // 
            this.cbxTitanTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTitanTitle.FormattingEnabled = true;
            this.cbxTitanTitle.Location = new System.Drawing.Point(172, 146);
            this.cbxTitanTitle.Name = "cbxTitanTitle";
            this.cbxTitanTitle.Size = new System.Drawing.Size(136, 21);
            this.cbxTitanTitle.TabIndex = 2;
            this.cbxTitanTitle.Tag = "required";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "---------------------------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Job Title:";
            // 
            // cbxJobTitle
            // 
            this.cbxJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJobTitle.FormattingEnabled = true;
            this.cbxJobTitle.Location = new System.Drawing.Point(172, 98);
            this.cbxJobTitle.Name = "cbxJobTitle";
            this.cbxJobTitle.Size = new System.Drawing.Size(136, 21);
            this.cbxJobTitle.TabIndex = 0;
            this.cbxJobTitle.Tag = "required";
            // 
            // applicantName
            // 
            this.applicantName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicantName.Location = new System.Drawing.Point(89, 26);
            this.applicantName.Name = "applicantName";
            this.applicantName.Size = new System.Drawing.Size(240, 57);
            this.applicantName.TabIndex = 3;
            this.applicantName.Text = "[LASTNAME, \r\nFIRSTNAME MIDDLENAME]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fullname:";
            // 
            // gbxEvaluationAnalysis
            // 
            this.gbxEvaluationAnalysis.Controls.Add(this.btnReset);
            this.gbxEvaluationAnalysis.Controls.Add(this.button4);
            this.gbxEvaluationAnalysis.Controls.Add(this.button3);
            this.gbxEvaluationAnalysis.Controls.Add(this.button2);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox27);
            this.gbxEvaluationAnalysis.Controls.Add(this.label32);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox26);
            this.gbxEvaluationAnalysis.Controls.Add(this.label31);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox25);
            this.gbxEvaluationAnalysis.Controls.Add(this.label30);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox24);
            this.gbxEvaluationAnalysis.Controls.Add(this.label29);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox23);
            this.gbxEvaluationAnalysis.Controls.Add(this.label28);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox22);
            this.gbxEvaluationAnalysis.Controls.Add(this.label27);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox21);
            this.gbxEvaluationAnalysis.Controls.Add(this.label26);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox20);
            this.gbxEvaluationAnalysis.Controls.Add(this.label25);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox19);
            this.gbxEvaluationAnalysis.Controls.Add(this.label24);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox18);
            this.gbxEvaluationAnalysis.Controls.Add(this.label23);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox17);
            this.gbxEvaluationAnalysis.Controls.Add(this.label22);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox16);
            this.gbxEvaluationAnalysis.Controls.Add(this.label21);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox15);
            this.gbxEvaluationAnalysis.Controls.Add(this.label20);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox14);
            this.gbxEvaluationAnalysis.Controls.Add(this.label19);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox13);
            this.gbxEvaluationAnalysis.Controls.Add(this.label18);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox12);
            this.gbxEvaluationAnalysis.Controls.Add(this.label17);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox11);
            this.gbxEvaluationAnalysis.Controls.Add(this.label16);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox10);
            this.gbxEvaluationAnalysis.Controls.Add(this.label15);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox9);
            this.gbxEvaluationAnalysis.Controls.Add(this.label14);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox8);
            this.gbxEvaluationAnalysis.Controls.Add(this.label6);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox7);
            this.gbxEvaluationAnalysis.Controls.Add(this.label5);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox6);
            this.gbxEvaluationAnalysis.Controls.Add(this.label4);
            this.gbxEvaluationAnalysis.Controls.Add(this.comboBox5);
            this.gbxEvaluationAnalysis.Controls.Add(this.label3);
            this.gbxEvaluationAnalysis.Enabled = false;
            this.gbxEvaluationAnalysis.Location = new System.Drawing.Point(367, 12);
            this.gbxEvaluationAnalysis.Name = "gbxEvaluationAnalysis";
            this.gbxEvaluationAnalysis.Size = new System.Drawing.Size(582, 634);
            this.gbxEvaluationAnalysis.TabIndex = 2;
            this.gbxEvaluationAnalysis.TabStop = false;
            this.gbxEvaluationAnalysis.Text = "Evaluation Analysis";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(159, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 27);
            this.button4.TabIndex = 86;
            this.button4.Text = "Add to Shortlist";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(293, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 27);
            this.button3.TabIndex = 85;
            this.button3.Text = "Offer a Job";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(427, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 27);
            this.button2.TabIndex = 41;
            this.button2.Text = "Reject";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // comboBox27
            // 
            this.comboBox27.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox27.FormattingEnabled = true;
            this.comboBox27.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox27.Location = new System.Drawing.Point(308, 555);
            this.comboBox27.Name = "comboBox27";
            this.comboBox27.Size = new System.Drawing.Size(247, 21);
            this.comboBox27.TabIndex = 22;
            this.comboBox27.Tag = "required";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(22, 558);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(159, 13);
            this.label32.TabIndex = 84;
            this.label32.Text = "Asked Good Work Questions:";
            // 
            // comboBox26
            // 
            this.comboBox26.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox26.Location = new System.Drawing.Point(308, 531);
            this.comboBox26.Name = "comboBox26";
            this.comboBox26.Size = new System.Drawing.Size(247, 21);
            this.comboBox26.TabIndex = 21;
            this.comboBox26.Tag = "required";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(22, 534);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(159, 13);
            this.label31.TabIndex = 82;
            this.label31.Text = "Judgement, Decision Making:";
            // 
            // comboBox25
            // 
            this.comboBox25.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox25.Location = new System.Drawing.Point(308, 507);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(247, 21);
            this.comboBox25.TabIndex = 20;
            this.comboBox25.Tag = "required";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(22, 510);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(159, 13);
            this.label30.TabIndex = 80;
            this.label30.Text = "Judgement, Decision Making:";
            // 
            // comboBox24
            // 
            this.comboBox24.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox24.Location = new System.Drawing.Point(308, 483);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(247, 21);
            this.comboBox24.TabIndex = 19;
            this.comboBox24.Tag = "required";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(22, 486);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(132, 13);
            this.label29.TabIndex = 78;
            this.label29.Text = "Self Motivation && Goals:";
            // 
            // comboBox23
            // 
            this.comboBox23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox23.Location = new System.Drawing.Point(308, 459);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(247, 21);
            this.comboBox23.TabIndex = 18;
            this.comboBox23.Tag = "required";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(22, 462);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(248, 13);
            this.label28.TabIndex = 76;
            this.label28.Text = "Coping Ability (Stress, Conflict, Time Demands):";
            // 
            // comboBox22
            // 
            this.comboBox22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox22.Location = new System.Drawing.Point(308, 434);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(247, 21);
            this.comboBox22.TabIndex = 17;
            this.comboBox22.Tag = "required";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(22, 437);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 13);
            this.label27.TabIndex = 74;
            this.label27.Text = "Leadership Skills:";
            // 
            // comboBox21
            // 
            this.comboBox21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox21.Location = new System.Drawing.Point(308, 409);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(247, 21);
            this.comboBox21.TabIndex = 16;
            this.comboBox21.Tag = "required";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(22, 412);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 13);
            this.label26.TabIndex = 72;
            this.label26.Text = "Listening Skills:";
            // 
            // comboBox20
            // 
            this.comboBox20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox20.Location = new System.Drawing.Point(308, 385);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(247, 21);
            this.comboBox20.TabIndex = 15;
            this.comboBox20.Tag = "required";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(22, 388);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(266, 13);
            this.label25.TabIndex = 70;
            this.label25.Text = "Non-verbal (Posture, Hand Gesture, Didn\'t Fidget):";
            // 
            // comboBox19
            // 
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox19.Location = new System.Drawing.Point(308, 361);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(247, 21);
            this.comboBox19.TabIndex = 14;
            this.comboBox19.Tag = "required";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(22, 364);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 13);
            this.label24.TabIndex = 68;
            this.label24.Text = "Communication Skills:";
            // 
            // comboBox18
            // 
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox18.Location = new System.Drawing.Point(308, 337);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(247, 21);
            this.comboBox18.TabIndex = 13;
            this.comboBox18.Tag = "required";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(22, 340);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(126, 13);
            this.label23.TabIndex = 66;
            this.label23.Text = "Customer Service Skills:";
            // 
            // comboBox17
            // 
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox17.Location = new System.Drawing.Point(308, 313);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(247, 21);
            this.comboBox17.TabIndex = 12;
            this.comboBox17.Tag = "required";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(22, 316);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 13);
            this.label22.TabIndex = 64;
            this.label22.Text = "Team Skills:";
            // 
            // comboBox16
            // 
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox16.Location = new System.Drawing.Point(308, 289);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(247, 21);
            this.comboBox16.TabIndex = 11;
            this.comboBox16.Tag = "required";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(22, 292);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(156, 13);
            this.label21.TabIndex = 62;
            this.label21.Text = "Answers Focus on Strengths:";
            // 
            // comboBox15
            // 
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox15.Location = new System.Drawing.Point(308, 265);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(247, 21);
            this.comboBox15.TabIndex = 10;
            this.comboBox15.Tag = "required";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 268);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 13);
            this.label20.TabIndex = 60;
            this.label20.Text = "Answered Questions Well:";
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox14.Location = new System.Drawing.Point(308, 241);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(247, 21);
            this.comboBox14.TabIndex = 9;
            this.comboBox14.Tag = "required";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 244);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 13);
            this.label19.TabIndex = 58;
            this.label19.Text = "Related Experience:";
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox13.Location = new System.Drawing.Point(308, 217);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(247, 21);
            this.comboBox13.TabIndex = 8;
            this.comboBox13.Tag = "required";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 220);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 13);
            this.label18.TabIndex = 56;
            this.label18.Text = "Education/Training:";
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox12.Location = new System.Drawing.Point(308, 193);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(247, 21);
            this.comboBox12.TabIndex = 7;
            this.comboBox12.Tag = "required";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(22, 196);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Knowledge of Job/Company:";
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox11.Location = new System.Drawing.Point(308, 169);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(247, 21);
            this.comboBox11.TabIndex = 6;
            this.comboBox11.Tag = "required";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Confidence:";
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox10.Location = new System.Drawing.Point(308, 145);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(247, 21);
            this.comboBox10.TabIndex = 5;
            this.comboBox10.Tag = "required";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Level of Interest:";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox9.Location = new System.Drawing.Point(308, 121);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(247, 21);
            this.comboBox9.TabIndex = 4;
            this.comboBox9.Tag = "required";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Eye Contact:";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox8.Location = new System.Drawing.Point(308, 97);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(247, 21);
            this.comboBox8.TabIndex = 3;
            this.comboBox8.Tag = "required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Dress Appropriately:";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox7.Location = new System.Drawing.Point(308, 73);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(247, 21);
            this.comboBox7.TabIndex = 2;
            this.comboBox7.Tag = "required";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Attitude:";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox6.Location = new System.Drawing.Point(308, 49);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(247, 21);
            this.comboBox6.TabIndex = 1;
            this.comboBox6.Tag = "required";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Made Good First Impression:";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Poor",
            "Fair",
            "Proficient",
            "Very Good",
            "Excellent"});
            this.comboBox5.Location = new System.Drawing.Point(308, 25);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(247, 21);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.Tag = "required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Greeting to Committee:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(62, 593);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 27);
            this.btnReset.TabIndex = 87;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // InterviewEvaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 658);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.gbxEvaluationAnalysis);
            this.Controls.Add(this.gbxView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InterviewEvaluationForm";
            this.Text = "Evaluation Info";
            this.gbxView.ResumeLayout(false);
            this.gbxView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv)).EndInit();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.gbxEvaluationAnalysis.ResumeLayout(false);
            this.gbxEvaluationAnalysis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxView;
        private System.Windows.Forms.DataGridView gdv;
        private System.Windows.Forms.ComboBox cbxAppliedBefore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Label applicantName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxLanguageReq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxBucket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTitanTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxJobTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxManagerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxArvatoLevel;
        private System.Windows.Forms.GroupBox gbxEvaluationAnalysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox27;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboBox26;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBox24;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox comboBox23;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.Label label19;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReset;
    }
}

