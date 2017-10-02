namespace Presentation.DialogBox
{
    partial class FormEmployeeExit
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
            this.gbxAppInfo = new System.Windows.Forms.GroupBox();
            this.applicantInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_eID = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_interviewer = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.gbxEvaluationInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbx_rAnalysis = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_rFleaving = new System.Windows.Forms.ComboBox();
            this.gbxAttachment = new System.Windows.Forms.GroupBox();
            this.link_path = new System.Windows.Forms.LinkLabel();
            this.btn_attach = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.gbxAppInfo.SuspendLayout();
            this.applicantInfo.SuspendLayout();
            this.gbxEvaluationInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxAttachment.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAppInfo
            // 
            this.gbxAppInfo.Controls.Add(this.applicantInfo);
            this.gbxAppInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAppInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxAppInfo.Name = "gbxAppInfo";
            this.gbxAppInfo.Size = new System.Drawing.Size(397, 159);
            this.gbxAppInfo.TabIndex = 3;
            this.gbxAppInfo.TabStop = false;
            this.gbxAppInfo.Text = "Info";
            // 
            // applicantInfo
            // 
            this.applicantInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.applicantInfo.ColumnCount = 2;
            this.applicantInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0179F));
            this.applicantInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.9821F));
            this.applicantInfo.Controls.Add(this.label1, 0, 0);
            this.applicantInfo.Controls.Add(this.label2, 0, 1);
            this.applicantInfo.Controls.Add(this.label3, 0, 2);
            this.applicantInfo.Controls.Add(this.label4, 0, 3);
            this.applicantInfo.Controls.Add(this.label5, 0, 4);
            this.applicantInfo.Controls.Add(this.lbl_name, 1, 0);
            this.applicantInfo.Controls.Add(this.lbl_eID, 1, 1);
            this.applicantInfo.Controls.Add(this.lbl_position, 1, 2);
            this.applicantInfo.Controls.Add(this.lbl_interviewer, 1, 3);
            this.applicantInfo.Controls.Add(this.lbl_date, 1, 4);
            this.applicantInfo.Location = new System.Drawing.Point(25, 24);
            this.applicantInfo.Margin = new System.Windows.Forms.Padding(1);
            this.applicantInfo.Name = "applicantInfo";
            this.applicantInfo.RowCount = 5;
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.applicantInfo.Size = new System.Drawing.Size(347, 112);
            this.applicantInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Employee ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Position:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Interviewer:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(126, 2);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(219, 20);
            this.lbl_name.TabIndex = 60;
            this.lbl_name.Text = "<----->";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_eID
            // 
            this.lbl_eID.AutoSize = true;
            this.lbl_eID.BackColor = System.Drawing.Color.White;
            this.lbl_eID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_eID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eID.Location = new System.Drawing.Point(126, 24);
            this.lbl_eID.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_eID.Name = "lbl_eID";
            this.lbl_eID.Size = new System.Drawing.Size(219, 20);
            this.lbl_eID.TabIndex = 61;
            this.lbl_eID.Text = "<----->";
            this.lbl_eID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.BackColor = System.Drawing.Color.White;
            this.lbl_position.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_position.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_position.Location = new System.Drawing.Point(126, 46);
            this.lbl_position.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(219, 20);
            this.lbl_position.TabIndex = 62;
            this.lbl_position.Text = "<----->";
            this.lbl_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_interviewer
            // 
            this.lbl_interviewer.AutoSize = true;
            this.lbl_interviewer.BackColor = System.Drawing.Color.White;
            this.lbl_interviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_interviewer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interviewer.Location = new System.Drawing.Point(126, 68);
            this.lbl_interviewer.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_interviewer.Name = "lbl_interviewer";
            this.lbl_interviewer.Size = new System.Drawing.Size(219, 20);
            this.lbl_interviewer.TabIndex = 63;
            this.lbl_interviewer.Text = "<----->";
            this.lbl_interviewer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.White;
            this.lbl_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(126, 90);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(219, 20);
            this.lbl_date.TabIndex = 64;
            this.lbl_date.Text = "<----->";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbxEvaluationInfo
            // 
            this.gbxEvaluationInfo.Controls.Add(this.tableLayoutPanel1);
            this.gbxEvaluationInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEvaluationInfo.Location = new System.Drawing.Point(12, 177);
            this.gbxEvaluationInfo.Name = "gbxEvaluationInfo";
            this.gbxEvaluationInfo.Size = new System.Drawing.Size(397, 91);
            this.gbxEvaluationInfo.TabIndex = 5;
            this.gbxEvaluationInfo.TabStop = false;
            this.gbxEvaluationInfo.Text = "Reasons";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.9821F));
            this.tableLayoutPanel1.Controls.Add(this.cbx_rAnalysis, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_rFleaving, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 48);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbx_rAnalysis
            // 
            this.cbx_rAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_rAnalysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_rAnalysis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_rAnalysis.FormattingEnabled = true;
            this.cbx_rAnalysis.Location = new System.Drawing.Point(126, 25);
            this.cbx_rAnalysis.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_rAnalysis.Name = "cbx_rAnalysis";
            this.cbx_rAnalysis.Size = new System.Drawing.Size(219, 21);
            this.cbx_rAnalysis.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 21);
            this.label14.TabIndex = 52;
            this.label14.Text = "Reasons for Leaving:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 21);
            this.label21.TabIndex = 53;
            this.label21.Text = "Reasons Analysis:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rFleaving
            // 
            this.lbl_rFleaving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_rFleaving.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbl_rFleaving.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rFleaving.FormattingEnabled = true;
            this.lbl_rFleaving.Location = new System.Drawing.Point(126, 2);
            this.lbl_rFleaving.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_rFleaving.Name = "lbl_rFleaving";
            this.lbl_rFleaving.Size = new System.Drawing.Size(219, 21);
            this.lbl_rFleaving.TabIndex = 61;
            // 
            // gbxAttachment
            // 
            this.gbxAttachment.Controls.Add(this.link_path);
            this.gbxAttachment.Controls.Add(this.btn_attach);
            this.gbxAttachment.Location = new System.Drawing.Point(417, 12);
            this.gbxAttachment.Name = "gbxAttachment";
            this.gbxAttachment.Size = new System.Drawing.Size(235, 212);
            this.gbxAttachment.TabIndex = 10;
            this.gbxAttachment.TabStop = false;
            this.gbxAttachment.Text = "Attachment";
            // 
            // link_path
            // 
            this.link_path.AutoEllipsis = true;
            this.link_path.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_path.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.link_path.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_path.Location = new System.Drawing.Point(24, 127);
            this.link_path.Name = "link_path";
            this.link_path.Size = new System.Drawing.Size(187, 23);
            this.link_path.TabIndex = 97;
            this.link_path.TabStop = true;
            this.link_path.Text = "File";
            this.link_path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_path.Click += new System.EventHandler(this.linkPathClick);
            // 
            // btn_attach
            // 
            this.btn_attach.Location = new System.Drawing.Point(55, 67);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.Size = new System.Drawing.Size(132, 23);
            this.btn_attach.TabIndex = 79;
            this.btn_attach.Text = "Attach File";
            this.btn_attach.UseVisualStyleBackColor = true;
            this.btn_attach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogFileOk);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(496, 230);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 35);
            this.btn_save.TabIndex = 102;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(576, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 103;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(415, 230);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 35);
            this.btn_reset.TabIndex = 104;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            // 
            // FormEmployeeExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 280);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gbxAttachment);
            this.Controls.Add(this.gbxEvaluationInfo);
            this.Controls.Add(this.gbxAppInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmployeeExit";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Exit Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeExitForm_FormClosing);
            this.gbxAppInfo.ResumeLayout(false);
            this.applicantInfo.ResumeLayout(false);
            this.applicantInfo.PerformLayout();
            this.gbxEvaluationInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbxAttachment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAppInfo;
        private System.Windows.Forms.TableLayoutPanel applicantInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_eID;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_interviewer;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.GroupBox gbxEvaluationInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbx_rAnalysis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox lbl_rFleaving;
        private System.Windows.Forms.GroupBox gbxAttachment;
        private System.Windows.Forms.LinkLabel link_path;
        private System.Windows.Forms.Button btn_attach;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_reset;
    }
}