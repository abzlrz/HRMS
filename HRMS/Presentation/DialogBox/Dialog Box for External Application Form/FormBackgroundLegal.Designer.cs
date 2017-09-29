namespace Presentation.DialogBox.ExternalApplicationForm
{
    partial class FormBackgroundLegal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.IsConvicted = new Presentation.Miscellaneous.ControlYesNoRadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.view_conviction = new System.Windows.Forms.DataGridView();
            this.panel_operations = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_conviction_details = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_conviction_desc = new System.Windows.Forms.TextBox();
            this.btn_conviction_add = new System.Windows.Forms.Button();
            this.btn_conviction_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.view_legalcase = new System.Windows.Forms.DataGridView();
            this.panel_illness = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_legalcase_details = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_legalcase_description = new System.Windows.Forms.TextBox();
            this.btn_legalcase_add = new System.Windows.Forms.Button();
            this.btn_legalcase_delete = new System.Windows.Forms.Button();
            this.IsLawsuited = new Presentation.Miscellaneous.ControlYesNoRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_conviction)).BeginInit();
            this.panel_operations.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_legalcase)).BeginInit();
            this.panel_illness.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IsConvicted);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(430, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(418, 404);
            this.panel2.TabIndex = 1;
            // 
            // IsConvicted
            // 
            this.IsConvicted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.IsConvicted.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsConvicted.Location = new System.Drawing.Point(19, 36);
            this.IsConvicted.Name = "IsConvicted";
            this.IsConvicted.Padding = new System.Windows.Forms.Padding(3);
            this.IsConvicted.Size = new System.Drawing.Size(125, 37);
            this.IsConvicted.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.view_conviction);
            this.panel3.Controls.Add(this.panel_operations);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(7, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 324);
            this.panel3.TabIndex = 3;
            // 
            // view_conviction
            // 
            this.view_conviction.AllowUserToAddRows = false;
            this.view_conviction.AllowUserToDeleteRows = false;
            this.view_conviction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_conviction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.view_conviction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_conviction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_conviction.Enabled = false;
            this.view_conviction.Location = new System.Drawing.Point(0, 0);
            this.view_conviction.Name = "view_conviction";
            this.view_conviction.ReadOnly = true;
            this.view_conviction.RowHeadersVisible = false;
            this.view_conviction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_conviction.Size = new System.Drawing.Size(404, 222);
            this.view_conviction.TabIndex = 3;
            this.view_conviction.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.view_operations_RowsAdded);
            // 
            // panel_operations
            // 
            this.panel_operations.Controls.Add(this.label7);
            this.panel_operations.Controls.Add(this.tbx_conviction_details);
            this.panel_operations.Controls.Add(this.label8);
            this.panel_operations.Controls.Add(this.tbx_conviction_desc);
            this.panel_operations.Controls.Add(this.btn_conviction_add);
            this.panel_operations.Controls.Add(this.btn_conviction_delete);
            this.panel_operations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_operations.Enabled = false;
            this.panel_operations.Location = new System.Drawing.Point(0, 222);
            this.panel_operations.Name = "panel_operations";
            this.panel_operations.Size = new System.Drawing.Size(404, 102);
            this.panel_operations.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Details:";
            // 
            // tbx_conviction_details
            // 
            this.tbx_conviction_details.Location = new System.Drawing.Point(80, 41);
            this.tbx_conviction_details.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_conviction_details.Name = "tbx_conviction_details";
            this.tbx_conviction_details.Size = new System.Drawing.Size(319, 20);
            this.tbx_conviction_details.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description:";
            // 
            // tbx_conviction_desc
            // 
            this.tbx_conviction_desc.Location = new System.Drawing.Point(80, 16);
            this.tbx_conviction_desc.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_conviction_desc.Name = "tbx_conviction_desc";
            this.tbx_conviction_desc.Size = new System.Drawing.Size(319, 20);
            this.tbx_conviction_desc.TabIndex = 14;
            // 
            // btn_conviction_add
            // 
            this.btn_conviction_add.Location = new System.Drawing.Point(241, 71);
            this.btn_conviction_add.Name = "btn_conviction_add";
            this.btn_conviction_add.Size = new System.Drawing.Size(75, 22);
            this.btn_conviction_add.TabIndex = 15;
            this.btn_conviction_add.Text = "Add";
            this.btn_conviction_add.UseVisualStyleBackColor = true;
            this.btn_conviction_add.Click += new System.EventHandler(this.btn_operated_add_Click);
            // 
            // btn_conviction_delete
            // 
            this.btn_conviction_delete.Location = new System.Drawing.Point(324, 71);
            this.btn_conviction_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_conviction_delete.Name = "btn_conviction_delete";
            this.btn_conviction_delete.Size = new System.Drawing.Size(75, 22);
            this.btn_conviction_delete.TabIndex = 16;
            this.btn_conviction_delete.Text = "Delete";
            this.btn_conviction_delete.UseVisualStyleBackColor = true;
            this.btn_conviction_delete.Click += new System.EventHandler(this.btn_operated_delete_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.Size = new System.Drawing.Size(404, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you convicted of any crime?";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(8);
            this.label2.Size = new System.Drawing.Size(404, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "Are you charged of any legal case?";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.view_legalcase);
            this.panel4.Controls.Add(this.panel_illness);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(7, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 324);
            this.panel4.TabIndex = 3;
            // 
            // view_legalcase
            // 
            this.view_legalcase.AllowUserToAddRows = false;
            this.view_legalcase.AllowUserToDeleteRows = false;
            this.view_legalcase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_legalcase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.view_legalcase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_legalcase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_legalcase.Enabled = false;
            this.view_legalcase.Location = new System.Drawing.Point(0, 0);
            this.view_legalcase.Name = "view_legalcase";
            this.view_legalcase.ReadOnly = true;
            this.view_legalcase.RowHeadersVisible = false;
            this.view_legalcase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_legalcase.Size = new System.Drawing.Size(404, 222);
            this.view_legalcase.TabIndex = 3;
            this.view_legalcase.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.view_illness_RowsAdded);
            // 
            // panel_illness
            // 
            this.panel_illness.Controls.Add(this.label4);
            this.panel_illness.Controls.Add(this.tbx_legalcase_details);
            this.panel_illness.Controls.Add(this.label3);
            this.panel_illness.Controls.Add(this.tbx_legalcase_description);
            this.panel_illness.Controls.Add(this.btn_legalcase_add);
            this.panel_illness.Controls.Add(this.btn_legalcase_delete);
            this.panel_illness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_illness.Enabled = false;
            this.panel_illness.Location = new System.Drawing.Point(0, 222);
            this.panel_illness.Name = "panel_illness";
            this.panel_illness.Size = new System.Drawing.Size(404, 102);
            this.panel_illness.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Details:";
            // 
            // tbx_legalcase_details
            // 
            this.tbx_legalcase_details.Location = new System.Drawing.Point(80, 41);
            this.tbx_legalcase_details.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_legalcase_details.Name = "tbx_legalcase_details";
            this.tbx_legalcase_details.Size = new System.Drawing.Size(319, 20);
            this.tbx_legalcase_details.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // tbx_legalcase_description
            // 
            this.tbx_legalcase_description.Location = new System.Drawing.Point(80, 16);
            this.tbx_legalcase_description.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_legalcase_description.Name = "tbx_legalcase_description";
            this.tbx_legalcase_description.Size = new System.Drawing.Size(319, 20);
            this.tbx_legalcase_description.TabIndex = 6;
            // 
            // btn_legalcase_add
            // 
            this.btn_legalcase_add.Location = new System.Drawing.Point(241, 71);
            this.btn_legalcase_add.Name = "btn_legalcase_add";
            this.btn_legalcase_add.Size = new System.Drawing.Size(75, 22);
            this.btn_legalcase_add.TabIndex = 7;
            this.btn_legalcase_add.Text = "Add";
            this.btn_legalcase_add.UseVisualStyleBackColor = true;
            this.btn_legalcase_add.Click += new System.EventHandler(this.btn_illness_add_Click);
            // 
            // btn_legalcase_delete
            // 
            this.btn_legalcase_delete.Location = new System.Drawing.Point(324, 71);
            this.btn_legalcase_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_legalcase_delete.Name = "btn_legalcase_delete";
            this.btn_legalcase_delete.Size = new System.Drawing.Size(75, 22);
            this.btn_legalcase_delete.TabIndex = 8;
            this.btn_legalcase_delete.Text = "Delete";
            this.btn_legalcase_delete.UseVisualStyleBackColor = true;
            this.btn_legalcase_delete.Click += new System.EventHandler(this.btn_illness_delete_Click);
            // 
            // IsLawsuited
            // 
            this.IsLawsuited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.IsLawsuited.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsLawsuited.Location = new System.Drawing.Point(19, 36);
            this.IsLawsuited.Name = "IsLawsuited";
            this.IsLawsuited.Padding = new System.Windows.Forms.Padding(3);
            this.IsLawsuited.Size = new System.Drawing.Size(132, 37);
            this.IsLawsuited.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IsLawsuited);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(418, 404);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_ok);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(12, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(836, 33);
            this.panel5.TabIndex = 10;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(761, 8);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 25);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // FormBackgroundLegal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBackgroundLegal";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "Legal Background";
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_conviction)).EndInit();
            this.panel_operations.ResumeLayout(false);
            this.panel_operations.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_legalcase)).EndInit();
            this.panel_illness.ResumeLayout(false);
            this.panel_illness.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_operations;
        private System.Windows.Forms.Label label1;
        private Miscellaneous.ControlYesNoRadioButton IsConvicted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_conviction_details;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_conviction_desc;
        private System.Windows.Forms.Button btn_conviction_add;
        private System.Windows.Forms.Button btn_conviction_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_illness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_legalcase_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_legalcase_description;
        private System.Windows.Forms.Button btn_legalcase_add;
        private System.Windows.Forms.Button btn_legalcase_delete;
        private Miscellaneous.ControlYesNoRadioButton IsLawsuited;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView view_conviction;
        private System.Windows.Forms.DataGridView view_legalcase;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ok;
    }
}