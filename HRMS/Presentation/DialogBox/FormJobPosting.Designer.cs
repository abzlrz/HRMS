namespace Presentation.DialogBox
{
    partial class FormJobPosting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJobPosting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.date_add_close = new System.Windows.Forms.DateTimePicker();
            this.link_add_jobdesc = new System.Windows.Forms.LinkLabel();
            this.tbx_add_headcount = new System.Windows.Forms.TextBox();
            this.tbx_add_wage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbx_add_positiontype = new System.Windows.Forms.TextBox();
            this.link_add_qualification = new System.Windows.Forms.LinkLabel();
            this.cbx_add_location = new System.Windows.Forms.ComboBox();
            this.date_add_posted = new System.Windows.Forms.DateTimePicker();
            this.tbx_add_comment = new System.Windows.Forms.TextBox();
            this.cbx_add_position = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.date_edit_close = new System.Windows.Forms.DateTimePicker();
            this.link_edit_jobdesc = new System.Windows.Forms.LinkLabel();
            this.tbx_edit_headcount = new System.Windows.Forms.TextBox();
            this.tbx_edit_wage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbx_edit_positiontype = new System.Windows.Forms.TextBox();
            this.link_edit_qualification = new System.Windows.Forms.LinkLabel();
            this.cbx_edit_location = new System.Windows.Forms.ComboBox();
            this.date_edit_posted = new System.Windows.Forms.DateTimePicker();
            this.tbx_edit_comment = new System.Windows.Forms.TextBox();
            this.tbx_edit_position = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.view_posting = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_posting)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 478);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(336, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.29032F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.70968F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.date_add_close, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.link_add_jobdesc, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbx_add_headcount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbx_add_wage, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tbx_add_positiontype, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.link_add_qualification, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbx_add_location, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.date_add_posted, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbx_add_comment, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cbx_add_position, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 350);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 98);
            this.label2.TabIndex = 21;
            this.label2.Text = "\r\nComments:";
            // 
            // date_add_close
            // 
            this.date_add_close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.date_add_close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_add_close.Location = new System.Drawing.Point(127, 90);
            this.date_add_close.Margin = new System.Windows.Forms.Padding(0);
            this.date_add_close.Name = "date_add_close";
            this.date_add_close.Size = new System.Drawing.Size(183, 22);
            this.date_add_close.TabIndex = 3;
            // 
            // link_add_jobdesc
            // 
            this.link_add_jobdesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.link_add_jobdesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.link_add_jobdesc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_add_jobdesc.Location = new System.Drawing.Point(127, 227);
            this.link_add_jobdesc.Margin = new System.Windows.Forms.Padding(0);
            this.link_add_jobdesc.Name = "link_add_jobdesc";
            this.link_add_jobdesc.Size = new System.Drawing.Size(183, 25);
            this.link_add_jobdesc.TabIndex = 9;
            this.link_add_jobdesc.TabStop = true;
            this.link_add_jobdesc.Text = "Upload";
            this.link_add_jobdesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_add_headcount
            // 
            this.tbx_add_headcount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_add_headcount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_headcount.Location = new System.Drawing.Point(127, 146);
            this.tbx_add_headcount.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_headcount.Name = "tbx_add_headcount";
            this.tbx_add_headcount.Size = new System.Drawing.Size(183, 22);
            this.tbx_add_headcount.TabIndex = 6;
            // 
            // tbx_add_wage
            // 
            this.tbx_add_wage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_add_wage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_wage.Location = new System.Drawing.Point(127, 118);
            this.tbx_add_wage.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_wage.Name = "tbx_add_wage";
            this.tbx_add_wage.Size = new System.Drawing.Size(183, 22);
            this.tbx_add_wage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.ImageIndex = 1;
            this.label3.ImageList = this.imageList;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position Type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.ImageIndex = 1;
            this.label4.ImageList = this.imageList;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Position:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Posted Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Close Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Wage:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.ImageIndex = 1;
            this.label8.ImageList = this.imageList;
            this.label8.Location = new System.Drawing.Point(3, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Head Count:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.ImageIndex = 1;
            this.label9.ImageList = this.imageList;
            this.label9.Location = new System.Drawing.Point(3, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Location:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.ImageIndex = 1;
            this.label10.ImageList = this.imageList;
            this.label10.Location = new System.Drawing.Point(3, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Qualification:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.ImageIndex = 1;
            this.label20.ImageList = this.imageList;
            this.label20.Location = new System.Drawing.Point(3, 224);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(121, 28);
            this.label20.TabIndex = 8;
            this.label20.Text = "Job Description:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_add_positiontype
            // 
            this.tbx_add_positiontype.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_add_positiontype.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_add_positiontype.Location = new System.Drawing.Point(127, 6);
            this.tbx_add_positiontype.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_positiontype.Name = "tbx_add_positiontype";
            this.tbx_add_positiontype.Size = new System.Drawing.Size(183, 22);
            this.tbx_add_positiontype.TabIndex = 0;
            // 
            // link_add_qualification
            // 
            this.link_add_qualification.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.link_add_qualification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.link_add_qualification.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_add_qualification.Location = new System.Drawing.Point(127, 199);
            this.link_add_qualification.Margin = new System.Windows.Forms.Padding(0);
            this.link_add_qualification.Name = "link_add_qualification";
            this.link_add_qualification.Size = new System.Drawing.Size(183, 25);
            this.link_add_qualification.TabIndex = 8;
            this.link_add_qualification.TabStop = true;
            this.link_add_qualification.Text = "Upload";
            this.link_add_qualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_add_location
            // 
            this.cbx_add_location.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbx_add_location.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_add_location.FormattingEnabled = true;
            this.cbx_add_location.Location = new System.Drawing.Point(127, 175);
            this.cbx_add_location.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_add_location.Name = "cbx_add_location";
            this.cbx_add_location.Size = new System.Drawing.Size(183, 21);
            this.cbx_add_location.TabIndex = 7;
            // 
            // date_add_posted
            // 
            this.date_add_posted.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.date_add_posted.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_add_posted.Location = new System.Drawing.Point(127, 62);
            this.date_add_posted.Margin = new System.Windows.Forms.Padding(0);
            this.date_add_posted.Name = "date_add_posted";
            this.date_add_posted.Size = new System.Drawing.Size(183, 22);
            this.date_add_posted.TabIndex = 2;
            // 
            // tbx_add_comment
            // 
            this.tbx_add_comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_add_comment.Location = new System.Drawing.Point(127, 264);
            this.tbx_add_comment.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_add_comment.Multiline = true;
            this.tbx_add_comment.Name = "tbx_add_comment";
            this.tbx_add_comment.Size = new System.Drawing.Size(183, 86);
            this.tbx_add_comment.TabIndex = 10;
            // 
            // cbx_add_position
            // 
            this.cbx_add_position.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbx_add_position.FormattingEnabled = true;
            this.cbx_add_position.Location = new System.Drawing.Point(127, 33);
            this.cbx_add_position.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_add_position.Name = "cbx_add_position";
            this.cbx_add_position.Size = new System.Drawing.Size(183, 23);
            this.cbx_add_position.TabIndex = 1;
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
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.29032F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.70968F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.date_edit_close, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.link_edit_jobdesc, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.tbx_edit_headcount, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbx_edit_wage, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tbx_edit_positiontype, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.link_edit_qualification, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.cbx_edit_location, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.date_edit_posted, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbx_edit_comment, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.tbx_edit_position, 1, 1);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 350);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 98);
            this.label11.TabIndex = 21;
            this.label11.Text = "\r\nComments:";
            // 
            // date_edit_close
            // 
            this.date_edit_close.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.date_edit_close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_edit_close.Location = new System.Drawing.Point(127, 90);
            this.date_edit_close.Margin = new System.Windows.Forms.Padding(0);
            this.date_edit_close.Name = "date_edit_close";
            this.date_edit_close.Size = new System.Drawing.Size(183, 22);
            this.date_edit_close.TabIndex = 3;
            // 
            // link_edit_jobdesc
            // 
            this.link_edit_jobdesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.link_edit_jobdesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.link_edit_jobdesc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_edit_jobdesc.Location = new System.Drawing.Point(127, 227);
            this.link_edit_jobdesc.Margin = new System.Windows.Forms.Padding(0);
            this.link_edit_jobdesc.Name = "link_edit_jobdesc";
            this.link_edit_jobdesc.Size = new System.Drawing.Size(183, 25);
            this.link_edit_jobdesc.TabIndex = 9;
            this.link_edit_jobdesc.TabStop = true;
            this.link_edit_jobdesc.Text = "Upload";
            this.link_edit_jobdesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_edit_headcount
            // 
            this.tbx_edit_headcount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_edit_headcount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_headcount.Location = new System.Drawing.Point(127, 146);
            this.tbx_edit_headcount.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_headcount.Name = "tbx_edit_headcount";
            this.tbx_edit_headcount.Size = new System.Drawing.Size(183, 22);
            this.tbx_edit_headcount.TabIndex = 6;
            // 
            // tbx_edit_wage
            // 
            this.tbx_edit_wage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_edit_wage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_wage.Location = new System.Drawing.Point(127, 118);
            this.tbx_edit_wage.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_wage.Name = "tbx_edit_wage";
            this.tbx_edit_wage.Size = new System.Drawing.Size(183, 22);
            this.tbx_edit_wage.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.ImageIndex = 1;
            this.label12.ImageList = this.imageList;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Position Type:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.ImageIndex = 1;
            this.label13.ImageList = this.imageList;
            this.label13.Location = new System.Drawing.Point(3, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 28);
            this.label13.TabIndex = 1;
            this.label13.Text = "Position:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 28);
            this.label14.TabIndex = 2;
            this.label14.Text = "Posted Date:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 28);
            this.label15.TabIndex = 3;
            this.label15.Text = "Close Date:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 28);
            this.label16.TabIndex = 4;
            this.label16.Text = "Wage:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.ImageIndex = 1;
            this.label17.ImageList = this.imageList;
            this.label17.Location = new System.Drawing.Point(3, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 28);
            this.label17.TabIndex = 5;
            this.label17.Text = "Head Count:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.ImageIndex = 1;
            this.label18.ImageList = this.imageList;
            this.label18.Location = new System.Drawing.Point(3, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 28);
            this.label18.TabIndex = 6;
            this.label18.Text = "Location:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.ImageIndex = 1;
            this.label19.ImageList = this.imageList;
            this.label19.Location = new System.Drawing.Point(3, 196);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 28);
            this.label19.TabIndex = 7;
            this.label19.Text = "Qualification:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label21.ImageIndex = 1;
            this.label21.ImageList = this.imageList;
            this.label21.Location = new System.Drawing.Point(3, 224);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 28);
            this.label21.TabIndex = 8;
            this.label21.Text = "Job Description:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_edit_positiontype
            // 
            this.tbx_edit_positiontype.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_edit_positiontype.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_edit_positiontype.Location = new System.Drawing.Point(127, 6);
            this.tbx_edit_positiontype.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_positiontype.Name = "tbx_edit_positiontype";
            this.tbx_edit_positiontype.Size = new System.Drawing.Size(183, 22);
            this.tbx_edit_positiontype.TabIndex = 0;
            // 
            // link_edit_qualification
            // 
            this.link_edit_qualification.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.link_edit_qualification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.link_edit_qualification.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_edit_qualification.Location = new System.Drawing.Point(127, 199);
            this.link_edit_qualification.Margin = new System.Windows.Forms.Padding(0);
            this.link_edit_qualification.Name = "link_edit_qualification";
            this.link_edit_qualification.Size = new System.Drawing.Size(183, 25);
            this.link_edit_qualification.TabIndex = 8;
            this.link_edit_qualification.TabStop = true;
            this.link_edit_qualification.Text = "Upload";
            this.link_edit_qualification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_edit_location
            // 
            this.cbx_edit_location.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbx_edit_location.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_edit_location.FormattingEnabled = true;
            this.cbx_edit_location.Location = new System.Drawing.Point(127, 175);
            this.cbx_edit_location.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_edit_location.Name = "cbx_edit_location";
            this.cbx_edit_location.Size = new System.Drawing.Size(183, 21);
            this.cbx_edit_location.TabIndex = 7;
            // 
            // date_edit_posted
            // 
            this.date_edit_posted.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.date_edit_posted.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_edit_posted.Location = new System.Drawing.Point(127, 62);
            this.date_edit_posted.Margin = new System.Windows.Forms.Padding(0);
            this.date_edit_posted.Name = "date_edit_posted";
            this.date_edit_posted.Size = new System.Drawing.Size(183, 22);
            this.date_edit_posted.TabIndex = 2;
            // 
            // tbx_edit_comment
            // 
            this.tbx_edit_comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_edit_comment.Location = new System.Drawing.Point(127, 264);
            this.tbx_edit_comment.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_comment.Multiline = true;
            this.tbx_edit_comment.Name = "tbx_edit_comment";
            this.tbx_edit_comment.Size = new System.Drawing.Size(183, 86);
            this.tbx_edit_comment.TabIndex = 10;
            // 
            // tbx_edit_position
            // 
            this.tbx_edit_position.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbx_edit_position.FormattingEnabled = true;
            this.tbx_edit_position.Location = new System.Drawing.Point(127, 35);
            this.tbx_edit_position.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_edit_position.Name = "tbx_edit_position";
            this.tbx_edit_position.Size = new System.Drawing.Size(183, 23);
            this.tbx_edit_position.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(356, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel1.Size = new System.Drawing.Size(491, 478);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbxSearchBy);
            this.panel2.Controls.Add(this.tbx_search);
            this.panel2.Controls.Add(this.view_posting);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 468);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(218, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Search Job Postings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "Firstname",
            "Middlename",
            "Lastname",
            "Address"});
            this.cbxSearchBy.Location = new System.Drawing.Point(299, 46);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(156, 21);
            this.cbxSearchBy.TabIndex = 1;
            // 
            // tbx_search
            // 
            this.tbx_search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbx_search.Location = new System.Drawing.Point(13, 47);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(280, 20);
            this.tbx_search.TabIndex = 0;
            // 
            // view_posting
            // 
            this.view_posting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_posting.Location = new System.Drawing.Point(13, 73);
            this.view_posting.Name = "view_posting";
            this.view_posting.Size = new System.Drawing.Size(442, 348);
            this.view_posting.TabIndex = 2;
            // 
            // FormJobPosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(859, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJobPosting";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Job Posting";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_posting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.DataGridView view_posting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker date_edit_close;
        private System.Windows.Forms.LinkLabel link_edit_jobdesc;
        private System.Windows.Forms.TextBox tbx_edit_headcount;
        private System.Windows.Forms.TextBox tbx_edit_wage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbx_edit_positiontype;
        private System.Windows.Forms.LinkLabel link_edit_qualification;
        private System.Windows.Forms.ComboBox cbx_edit_location;
        private System.Windows.Forms.DateTimePicker date_edit_posted;
        private System.Windows.Forms.TextBox tbx_edit_comment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_add_close;
        private System.Windows.Forms.LinkLabel link_add_jobdesc;
        private System.Windows.Forms.TextBox tbx_add_headcount;
        private System.Windows.Forms.TextBox tbx_add_wage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbx_add_positiontype;
        private System.Windows.Forms.LinkLabel link_add_qualification;
        private System.Windows.Forms.ComboBox cbx_add_location;
        private System.Windows.Forms.DateTimePicker date_add_posted;
        private System.Windows.Forms.TextBox tbx_add_comment;
        private System.Windows.Forms.ComboBox cbx_add_position;
        private System.Windows.Forms.ComboBox tbx_edit_position;
        private System.Windows.Forms.ImageList imageList;
    }
}