namespace Presentation.DialogBox.EmployeeRegistration
{
    partial class ControlEmployeeDetailsAndSalaryInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlEmployeeDetailsAndSalaryInfo));
            this.btn_previous = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lbl_relocAllowance = new System.Windows.Forms.Label();
            this.lbl_relocAllowanceDetails = new System.Windows.Forms.Label();
            this.date_approved = new System.Windows.Forms.DateTimePicker();
            this.date_started = new System.Windows.Forms.DateTimePicker();
            this.date_accepted = new System.Windows.Forms.DateTimePicker();
            this.lbl_costCenter = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_shiftAllowance = new System.Windows.Forms.Label();
            this.lbl_annualLangAllowance = new System.Windows.Forms.Label();
            this.lbl_annualBasedSalary = new System.Windows.Forms.Label();
            this.lbl_approvedSalary = new System.Windows.Forms.Label();
            this.lbl_dateStarted = new System.Windows.Forms.Label();
            this.lbl_dateAccepted = new System.Windows.Forms.Label();
            this.lbl_dateApproved = new System.Windows.Forms.Label();
            this.tbx_approvedSalary = new Presentation.Miscellaneous.CustomTextbox();
            this.tbx_annualBasedSalary = new Presentation.Miscellaneous.CustomTextbox();
            this.tbx_annualLangAllowance = new Presentation.Miscellaneous.CustomTextbox();
            this.tbx_shiftAllowance = new Presentation.Miscellaneous.CustomTextbox();
            this.tbx_relocAllowance = new Presentation.Miscellaneous.CustomTextbox();
            this.tbx_costCenter = new Presentation.Miscellaneous.CustomTextbox();
            this.tbx_relocAllowanceDetails = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbx_employeeDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_contract = new System.Windows.Forms.ComboBox();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_contractType = new System.Windows.Forms.Label();
            this.cbx_team = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbx_employeeDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_previous.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(376, 32);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 35);
            this.btn_previous.TabIndex = 13;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_previous);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(12, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 91);
            this.panel2.TabIndex = 62;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(457, 32);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 35);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DimGray;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(295, 32);
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
            // lbl_relocAllowance
            // 
            this.lbl_relocAllowance.AutoSize = true;
            this.lbl_relocAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_relocAllowance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_relocAllowance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_relocAllowance.Location = new System.Drawing.Point(5, 163);
            this.lbl_relocAllowance.Name = "lbl_relocAllowance";
            this.lbl_relocAllowance.Size = new System.Drawing.Size(252, 21);
            this.lbl_relocAllowance.TabIndex = 50;
            this.lbl_relocAllowance.Text = "Relocation Allowance:";
            this.lbl_relocAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_relocAllowanceDetails
            // 
            this.lbl_relocAllowanceDetails.AutoSize = true;
            this.lbl_relocAllowanceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_relocAllowanceDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_relocAllowanceDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_relocAllowanceDetails.Location = new System.Drawing.Point(5, 186);
            this.lbl_relocAllowanceDetails.Name = "lbl_relocAllowanceDetails";
            this.lbl_relocAllowanceDetails.Size = new System.Drawing.Size(252, 21);
            this.lbl_relocAllowanceDetails.TabIndex = 51;
            this.lbl_relocAllowanceDetails.Text = "Relocation Allowance Detail:";
            this.lbl_relocAllowanceDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_approved
            // 
            this.date_approved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_approved.Location = new System.Drawing.Point(262, 2);
            this.date_approved.Margin = new System.Windows.Forms.Padding(0);
            this.date_approved.Name = "date_approved";
            this.date_approved.Size = new System.Drawing.Size(235, 22);
            this.date_approved.TabIndex = 82;
            this.date_approved.ValueChanged += new System.EventHandler(this.date_approved_ValueChanged);
            // 
            // date_started
            // 
            this.date_started.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_started.Location = new System.Drawing.Point(262, 48);
            this.date_started.Margin = new System.Windows.Forms.Padding(0);
            this.date_started.Name = "date_started";
            this.date_started.Size = new System.Drawing.Size(235, 22);
            this.date_started.TabIndex = 84;
            this.date_started.ValueChanged += new System.EventHandler(this.date_started_ValueChanged);
            // 
            // date_accepted
            // 
            this.date_accepted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_accepted.Location = new System.Drawing.Point(262, 25);
            this.date_accepted.Margin = new System.Windows.Forms.Padding(0);
            this.date_accepted.Name = "date_accepted";
            this.date_accepted.Size = new System.Drawing.Size(235, 22);
            this.date_accepted.TabIndex = 83;
            this.date_accepted.ValueChanged += new System.EventHandler(this.date_accepted_ValueChanged);
            // 
            // lbl_costCenter
            // 
            this.lbl_costCenter.AutoSize = true;
            this.lbl_costCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_costCenter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_costCenter.Location = new System.Drawing.Point(5, 209);
            this.lbl_costCenter.Name = "lbl_costCenter";
            this.lbl_costCenter.Size = new System.Drawing.Size(252, 23);
            this.lbl_costCenter.TabIndex = 80;
            this.lbl_costCenter.Text = "Cost Center:";
            this.lbl_costCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.33645F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.66355F));
            this.tableLayoutPanel3.Controls.Add(this.date_started, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.date_accepted, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_costCenter, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.lbl_shiftAllowance, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lbl_annualLangAllowance, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lbl_annualBasedSalary, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_approvedSalary, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbl_dateStarted, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_dateAccepted, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_dateApproved, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_relocAllowance, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lbl_relocAllowanceDetails, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.date_approved, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbx_approvedSalary, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbx_annualBasedSalary, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbx_annualLangAllowance, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbx_shiftAllowance, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.tbx_relocAllowance, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.tbx_costCenter, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.tbx_relocAllowanceDetails, 1, 8);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(33, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 234);
            this.tableLayoutPanel3.TabIndex = 56;
            // 
            // lbl_shiftAllowance
            // 
            this.lbl_shiftAllowance.AutoSize = true;
            this.lbl_shiftAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_shiftAllowance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shiftAllowance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_shiftAllowance.ImageIndex = 1;
            this.lbl_shiftAllowance.ImageList = this.imageList;
            this.lbl_shiftAllowance.Location = new System.Drawing.Point(5, 140);
            this.lbl_shiftAllowance.Name = "lbl_shiftAllowance";
            this.lbl_shiftAllowance.Size = new System.Drawing.Size(252, 21);
            this.lbl_shiftAllowance.TabIndex = 49;
            this.lbl_shiftAllowance.Text = "Shift Allowance:";
            this.lbl_shiftAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_annualLangAllowance
            // 
            this.lbl_annualLangAllowance.AutoSize = true;
            this.lbl_annualLangAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_annualLangAllowance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_annualLangAllowance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_annualLangAllowance.ImageIndex = 1;
            this.lbl_annualLangAllowance.ImageList = this.imageList;
            this.lbl_annualLangAllowance.Location = new System.Drawing.Point(5, 117);
            this.lbl_annualLangAllowance.Name = "lbl_annualLangAllowance";
            this.lbl_annualLangAllowance.Size = new System.Drawing.Size(252, 21);
            this.lbl_annualLangAllowance.TabIndex = 42;
            this.lbl_annualLangAllowance.Text = "Annual Language Allowance:";
            this.lbl_annualLangAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_annualBasedSalary
            // 
            this.lbl_annualBasedSalary.AutoSize = true;
            this.lbl_annualBasedSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_annualBasedSalary.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_annualBasedSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_annualBasedSalary.ImageIndex = 1;
            this.lbl_annualBasedSalary.ImageList = this.imageList;
            this.lbl_annualBasedSalary.Location = new System.Drawing.Point(5, 94);
            this.lbl_annualBasedSalary.Name = "lbl_annualBasedSalary";
            this.lbl_annualBasedSalary.Size = new System.Drawing.Size(252, 21);
            this.lbl_annualBasedSalary.TabIndex = 40;
            this.lbl_annualBasedSalary.Text = "Annual-based Salary:";
            this.lbl_annualBasedSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_approvedSalary
            // 
            this.lbl_approvedSalary.AutoSize = true;
            this.lbl_approvedSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_approvedSalary.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_approvedSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_approvedSalary.ImageIndex = 1;
            this.lbl_approvedSalary.ImageList = this.imageList;
            this.lbl_approvedSalary.Location = new System.Drawing.Point(5, 71);
            this.lbl_approvedSalary.Name = "lbl_approvedSalary";
            this.lbl_approvedSalary.Size = new System.Drawing.Size(252, 21);
            this.lbl_approvedSalary.TabIndex = 36;
            this.lbl_approvedSalary.Text = "Approved Salary:";
            this.lbl_approvedSalary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dateStarted
            // 
            this.lbl_dateStarted.AutoSize = true;
            this.lbl_dateStarted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dateStarted.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateStarted.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_dateStarted.ImageIndex = 1;
            this.lbl_dateStarted.ImageList = this.imageList;
            this.lbl_dateStarted.Location = new System.Drawing.Point(5, 48);
            this.lbl_dateStarted.Name = "lbl_dateStarted";
            this.lbl_dateStarted.Size = new System.Drawing.Size(252, 21);
            this.lbl_dateStarted.TabIndex = 34;
            this.lbl_dateStarted.Text = "Date Started:";
            this.lbl_dateStarted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dateAccepted
            // 
            this.lbl_dateAccepted.AutoSize = true;
            this.lbl_dateAccepted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dateAccepted.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateAccepted.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_dateAccepted.ImageIndex = 1;
            this.lbl_dateAccepted.ImageList = this.imageList;
            this.lbl_dateAccepted.Location = new System.Drawing.Point(5, 25);
            this.lbl_dateAccepted.Name = "lbl_dateAccepted";
            this.lbl_dateAccepted.Size = new System.Drawing.Size(252, 21);
            this.lbl_dateAccepted.TabIndex = 32;
            this.lbl_dateAccepted.Text = "Date Accepted:";
            this.lbl_dateAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_dateApproved
            // 
            this.lbl_dateApproved.AutoSize = true;
            this.lbl_dateApproved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dateApproved.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateApproved.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_dateApproved.ImageIndex = 1;
            this.lbl_dateApproved.ImageList = this.imageList;
            this.lbl_dateApproved.Location = new System.Drawing.Point(5, 2);
            this.lbl_dateApproved.Name = "lbl_dateApproved";
            this.lbl_dateApproved.Size = new System.Drawing.Size(252, 21);
            this.lbl_dateApproved.TabIndex = 30;
            this.lbl_dateApproved.Text = "Date Approved:";
            this.lbl_dateApproved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_approvedSalary
            // 
            this.tbx_approvedSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_approvedSalary.Location = new System.Drawing.Point(262, 71);
            this.tbx_approvedSalary.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_approvedSalary.Name = "tbx_approvedSalary";
            this.tbx_approvedSalary.Size = new System.Drawing.Size(235, 22);
            this.tbx_approvedSalary.TabIndex = 90;
            this.tbx_approvedSalary.TextInputType = Presentation.Miscellaneous.CustomTextbox.InputType.Decimals;
            // 
            // tbx_annualBasedSalary
            // 
            this.tbx_annualBasedSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_annualBasedSalary.Location = new System.Drawing.Point(262, 94);
            this.tbx_annualBasedSalary.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_annualBasedSalary.Name = "tbx_annualBasedSalary";
            this.tbx_annualBasedSalary.Size = new System.Drawing.Size(235, 22);
            this.tbx_annualBasedSalary.TabIndex = 91;
            this.tbx_annualBasedSalary.TextInputType = Presentation.Miscellaneous.CustomTextbox.InputType.Decimals;
            // 
            // tbx_annualLangAllowance
            // 
            this.tbx_annualLangAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_annualLangAllowance.Location = new System.Drawing.Point(262, 117);
            this.tbx_annualLangAllowance.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_annualLangAllowance.Name = "tbx_annualLangAllowance";
            this.tbx_annualLangAllowance.Size = new System.Drawing.Size(235, 22);
            this.tbx_annualLangAllowance.TabIndex = 92;
            this.tbx_annualLangAllowance.TextInputType = Presentation.Miscellaneous.CustomTextbox.InputType.Decimals;
            // 
            // tbx_shiftAllowance
            // 
            this.tbx_shiftAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_shiftAllowance.Location = new System.Drawing.Point(262, 140);
            this.tbx_shiftAllowance.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_shiftAllowance.Name = "tbx_shiftAllowance";
            this.tbx_shiftAllowance.Size = new System.Drawing.Size(235, 22);
            this.tbx_shiftAllowance.TabIndex = 93;
            this.tbx_shiftAllowance.TextInputType = Presentation.Miscellaneous.CustomTextbox.InputType.Decimals;
            // 
            // tbx_relocAllowance
            // 
            this.tbx_relocAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_relocAllowance.Location = new System.Drawing.Point(262, 163);
            this.tbx_relocAllowance.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_relocAllowance.Name = "tbx_relocAllowance";
            this.tbx_relocAllowance.Size = new System.Drawing.Size(235, 22);
            this.tbx_relocAllowance.TabIndex = 94;
            this.tbx_relocAllowance.TextInputType = Presentation.Miscellaneous.CustomTextbox.InputType.Decimals;
            // 
            // tbx_costCenter
            // 
            this.tbx_costCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_costCenter.Location = new System.Drawing.Point(262, 209);
            this.tbx_costCenter.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_costCenter.Name = "tbx_costCenter";
            this.tbx_costCenter.Size = new System.Drawing.Size(235, 22);
            this.tbx_costCenter.TabIndex = 96;
            this.tbx_costCenter.TextInputType = Presentation.Miscellaneous.CustomTextbox.InputType.Numbers;
            // 
            // tbx_relocAllowanceDetails
            // 
            this.tbx_relocAllowanceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_relocAllowanceDetails.Location = new System.Drawing.Point(262, 186);
            this.tbx_relocAllowanceDetails.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_relocAllowanceDetails.Name = "tbx_relocAllowanceDetails";
            this.tbx_relocAllowanceDetails.Size = new System.Drawing.Size(235, 22);
            this.tbx_relocAllowanceDetails.TabIndex = 97;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 303);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary Info";
            // 
            // gbx_employeeDetails
            // 
            this.gbx_employeeDetails.Controls.Add(this.tableLayoutPanel1);
            this.gbx_employeeDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbx_employeeDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_employeeDetails.Location = new System.Drawing.Point(12, 12);
            this.gbx_employeeDetails.Name = "gbx_employeeDetails";
            this.gbx_employeeDetails.Size = new System.Drawing.Size(563, 103);
            this.gbx_employeeDetails.TabIndex = 57;
            this.gbx_employeeDetails.TabStop = false;
            this.gbx_employeeDetails.Text = "Employee Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.52525F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.47475F));
            this.tableLayoutPanel1.Controls.Add(this.cbx_contract, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_team, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_contractType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbx_team, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(497, 49);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbx_contract
            // 
            this.cbx_contract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_contract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_contract.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_contract.FormattingEnabled = true;
            this.cbx_contract.Items.AddRange(new object[] {
            "yes",
            "no",
            "maybe"});
            this.cbx_contract.Location = new System.Drawing.Point(261, 25);
            this.cbx_contract.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_contract.Name = "cbx_contract";
            this.cbx_contract.Size = new System.Drawing.Size(234, 21);
            this.cbx_contract.TabIndex = 62;
            this.cbx_contract.SelectedIndexChanged += new System.EventHandler(this.cbx_contract_SelectedIndexChanged);
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_team.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_team.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_team.ImageIndex = 1;
            this.lbl_team.ImageList = this.imageList;
            this.lbl_team.Location = new System.Drawing.Point(5, 2);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(251, 21);
            this.lbl_team.TabIndex = 52;
            this.lbl_team.Text = "Team:";
            this.lbl_team.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_contractType
            // 
            this.lbl_contractType.AutoSize = true;
            this.lbl_contractType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_contractType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contractType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_contractType.ImageIndex = 1;
            this.lbl_contractType.ImageList = this.imageList;
            this.lbl_contractType.Location = new System.Drawing.Point(5, 25);
            this.lbl_contractType.Name = "lbl_contractType";
            this.lbl_contractType.Size = new System.Drawing.Size(251, 22);
            this.lbl_contractType.TabIndex = 53;
            this.lbl_contractType.Text = "Contract Type:";
            this.lbl_contractType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx_team
            // 
            this.cbx_team.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_team.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_team.FormattingEnabled = true;
            this.cbx_team.Items.AddRange(new object[] {
            "yes",
            "no",
            "maybe"});
            this.cbx_team.Location = new System.Drawing.Point(261, 2);
            this.cbx_team.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_team.Name = "cbx_team";
            this.cbx_team.Size = new System.Drawing.Size(234, 21);
            this.cbx_team.TabIndex = 61;
            this.cbx_team.SelectedIndexChanged += new System.EventHandler(this.cbx_team_SelectedIndexChanged);
            // 
            // ControlEmployeeDetailsAndSalaryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_employeeDetails);
            this.Controls.Add(this.panel2);
            this.Name = "ControlEmployeeDetailsAndSalaryInfo";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(587, 521);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbx_employeeDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_annualLangAllowance;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lbl_annualBasedSalary;
        private System.Windows.Forms.Label lbl_approvedSalary;
        private System.Windows.Forms.Label lbl_dateStarted;
        private System.Windows.Forms.Label lbl_dateAccepted;
        private System.Windows.Forms.Label lbl_dateApproved;
        private System.Windows.Forms.Label lbl_relocAllowance;
        private System.Windows.Forms.Label lbl_relocAllowanceDetails;
        private System.Windows.Forms.DateTimePicker date_approved;
        private System.Windows.Forms.DateTimePicker date_started;
        private System.Windows.Forms.DateTimePicker date_accepted;
        private System.Windows.Forms.Label lbl_costCenter;
        private System.Windows.Forms.Label lbl_shiftAllowance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbx_employeeDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbx_contract;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_contractType;
        private System.Windows.Forms.ComboBox cbx_team;
        private System.Windows.Forms.Button btn_save;
        private Presentation.Miscellaneous.CustomTextbox tbx_approvedSalary;
        private Presentation.Miscellaneous.CustomTextbox tbx_annualBasedSalary;
        private Presentation.Miscellaneous.CustomTextbox tbx_annualLangAllowance;
        private Presentation.Miscellaneous.CustomTextbox tbx_shiftAllowance;
        private Presentation.Miscellaneous.CustomTextbox tbx_relocAllowance;
        private Presentation.Miscellaneous.CustomTextbox tbx_costCenter;
        private System.Windows.Forms.TextBox tbx_relocAllowanceDetails;
    }
}
