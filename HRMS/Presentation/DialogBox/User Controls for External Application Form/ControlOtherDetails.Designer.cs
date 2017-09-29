namespace Presentation.DialogBox.ExternalApplication
{
    partial class ControlOtherDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlOtherDetails));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_workExp = new System.Windows.Forms.ComboBox();
            this.lbl_workExp = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lbl_contactPerson = new System.Windows.Forms.Label();
            this.lbl_educationBackground = new System.Windows.Forms.Label();
            this.link_education = new System.Windows.Forms.LinkLabel();
            this.lbl_illness = new System.Windows.Forms.Label();
            this.lbl_legal = new System.Windows.Forms.Label();
            this.lbl_employment = new System.Windows.Forms.Label();
            this.link_illness = new System.Windows.Forms.LinkLabel();
            this.link_legal = new System.Windows.Forms.LinkLabel();
            this.link_employment = new System.Windows.Forms.LinkLabel();
            this.link_contacts = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel7);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(617, 400);
            this.groupBox7.TabIndex = 84;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Other Details:";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.42662F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.57338F));
            this.tableLayoutPanel7.Controls.Add(this.cbx_workExp, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.lbl_workExp, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.lbl_contactPerson, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.lbl_educationBackground, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.link_education, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lbl_illness, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lbl_legal, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.lbl_employment, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.link_illness, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.link_legal, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.link_employment, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.link_contacts, 1, 5);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(44, 147);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 6;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(521, 141);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // cbx_workExp
            // 
            this.cbx_workExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_workExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_workExp.FormattingEnabled = true;
            this.cbx_workExp.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbx_workExp.Location = new System.Drawing.Point(392, 71);
            this.cbx_workExp.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_workExp.Name = "cbx_workExp";
            this.cbx_workExp.Size = new System.Drawing.Size(127, 21);
            this.cbx_workExp.TabIndex = 0;
            this.cbx_workExp.SelectedIndexChanged += new System.EventHandler(this.cbx_workExp_SelectedIndexChanged);
            // 
            // lbl_workExp
            // 
            this.lbl_workExp.AutoSize = true;
            this.lbl_workExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_workExp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_workExp.ImageIndex = 1;
            this.lbl_workExp.ImageList = this.imageList;
            this.lbl_workExp.Location = new System.Drawing.Point(5, 71);
            this.lbl_workExp.Name = "lbl_workExp";
            this.lbl_workExp.Size = new System.Drawing.Size(382, 22);
            this.lbl_workExp.TabIndex = 3;
            this.lbl_workExp.Text = "With Work Experience?";
            this.lbl_workExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "green_dot.png");
            this.imageList.Images.SetKeyName(1, "red_dot.png");
            // 
            // lbl_contactPerson
            // 
            this.lbl_contactPerson.AutoSize = true;
            this.lbl_contactPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_contactPerson.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_contactPerson.ImageIndex = 1;
            this.lbl_contactPerson.ImageList = this.imageList;
            this.lbl_contactPerson.Location = new System.Drawing.Point(5, 118);
            this.lbl_contactPerson.Name = "lbl_contactPerson";
            this.lbl_contactPerson.Size = new System.Drawing.Size(382, 21);
            this.lbl_contactPerson.TabIndex = 87;
            this.lbl_contactPerson.Text = "Contact Person (In case of Emergency)";
            this.lbl_contactPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_educationBackground
            // 
            this.lbl_educationBackground.AutoSize = true;
            this.lbl_educationBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_educationBackground.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_educationBackground.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_educationBackground.ImageIndex = 1;
            this.lbl_educationBackground.ImageList = this.imageList;
            this.lbl_educationBackground.Location = new System.Drawing.Point(5, 2);
            this.lbl_educationBackground.Name = "lbl_educationBackground";
            this.lbl_educationBackground.Size = new System.Drawing.Size(382, 21);
            this.lbl_educationBackground.TabIndex = 51;
            this.lbl_educationBackground.Text = "Education Background";
            this.lbl_educationBackground.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // link_education
            // 
            this.link_education.AutoSize = true;
            this.link_education.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_education.Location = new System.Drawing.Point(392, 2);
            this.link_education.Margin = new System.Windows.Forms.Padding(0);
            this.link_education.Name = "link_education";
            this.link_education.Size = new System.Drawing.Size(127, 21);
            this.link_education.TabIndex = 82;
            this.link_education.TabStop = true;
            this.link_education.Text = "Open";
            this.link_education.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_education.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_education_LinkClicked);
            // 
            // lbl_illness
            // 
            this.lbl_illness.AutoSize = true;
            this.lbl_illness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_illness.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_illness.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_illness.ImageIndex = 1;
            this.lbl_illness.ImageList = this.imageList;
            this.lbl_illness.Location = new System.Drawing.Point(5, 25);
            this.lbl_illness.Name = "lbl_illness";
            this.lbl_illness.Size = new System.Drawing.Size(382, 21);
            this.lbl_illness.TabIndex = 84;
            this.lbl_illness.Text = "History of Illness";
            this.lbl_illness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_legal
            // 
            this.lbl_legal.AutoSize = true;
            this.lbl_legal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_legal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_legal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_legal.ImageIndex = 1;
            this.lbl_legal.ImageList = this.imageList;
            this.lbl_legal.Location = new System.Drawing.Point(5, 48);
            this.lbl_legal.Name = "lbl_legal";
            this.lbl_legal.Size = new System.Drawing.Size(382, 21);
            this.lbl_legal.TabIndex = 85;
            this.lbl_legal.Text = "Legal History";
            this.lbl_legal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_employment
            // 
            this.lbl_employment.AutoSize = true;
            this.lbl_employment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_employment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_employment.ImageList = this.imageList;
            this.lbl_employment.Location = new System.Drawing.Point(5, 95);
            this.lbl_employment.Name = "lbl_employment";
            this.lbl_employment.Size = new System.Drawing.Size(382, 21);
            this.lbl_employment.TabIndex = 86;
            this.lbl_employment.Text = "    Employment History";
            this.lbl_employment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // link_illness
            // 
            this.link_illness.AutoSize = true;
            this.link_illness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_illness.Location = new System.Drawing.Point(392, 25);
            this.link_illness.Margin = new System.Windows.Forms.Padding(0);
            this.link_illness.Name = "link_illness";
            this.link_illness.Size = new System.Drawing.Size(127, 21);
            this.link_illness.TabIndex = 88;
            this.link_illness.TabStop = true;
            this.link_illness.Text = "Open";
            this.link_illness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_illness.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_illness_LinkClicked);
            // 
            // link_legal
            // 
            this.link_legal.AutoSize = true;
            this.link_legal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_legal.Location = new System.Drawing.Point(392, 48);
            this.link_legal.Margin = new System.Windows.Forms.Padding(0);
            this.link_legal.Name = "link_legal";
            this.link_legal.Size = new System.Drawing.Size(127, 21);
            this.link_legal.TabIndex = 89;
            this.link_legal.TabStop = true;
            this.link_legal.Text = "Open";
            this.link_legal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_legal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_legal_LinkClicked);
            // 
            // link_employment
            // 
            this.link_employment.AutoSize = true;
            this.link_employment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_employment.Location = new System.Drawing.Point(392, 95);
            this.link_employment.Margin = new System.Windows.Forms.Padding(0);
            this.link_employment.Name = "link_employment";
            this.link_employment.Size = new System.Drawing.Size(127, 21);
            this.link_employment.TabIndex = 90;
            this.link_employment.TabStop = true;
            this.link_employment.Text = "Open";
            this.link_employment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_employment.Visible = false;
            this.link_employment.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_employment_LinkClicked);
            // 
            // link_contacts
            // 
            this.link_contacts.AutoSize = true;
            this.link_contacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.link_contacts.Location = new System.Drawing.Point(392, 118);
            this.link_contacts.Margin = new System.Windows.Forms.Padding(0);
            this.link_contacts.Name = "link_contacts";
            this.link_contacts.Size = new System.Drawing.Size(127, 21);
            this.link_contacts.TabIndex = 91;
            this.link_contacts.TabStop = true;
            this.link_contacts.Text = "Open";
            this.link_contacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_contacts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_contacts_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_previous);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(12, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 91);
            this.panel2.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(490, 35);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 35);
            this.btn_save.TabIndex = 63;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.DimGray;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(328, 35);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 35);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_previous.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(409, 35);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 35);
            this.btn_previous.TabIndex = 13;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // ControlOtherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.panel2);
            this.Name = "ControlOtherDetails";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(641, 515);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lbl_educationBackground;
        private System.Windows.Forms.LinkLabel link_education;
        private System.Windows.Forms.Label lbl_contactPerson;
        private System.Windows.Forms.Label lbl_illness;
        private System.Windows.Forms.Label lbl_legal;
        private System.Windows.Forms.Label lbl_employment;
        private System.Windows.Forms.LinkLabel link_illness;
        private System.Windows.Forms.LinkLabel link_legal;
        private System.Windows.Forms.LinkLabel link_employment;
        private System.Windows.Forms.LinkLabel link_contacts;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_workExp;
        private System.Windows.Forms.ComboBox cbx_workExp;
    }
}
