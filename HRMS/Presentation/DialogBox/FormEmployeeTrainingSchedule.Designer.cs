namespace Presentation.DialogBox
{
    partial class FormEmployeeTrainingSchedule
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.date_scheduleDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_employeeName = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_batchNumber = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Location = new System.Drawing.Point(343, 223);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(81, 23);
            this.btn_ok.TabIndex = 86;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 85);
            this.panel1.TabIndex = 85;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(30, 47);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(200, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "Sets Training Schedule for this Employee";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(30, 23);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(84, 15);
            this.label33.TabIndex = 0;
            this.label33.Text = "Pick Schedule";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.0179F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.9821F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_employeeID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.date_scheduleDate, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_employeeName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label25, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbx_batchNumber, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(25, 103);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 94);
            this.tableLayoutPanel3.TabIndex = 92;
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.BackColor = System.Drawing.Color.White;
            this.lbl_employeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_employeeID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeeID.Location = new System.Drawing.Point(141, 2);
            this.lbl_employeeID.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(245, 21);
            this.lbl_employeeID.TabIndex = 80;
            this.lbl_employeeID.Text = "<----->";
            this.lbl_employeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_scheduleDate
            // 
            this.date_scheduleDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_scheduleDate.Location = new System.Drawing.Point(141, 48);
            this.date_scheduleDate.Margin = new System.Windows.Forms.Padding(0);
            this.date_scheduleDate.Name = "date_scheduleDate";
            this.date_scheduleDate.Size = new System.Drawing.Size(245, 20);
            this.date_scheduleDate.TabIndex = 79;
            // 
            // lbl_employeeName
            // 
            this.lbl_employeeName.AutoSize = true;
            this.lbl_employeeName.BackColor = System.Drawing.Color.White;
            this.lbl_employeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_employeeName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employeeName.Location = new System.Drawing.Point(141, 25);
            this.lbl_employeeName.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_employeeName.Name = "lbl_employeeName";
            this.lbl_employeeName.Size = new System.Drawing.Size(245, 21);
            this.lbl_employeeName.TabIndex = 77;
            this.lbl_employeeName.Text = "<----->";
            this.lbl_employeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(5, 2);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 21);
            this.label25.TabIndex = 51;
            this.label25.Text = "Employee ID:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Employee Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Schedule Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 90;
            this.label6.Text = "Batch Number:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_batchNumber
            // 
            this.tbx_batchNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_batchNumber.Location = new System.Drawing.Point(141, 71);
            this.tbx_batchNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_batchNumber.Name = "tbx_batchNumber";
            this.tbx_batchNumber.Size = new System.Drawing.Size(245, 20);
            this.tbx_batchNumber.TabIndex = 91;
            // 
            // FormEmployeeTrainingSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 258);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmployeeTrainingSchedule";
            this.Text = "Schedule Training";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeTrainingSchedule_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.DateTimePicker date_scheduleDate;
        private System.Windows.Forms.Label lbl_employeeName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_batchNumber;
    }
}