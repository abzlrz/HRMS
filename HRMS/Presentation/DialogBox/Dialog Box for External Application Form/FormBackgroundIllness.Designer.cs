namespace Presentation.DialogBox.ExternalApplicationForm
{
    partial class FormBackgroundIllness
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
            this.IsMedOperated = new Presentation.Miscellaneous.ControlYesNoRadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.view_operations = new System.Windows.Forms.DataGridView();
            this.panel_operations = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_operated_details = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_operated_desc = new System.Windows.Forms.TextBox();
            this.btn_operated_add = new System.Windows.Forms.Button();
            this.btn_operated_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.view_illness = new System.Windows.Forms.DataGridView();
            this.panel_illness = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.IsLifetimeIllness = new Presentation.Miscellaneous.ControlYesNoRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_illness_details = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_illness_description = new System.Windows.Forms.TextBox();
            this.btn_illness_add = new System.Windows.Forms.Button();
            this.btn_illness_delete = new System.Windows.Forms.Button();
            this.IsDiagnosedByIlness = new Presentation.Miscellaneous.ControlYesNoRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_operations)).BeginInit();
            this.panel_operations.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_illness)).BeginInit();
            this.panel_illness.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IsMedOperated);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(430, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(418, 404);
            this.panel2.TabIndex = 1;
            // 
            // IsMedOperated
            // 
            this.IsMedOperated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.IsMedOperated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMedOperated.Location = new System.Drawing.Point(19, 36);
            this.IsMedOperated.Name = "IsMedOperated";
            this.IsMedOperated.Padding = new System.Windows.Forms.Padding(3);
            this.IsMedOperated.Size = new System.Drawing.Size(125, 37);
            this.IsMedOperated.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.view_operations);
            this.panel3.Controls.Add(this.panel_operations);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(7, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 324);
            this.panel3.TabIndex = 3;
            // 
            // view_operations
            // 
            this.view_operations.AllowUserToAddRows = false;
            this.view_operations.AllowUserToDeleteRows = false;
            this.view_operations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_operations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.view_operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_operations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_operations.Enabled = false;
            this.view_operations.Location = new System.Drawing.Point(0, 0);
            this.view_operations.Name = "view_operations";
            this.view_operations.ReadOnly = true;
            this.view_operations.RowHeadersVisible = false;
            this.view_operations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_operations.Size = new System.Drawing.Size(404, 178);
            this.view_operations.TabIndex = 3;
            this.view_operations.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.view_operations_RowsAdded);
            // 
            // panel_operations
            // 
            this.panel_operations.Controls.Add(this.label7);
            this.panel_operations.Controls.Add(this.tbx_operated_details);
            this.panel_operations.Controls.Add(this.label8);
            this.panel_operations.Controls.Add(this.tbx_operated_desc);
            this.panel_operations.Controls.Add(this.btn_operated_add);
            this.panel_operations.Controls.Add(this.btn_operated_delete);
            this.panel_operations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_operations.Enabled = false;
            this.panel_operations.Location = new System.Drawing.Point(0, 178);
            this.panel_operations.Name = "panel_operations";
            this.panel_operations.Size = new System.Drawing.Size(404, 146);
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
            // tbx_operated_details
            // 
            this.tbx_operated_details.Location = new System.Drawing.Point(80, 41);
            this.tbx_operated_details.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_operated_details.Name = "tbx_operated_details";
            this.tbx_operated_details.Size = new System.Drawing.Size(319, 20);
            this.tbx_operated_details.TabIndex = 18;
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
            // tbx_operated_desc
            // 
            this.tbx_operated_desc.Location = new System.Drawing.Point(80, 16);
            this.tbx_operated_desc.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_operated_desc.Name = "tbx_operated_desc";
            this.tbx_operated_desc.Size = new System.Drawing.Size(319, 20);
            this.tbx_operated_desc.TabIndex = 14;
            // 
            // btn_operated_add
            // 
            this.btn_operated_add.Location = new System.Drawing.Point(241, 119);
            this.btn_operated_add.Name = "btn_operated_add";
            this.btn_operated_add.Size = new System.Drawing.Size(75, 22);
            this.btn_operated_add.TabIndex = 15;
            this.btn_operated_add.Text = "Add";
            this.btn_operated_add.UseVisualStyleBackColor = true;
            this.btn_operated_add.Click += new System.EventHandler(this.btn_operated_add_Click);
            // 
            // btn_operated_delete
            // 
            this.btn_operated_delete.Location = new System.Drawing.Point(324, 119);
            this.btn_operated_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_operated_delete.Name = "btn_operated_delete";
            this.btn_operated_delete.Size = new System.Drawing.Size(75, 22);
            this.btn_operated_delete.TabIndex = 16;
            this.btn_operated_delete.Text = "Delete";
            this.btn_operated_delete.UseVisualStyleBackColor = true;
            this.btn_operated_delete.Click += new System.EventHandler(this.btn_operated_delete_Click);
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
            this.label1.Text = "Are you undergone of any medical operations?";
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
            this.label2.Text = "Are you diagnosed of any Illnesses?";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.view_illness);
            this.panel4.Controls.Add(this.panel_illness);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(7, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 324);
            this.panel4.TabIndex = 3;
            // 
            // view_illness
            // 
            this.view_illness.AllowUserToAddRows = false;
            this.view_illness.AllowUserToDeleteRows = false;
            this.view_illness.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_illness.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.view_illness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_illness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_illness.Enabled = false;
            this.view_illness.Location = new System.Drawing.Point(0, 0);
            this.view_illness.Name = "view_illness";
            this.view_illness.ReadOnly = true;
            this.view_illness.RowHeadersVisible = false;
            this.view_illness.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_illness.Size = new System.Drawing.Size(404, 178);
            this.view_illness.TabIndex = 3;
            this.view_illness.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.view_illness_RowsAdded);
            // 
            // panel_illness
            // 
            this.panel_illness.Controls.Add(this.label5);
            this.panel_illness.Controls.Add(this.IsLifetimeIllness);
            this.panel_illness.Controls.Add(this.label4);
            this.panel_illness.Controls.Add(this.tbx_illness_details);
            this.panel_illness.Controls.Add(this.label3);
            this.panel_illness.Controls.Add(this.tbx_illness_description);
            this.panel_illness.Controls.Add(this.btn_illness_add);
            this.panel_illness.Controls.Add(this.btn_illness_delete);
            this.panel_illness.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_illness.Enabled = false;
            this.panel_illness.Location = new System.Drawing.Point(0, 178);
            this.panel_illness.Name = "panel_illness";
            this.panel_illness.Size = new System.Drawing.Size(404, 146);
            this.panel_illness.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Is it a lifetime illness?";
            // 
            // IsLifetimeIllness
            // 
            this.IsLifetimeIllness.BackColor = System.Drawing.SystemColors.Control;
            this.IsLifetimeIllness.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsLifetimeIllness.Location = new System.Drawing.Point(130, 69);
            this.IsLifetimeIllness.Name = "IsLifetimeIllness";
            this.IsLifetimeIllness.Padding = new System.Windows.Forms.Padding(3);
            this.IsLifetimeIllness.Size = new System.Drawing.Size(132, 37);
            this.IsLifetimeIllness.TabIndex = 12;
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
            // tbx_illness_details
            // 
            this.tbx_illness_details.Location = new System.Drawing.Point(80, 41);
            this.tbx_illness_details.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_illness_details.Name = "tbx_illness_details";
            this.tbx_illness_details.Size = new System.Drawing.Size(319, 20);
            this.tbx_illness_details.TabIndex = 10;
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
            // tbx_illness_description
            // 
            this.tbx_illness_description.Location = new System.Drawing.Point(80, 16);
            this.tbx_illness_description.Margin = new System.Windows.Forms.Padding(5);
            this.tbx_illness_description.Name = "tbx_illness_description";
            this.tbx_illness_description.Size = new System.Drawing.Size(319, 20);
            this.tbx_illness_description.TabIndex = 6;
            // 
            // btn_illness_add
            // 
            this.btn_illness_add.Location = new System.Drawing.Point(241, 119);
            this.btn_illness_add.Name = "btn_illness_add";
            this.btn_illness_add.Size = new System.Drawing.Size(75, 22);
            this.btn_illness_add.TabIndex = 7;
            this.btn_illness_add.Text = "Add";
            this.btn_illness_add.UseVisualStyleBackColor = true;
            this.btn_illness_add.Click += new System.EventHandler(this.btn_illness_add_Click);
            // 
            // btn_illness_delete
            // 
            this.btn_illness_delete.Location = new System.Drawing.Point(324, 119);
            this.btn_illness_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_illness_delete.Name = "btn_illness_delete";
            this.btn_illness_delete.Size = new System.Drawing.Size(75, 22);
            this.btn_illness_delete.TabIndex = 8;
            this.btn_illness_delete.Text = "Delete";
            this.btn_illness_delete.UseVisualStyleBackColor = true;
            this.btn_illness_delete.Click += new System.EventHandler(this.btn_illness_delete_Click);
            // 
            // IsDiagnosedByIlness
            // 
            this.IsDiagnosedByIlness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.IsDiagnosedByIlness.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsDiagnosedByIlness.Location = new System.Drawing.Point(19, 36);
            this.IsDiagnosedByIlness.Name = "IsDiagnosedByIlness";
            this.IsDiagnosedByIlness.Padding = new System.Windows.Forms.Padding(3);
            this.IsDiagnosedByIlness.Size = new System.Drawing.Size(132, 37);
            this.IsDiagnosedByIlness.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IsDiagnosedByIlness);
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
            // FormBackgroundIllness
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
            this.Name = "FormBackgroundIllness";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Text = "History of Illness";
           
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_operations)).EndInit();
            this.panel_operations.ResumeLayout(false);
            this.panel_operations.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_illness)).EndInit();
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
        private Miscellaneous.ControlYesNoRadioButton IsMedOperated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_operated_details;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_operated_desc;
        private System.Windows.Forms.Button btn_operated_add;
        private System.Windows.Forms.Button btn_operated_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_illness;
        private System.Windows.Forms.Label label5;
        private Miscellaneous.ControlYesNoRadioButton IsLifetimeIllness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_illness_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_illness_description;
        private System.Windows.Forms.Button btn_illness_add;
        private System.Windows.Forms.Button btn_illness_delete;
        private Miscellaneous.ControlYesNoRadioButton IsDiagnosedByIlness;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView view_operations;
        private System.Windows.Forms.DataGridView view_illness;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ok;
    }
}