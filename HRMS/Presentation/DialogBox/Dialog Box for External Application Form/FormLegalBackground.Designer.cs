namespace Presentation.DialogBox.ExternalApplicationForm
{
    partial class FormLegalBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLegalBackground));
            this.confirmationLegalConviction = new System.Windows.Forms.Panel();
            this.rd_noConvicted = new System.Windows.Forms.RadioButton();
            this.rd_yesConvicted = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_noLawsuited = new System.Windows.Forms.RadioButton();
            this.legalCasePanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_case = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_case = new System.Windows.Forms.TextBox();
            this.tbx_detailCase = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rd_yesLawsuited = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmationLegalCase = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_conviction = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tbx_conviction = new System.Windows.Forms.TextBox();
            this.tbx_detailsConvicted = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.convictionPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.confirmationLegalConviction.SuspendLayout();
            this.legalCasePanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.confirmationLegalCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.convictionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmationLegalConviction
            // 
            this.confirmationLegalConviction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(186)))));
            this.confirmationLegalConviction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmationLegalConviction.Controls.Add(this.rd_noConvicted);
            this.confirmationLegalConviction.Controls.Add(this.rd_yesConvicted);
            this.confirmationLegalConviction.Controls.Add(this.label1);
            this.confirmationLegalConviction.Dock = System.Windows.Forms.DockStyle.Top;
            this.confirmationLegalConviction.Location = new System.Drawing.Point(0, 0);
            this.confirmationLegalConviction.Name = "confirmationLegalConviction";
            this.confirmationLegalConviction.Size = new System.Drawing.Size(590, 47);
            this.confirmationLegalConviction.TabIndex = 10;
            // 
            // rd_noConvicted
            // 
            this.rd_noConvicted.AutoSize = true;
            this.rd_noConvicted.Checked = true;
            this.rd_noConvicted.Location = new System.Drawing.Point(380, 12);
            this.rd_noConvicted.Name = "rd_noConvicted";
            this.rd_noConvicted.Size = new System.Drawing.Size(39, 17);
            this.rd_noConvicted.TabIndex = 2;
            this.rd_noConvicted.TabStop = true;
            this.rd_noConvicted.Text = "No";
            this.rd_noConvicted.UseVisualStyleBackColor = true;
            this.rd_noConvicted.CheckedChanged += new System.EventHandler(this.rd_noConvicted_CheckedChanged);
            // 
            // rd_yesConvicted
            // 
            this.rd_yesConvicted.AutoSize = true;
            this.rd_yesConvicted.Location = new System.Drawing.Point(289, 12);
            this.rd_yesConvicted.Name = "rd_yesConvicted";
            this.rd_yesConvicted.Size = new System.Drawing.Size(43, 17);
            this.rd_yesConvicted.TabIndex = 1;
            this.rd_yesConvicted.Text = "Yes";
            this.rd_yesConvicted.UseVisualStyleBackColor = true;
            this.rd_yesConvicted.CheckedChanged += new System.EventHandler(this.rd_yesConvicted_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you convicted of any crime?";
            // 
            // rd_noLawsuited
            // 
            this.rd_noLawsuited.AutoSize = true;
            this.rd_noLawsuited.Checked = true;
            this.rd_noLawsuited.Location = new System.Drawing.Point(380, 12);
            this.rd_noLawsuited.Name = "rd_noLawsuited";
            this.rd_noLawsuited.Size = new System.Drawing.Size(39, 17);
            this.rd_noLawsuited.TabIndex = 2;
            this.rd_noLawsuited.TabStop = true;
            this.rd_noLawsuited.Text = "No";
            this.rd_noLawsuited.UseVisualStyleBackColor = true;
            this.rd_noLawsuited.CheckedChanged += new System.EventHandler(this.rd_noLawsuited_CheckedChanged);
            // 
            // legalCasePanel
            // 
            this.legalCasePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.legalCasePanel.Controls.Add(this.panel8);
            this.legalCasePanel.Controls.Add(this.panel6);
            this.legalCasePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.legalCasePanel.Enabled = false;
            this.legalCasePanel.Location = new System.Drawing.Point(0, 303);
            this.legalCasePanel.Name = "legalCasePanel";
            this.legalCasePanel.Size = new System.Drawing.Size(590, 200);
            this.legalCasePanel.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.tableLayoutPanel1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(196, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(390, 196);
            this.panel8.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(282, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(120, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(201, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.67706F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.32294F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_case, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbx_case, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbx_detailCase, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 34);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 82);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_case
            // 
            this.lbl_case.AutoSize = true;
            this.lbl_case.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_case.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_case.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_case.ImageList = this.imageList;
            this.lbl_case.Location = new System.Drawing.Point(3, 0);
            this.lbl_case.Name = "lbl_case";
            this.lbl_case.Size = new System.Drawing.Size(127, 32);
            this.lbl_case.TabIndex = 51;
            this.lbl_case.Text = "Legal Case:";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "green_dot.png");
            this.imageList.Images.SetKeyName(1, "red_dot.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 50);
            this.label4.TabIndex = 52;
            this.label4.Text = "Details:";
            // 
            // tbx_case
            // 
            this.tbx_case.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_case.Location = new System.Drawing.Point(133, 0);
            this.tbx_case.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_case.Name = "tbx_case";
            this.tbx_case.Size = new System.Drawing.Size(220, 22);
            this.tbx_case.TabIndex = 108;
            this.tbx_case.Tag = "required";
            this.tbx_case.TextChanged += new System.EventHandler(this.tbx_case_TextChanged);
            // 
            // tbx_detailCase
            // 
            this.tbx_detailCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_detailCase.Location = new System.Drawing.Point(133, 32);
            this.tbx_detailCase.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_detailCase.Multiline = true;
            this.tbx_detailCase.Name = "tbx_detailCase";
            this.tbx_detailCase.Size = new System.Drawing.Size(220, 50);
            this.tbx_detailCase.TabIndex = 109;
            this.tbx_detailCase.Tag = "required";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(196, 196);
            this.panel6.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(5, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(186, 186);
            this.dataGridView2.TabIndex = 4;
            // 
            // rd_yesLawsuited
            // 
            this.rd_yesLawsuited.AutoSize = true;
            this.rd_yesLawsuited.Location = new System.Drawing.Point(289, 12);
            this.rd_yesLawsuited.Name = "rd_yesLawsuited";
            this.rd_yesLawsuited.Size = new System.Drawing.Size(43, 17);
            this.rd_yesLawsuited.TabIndex = 1;
            this.rd_yesLawsuited.Text = "Yes";
            this.rd_yesLawsuited.UseVisualStyleBackColor = true;
            this.rd_yesLawsuited.CheckedChanged += new System.EventHandler(this.rd_yesLawsuited_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Are you charged of any legal case?";
            // 
            // confirmationLegalCase
            // 
            this.confirmationLegalCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(186)))));
            this.confirmationLegalCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmationLegalCase.Controls.Add(this.rd_noLawsuited);
            this.confirmationLegalCase.Controls.Add(this.rd_yesLawsuited);
            this.confirmationLegalCase.Controls.Add(this.label2);
            this.confirmationLegalCase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.confirmationLegalCase.Location = new System.Drawing.Point(0, 256);
            this.confirmationLegalCase.Name = "confirmationLegalCase";
            this.confirmationLegalCase.Size = new System.Drawing.Size(590, 47);
            this.confirmationLegalCase.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(186, 195);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(196, 205);
            this.panel3.TabIndex = 7;
            // 
            // lbl_conviction
            // 
            this.lbl_conviction.AutoSize = true;
            this.lbl_conviction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_conviction.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conviction.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_conviction.ImageList = this.imageList;
            this.lbl_conviction.Location = new System.Drawing.Point(3, 0);
            this.lbl_conviction.Name = "lbl_conviction";
            this.lbl_conviction.Size = new System.Drawing.Size(127, 30);
            this.lbl_conviction.TabIndex = 51;
            this.lbl_conviction.Text = "Conviction:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 30);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(127, 52);
            this.label32.TabIndex = 52;
            this.label32.Text = "Details:";
            // 
            // tbx_conviction
            // 
            this.tbx_conviction.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_conviction.Location = new System.Drawing.Point(133, 0);
            this.tbx_conviction.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_conviction.Name = "tbx_conviction";
            this.tbx_conviction.Size = new System.Drawing.Size(220, 22);
            this.tbx_conviction.TabIndex = 108;
            this.tbx_conviction.Tag = "required";
            this.tbx_conviction.TextChanged += new System.EventHandler(this.tbx_conviction_TextChanged);
            // 
            // tbx_detailsConvicted
            // 
            this.tbx_detailsConvicted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_detailsConvicted.Location = new System.Drawing.Point(133, 30);
            this.tbx_detailsConvicted.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_detailsConvicted.Multiline = true;
            this.tbx_detailsConvicted.Name = "tbx_detailsConvicted";
            this.tbx_detailsConvicted.Size = new System.Drawing.Size(220, 52);
            this.tbx_detailsConvicted.TabIndex = 109;
            this.tbx_detailsConvicted.Tag = "required";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(282, 133);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(120, 133);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Green;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(201, 133);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Save";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.67706F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.32294F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_conviction, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label32, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tbx_conviction, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbx_detailsConvicted, 1, 1);
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 34);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(353, 82);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.btn_add);
            this.panel4.Controls.Add(this.btn_edit);
            this.panel4.Controls.Add(this.tableLayoutPanel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(196, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 205);
            this.panel4.TabIndex = 8;
            // 
            // convictionPanel
            // 
            this.convictionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convictionPanel.Controls.Add(this.panel4);
            this.convictionPanel.Controls.Add(this.panel3);
            this.convictionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convictionPanel.Enabled = false;
            this.convictionPanel.Location = new System.Drawing.Point(0, 47);
            this.convictionPanel.Name = "convictionPanel";
            this.convictionPanel.Size = new System.Drawing.Size(590, 209);
            this.convictionPanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.convictionPanel);
            this.panel1.Controls.Add(this.confirmationLegalCase);
            this.panel1.Controls.Add(this.confirmationLegalConviction);
            this.panel1.Controls.Add(this.legalCasePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 503);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_ok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(12, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 52);
            this.panel2.TabIndex = 10;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(515, 27);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 25);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(434, 27);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 25);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // FormLegalBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLegalBackground";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Legal Background";
            this.confirmationLegalConviction.ResumeLayout(false);
            this.confirmationLegalConviction.PerformLayout();
            this.legalCasePanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.confirmationLegalCase.ResumeLayout(false);
            this.confirmationLegalCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.convictionPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel confirmationLegalConviction;
        private System.Windows.Forms.RadioButton rd_noConvicted;
        private System.Windows.Forms.RadioButton rd_yesConvicted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_noLawsuited;
        private System.Windows.Forms.Panel legalCasePanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_case;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_case;
        private System.Windows.Forms.TextBox tbx_detailCase;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton rd_yesLawsuited;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel confirmationLegalCase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_conviction;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbx_conviction;
        private System.Windows.Forms.TextBox tbx_detailsConvicted;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel convictionPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}