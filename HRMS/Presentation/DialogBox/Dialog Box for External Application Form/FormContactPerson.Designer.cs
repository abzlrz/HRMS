namespace Presentation.DialogBox
{
    partial class FormContactPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContactPerson));
            this.panel2 = new System.Windows.Forms.Panel();
            this.view_contact = new System.Windows.Forms.DataGridView();
            this.main = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_relationship = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lbl_firstname = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_contactNo = new System.Windows.Forms.Label();
            this.tbx_firstname = new System.Windows.Forms.TextBox();
            this.tbx_lastname = new System.Windows.Forms.TextBox();
            this.tbx_contactNo = new System.Windows.Forms.TextBox();
            this.cbx_relationship = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_contact)).BeginInit();
            this.main.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.view_contact);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 265);
            this.panel2.TabIndex = 4;
            // 
            // view_contact
            // 
            this.view_contact.BackgroundColor = System.Drawing.Color.White;
            this.view_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_contact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_contact.Location = new System.Drawing.Point(0, 0);
            this.view_contact.Name = "view_contact";
            this.view_contact.Size = new System.Drawing.Size(196, 265);
            this.view_contact.TabIndex = 6;
            this.view_contact.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_contact_CellContentClick);
            // 
            // main
            // 
            this.main.Controls.Add(this.btn_delete);
            this.main.Controls.Add(this.btn_add);
            this.main.Controls.Add(this.btn_edit);
            this.main.Controls.Add(this.tableLayoutPanel6);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(208, 12);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(403, 265);
            this.main.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(296, 232);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
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
            this.btn_add.Location = new System.Drawing.Point(134, 232);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Green;
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(215, 232);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Save";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.49292F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.50708F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_relationship, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.lbl_firstname, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbl_lastname, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lbl_contactNo, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tbx_firstname, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbx_lastname, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.tbx_contactNo, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.cbx_relationship, 1, 3);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(18, 49);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(353, 136);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // lbl_relationship
            // 
            this.lbl_relationship.AutoSize = true;
            this.lbl_relationship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_relationship.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_relationship.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_relationship.ImageIndex = 1;
            this.lbl_relationship.ImageList = this.imageList;
            this.lbl_relationship.Location = new System.Drawing.Point(3, 90);
            this.lbl_relationship.Name = "lbl_relationship";
            this.lbl_relationship.Size = new System.Drawing.Size(144, 46);
            this.lbl_relationship.TabIndex = 90;
            this.lbl_relationship.Text = "Relationship:";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "green_dot.png");
            this.imageList.Images.SetKeyName(1, "red_dot.png");
            // 
            // lbl_firstname
            // 
            this.lbl_firstname.AutoSize = true;
            this.lbl_firstname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_firstname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstname.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_firstname.ImageIndex = 1;
            this.lbl_firstname.ImageList = this.imageList;
            this.lbl_firstname.Location = new System.Drawing.Point(3, 0);
            this.lbl_firstname.Name = "lbl_firstname";
            this.lbl_firstname.Size = new System.Drawing.Size(144, 30);
            this.lbl_firstname.TabIndex = 51;
            this.lbl_firstname.Text = "Firstname:";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_lastname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastname.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_lastname.ImageIndex = 1;
            this.lbl_lastname.ImageList = this.imageList;
            this.lbl_lastname.Location = new System.Drawing.Point(3, 30);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(144, 30);
            this.lbl_lastname.TabIndex = 52;
            this.lbl_lastname.Text = "Lastname:";
            // 
            // lbl_contactNo
            // 
            this.lbl_contactNo.AutoSize = true;
            this.lbl_contactNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_contactNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contactNo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_contactNo.ImageIndex = 1;
            this.lbl_contactNo.ImageList = this.imageList;
            this.lbl_contactNo.Location = new System.Drawing.Point(3, 60);
            this.lbl_contactNo.Name = "lbl_contactNo";
            this.lbl_contactNo.Size = new System.Drawing.Size(144, 30);
            this.lbl_contactNo.TabIndex = 83;
            this.lbl_contactNo.Text = "Contact Number:";
            // 
            // tbx_firstname
            // 
            this.tbx_firstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_firstname.Location = new System.Drawing.Point(150, 0);
            this.tbx_firstname.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_firstname.Name = "tbx_firstname";
            this.tbx_firstname.Size = new System.Drawing.Size(203, 20);
            this.tbx_firstname.TabIndex = 108;
            this.tbx_firstname.Tag = "required";
            this.tbx_firstname.TextChanged += new System.EventHandler(this.tbx_firstname_TextChanged);
            // 
            // tbx_lastname
            // 
            this.tbx_lastname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_lastname.Location = new System.Drawing.Point(150, 30);
            this.tbx_lastname.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_lastname.Name = "tbx_lastname";
            this.tbx_lastname.Size = new System.Drawing.Size(203, 20);
            this.tbx_lastname.TabIndex = 109;
            this.tbx_lastname.Tag = "required";
            this.tbx_lastname.TextChanged += new System.EventHandler(this.tbx_lastname_TextChanged);
            // 
            // tbx_contactNo
            // 
            this.tbx_contactNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_contactNo.Location = new System.Drawing.Point(150, 60);
            this.tbx_contactNo.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_contactNo.Name = "tbx_contactNo";
            this.tbx_contactNo.Size = new System.Drawing.Size(203, 20);
            this.tbx_contactNo.TabIndex = 110;
            this.tbx_contactNo.TextChanged += new System.EventHandler(this.tbx_contactNo_TextChanged);
            // 
            // cbx_relationship
            // 
            this.cbx_relationship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_relationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_relationship.FormattingEnabled = true;
            this.cbx_relationship.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Wife",
            "Husband",
            "Son",
            "Daughter",
            "Brother",
            "Sister",
            "Grandfather",
            "Grandmother",
            "Grandson",
            "Granddaughter",
            "Uncle",
            "Aunt",
            "Cousin",
            "Nephew",
            "Niece",
            "Father-in-Law",
            "Mother-in-Law",
            "Brother-in-Law",
            "Sister-in-Law",
            "Stepmother",
            "Stepfather",
            "Stepbrother",
            "Stepsister",
            "Friend",
            "Colleague",
            "Others"});
            this.cbx_relationship.Location = new System.Drawing.Point(150, 90);
            this.cbx_relationship.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_relationship.Name = "cbx_relationship";
            this.cbx_relationship.Size = new System.Drawing.Size(203, 21);
            this.cbx_relationship.TabIndex = 111;
            this.cbx_relationship.SelectedIndexChanged += new System.EventHandler(this.cbx_relationship_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(12, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 52);
            this.panel1.TabIndex = 11;
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
            // FormContactPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 341);
            this.Controls.Add(this.main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContactPerson";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Contacts";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_contact)).EndInit();
            this.main.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView view_contact;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lbl_relationship;
        private System.Windows.Forms.Label lbl_firstname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_contactNo;
        private System.Windows.Forms.TextBox tbx_firstname;
        private System.Windows.Forms.TextBox tbx_lastname;
        private System.Windows.Forms.TextBox tbx_contactNo;
        private System.Windows.Forms.ComboBox cbx_relationship;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}