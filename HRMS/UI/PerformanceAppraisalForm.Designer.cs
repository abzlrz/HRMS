namespace UI
{
    partial class PerformanceAppraisalForm
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
            this.gbxEmployee = new System.Windows.Forms.GroupBox();
            this.cbxAppliedBefore = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
            this.tbxJobTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gbxPeriod = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxDescription = new System.Windows.Forms.GroupBox();
            this.btnChangeEmployee = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cbxApprover = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbxEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxInfo.SuspendLayout();
            this.gbxPeriod.SuspendLayout();
            this.gbxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEmployee
            // 
            this.gbxEmployee.Controls.Add(this.cbxAppliedBefore);
            this.gbxEmployee.Controls.Add(this.textBox2);
            this.gbxEmployee.Controls.Add(this.dataGridView1);
            this.gbxEmployee.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployee.Location = new System.Drawing.Point(12, 12);
            this.gbxEmployee.Name = "gbxEmployee";
            this.gbxEmployee.Size = new System.Drawing.Size(357, 286);
            this.gbxEmployee.TabIndex = 2;
            this.gbxEmployee.TabStop = false;
            this.gbxEmployee.Text = "Employee List";
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
            this.gbxInfo.Controls.Add(this.label10);
            this.gbxInfo.Controls.Add(this.textBox6);
            this.gbxInfo.Controls.Add(this.comboBox1);
            this.gbxInfo.Controls.Add(this.label1);
            this.gbxInfo.Controls.Add(this.label6);
            this.gbxInfo.Controls.Add(this.textBox4);
            this.gbxInfo.Controls.Add(this.textBox1);
            this.gbxInfo.Controls.Add(this.label4);
            this.gbxInfo.Controls.Add(this.textBox3);
            this.gbxInfo.Controls.Add(this.btnProceed);
            this.gbxInfo.Controls.Add(this.tbxEmployeeName);
            this.gbxInfo.Controls.Add(this.tbxJobTitle);
            this.gbxInfo.Controls.Add(this.label2);
            this.gbxInfo.Controls.Add(this.label9);
            this.gbxInfo.Controls.Add(this.label19);
            this.gbxInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInfo.Location = new System.Drawing.Point(12, 304);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(357, 260);
            this.gbxInfo.TabIndex = 3;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Info";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Current Salary:";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox6.Location = new System.Drawing.Point(136, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(200, 22);
            this.textBox6.TabIndex = 81;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Appraisal",
            "Re-appraisal",
            "Probationary"});
            this.comboBox1.Location = new System.Drawing.Point(136, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Appraisal type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Team:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox4.Location = new System.Drawing.Point(136, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(200, 22);
            this.textBox4.TabIndex = 77;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox1.Location = new System.Drawing.Point(136, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Bucket:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox3.Location = new System.Drawing.Point(136, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(200, 22);
            this.textBox3.TabIndex = 70;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(261, 227);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 69;
            this.btnProceed.Text = "Proceed...";
            this.btnProceed.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Job Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Employee Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "Employee ID:";
            // 
            // gbxPeriod
            // 
            this.gbxPeriod.Controls.Add(this.dateTimePicker2);
            this.gbxPeriod.Controls.Add(this.label5);
            this.gbxPeriod.Controls.Add(this.dateTimePicker1);
            this.gbxPeriod.Controls.Add(this.label3);
            this.gbxPeriod.Enabled = false;
            this.gbxPeriod.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPeriod.Location = new System.Drawing.Point(375, 12);
            this.gbxPeriod.Name = "gbxPeriod";
            this.gbxPeriod.Size = new System.Drawing.Size(360, 111);
            this.gbxPeriod.TabIndex = 4;
            this.gbxPeriod.TabStop = false;
            this.gbxPeriod.Text = "Evaluation Period";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(142, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "To:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "From:";
            // 
            // gbxDescription
            // 
            this.gbxDescription.Controls.Add(this.btnChangeEmployee);
            this.gbxDescription.Controls.Add(this.btnReset);
            this.gbxDescription.Controls.Add(this.btnRegister);
            this.gbxDescription.Controls.Add(this.label12);
            this.gbxDescription.Controls.Add(this.textBox7);
            this.gbxDescription.Controls.Add(this.label11);
            this.gbxDescription.Controls.Add(this.textBox5);
            this.gbxDescription.Controls.Add(this.cbxApprover);
            this.gbxDescription.Controls.Add(this.label8);
            this.gbxDescription.Controls.Add(this.dateTimePicker3);
            this.gbxDescription.Controls.Add(this.label7);
            this.gbxDescription.Enabled = false;
            this.gbxDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDescription.Location = new System.Drawing.Point(375, 129);
            this.gbxDescription.Name = "gbxDescription";
            this.gbxDescription.Size = new System.Drawing.Size(360, 435);
            this.gbxDescription.TabIndex = 5;
            this.gbxDescription.TabStop = false;
            this.gbxDescription.Text = "Appraisal Description";
            // 
            // btnChangeEmployee
            // 
            this.btnChangeEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeEmployee.Location = new System.Drawing.Point(32, 398);
            this.btnChangeEmployee.Name = "btnChangeEmployee";
            this.btnChangeEmployee.Size = new System.Drawing.Size(92, 27);
            this.btnChangeEmployee.TabIndex = 91;
            this.btnChangeEmployee.Text = "Employee...";
            this.toolTip.SetToolTip(this.btnChangeEmployee, "Change the selected employee");
            this.btnChangeEmployee.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Location = new System.Drawing.Point(130, 398);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 27);
            this.btnReset.TabIndex = 88;
            this.btnReset.Text = "Reset";
            this.toolTip.SetToolTip(this.btnReset, "Reset all");
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegister.Enabled = false;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(239, 398);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 27);
            this.btnRegister.TabIndex = 87;
            this.btnRegister.Text = "OK";
            this.toolTip.SetToolTip(this.btnRegister, "Apply changes");
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "Salary Increase to:";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox7.Location = new System.Drawing.Point(142, 101);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 22);
            this.textBox7.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 84;
            this.label11.Text = "Appraisal Description:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(33, 202);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(309, 129);
            this.textBox5.TabIndex = 83;
            // 
            // cbxApprover
            // 
            this.cbxApprover.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxApprover.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxApprover.FormattingEnabled = true;
            this.cbxApprover.Location = new System.Drawing.Point(142, 76);
            this.cbxApprover.Name = "cbxApprover";
            this.cbxApprover.Size = new System.Drawing.Size(200, 21);
            this.cbxApprover.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Approved by:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(142, 50);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Approved Date:";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // PerformanceAppraisalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 576);
            this.Controls.Add(this.gbxDescription);
            this.Controls.Add(this.gbxPeriod);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.gbxEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PerformanceAppraisalForm";
            this.Text = "Performance Appraisal Form";
            this.gbxEmployee.ResumeLayout(false);
            this.gbxEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.gbxPeriod.ResumeLayout(false);
            this.gbxPeriod.PerformLayout();
            this.gbxDescription.ResumeLayout(false);
            this.gbxDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEmployee;
        private System.Windows.Forms.ComboBox cbxAppliedBefore;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox tbxEmployeeName;
        private System.Windows.Forms.TextBox tbxJobTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gbxPeriod;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxApprover;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnChangeEmployee;
        private System.Windows.Forms.ToolTip toolTip;
    }
}