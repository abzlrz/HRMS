using Presentation.DialogBox.ExistingEmployeeRegistration;

namespace Presentation.DialogBox
{
    partial class FormRegisterExistingEmployee
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
            this.controlEmployeeEvaluation1 = new Presentation.DialogBox.ExistingEmployeeRegistration.ControlEmployeeEvaluation();
            this.controlSalaryInfo1 = new Presentation.DialogBox.ExistingEmployeeRegistration.ControlSalaryInfo();
            this.controlEmployeeInfo1 = new Presentation.DialogBox.ExistingEmployeeRegistration.ControlEmployeeInfo();
            this.SuspendLayout();
            // 
            // controlEmployeeEvaluation1
            // 
            this.controlEmployeeEvaluation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmployeeEvaluation1.Location = new System.Drawing.Point(0, 0);
            this.controlEmployeeEvaluation1.Name = "controlEmployeeEvaluation1";
            this.controlEmployeeEvaluation1.Next = this.controlSalaryInfo1;
            this.controlEmployeeEvaluation1.Padding = new System.Windows.Forms.Padding(12);
            this.controlEmployeeEvaluation1.Previous = this.controlEmployeeInfo1;
            this.controlEmployeeEvaluation1.Size = new System.Drawing.Size(587, 521);
            this.controlEmployeeEvaluation1.TabIndex = 1;
            // 
            // controlSalaryInfo1
            // 
            this.controlSalaryInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlSalaryInfo1.Location = new System.Drawing.Point(0, 0);
            this.controlSalaryInfo1.Name = "controlSalaryInfo1";
            this.controlSalaryInfo1.Padding = new System.Windows.Forms.Padding(12);
            this.controlSalaryInfo1.Previous = this.controlEmployeeEvaluation1;
            this.controlSalaryInfo1.Size = new System.Drawing.Size(587, 521);
            this.controlSalaryInfo1.TabIndex = 4;
            // 
            // controlEmployeeInfo1
            // 
            this.controlEmployeeInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmployeeInfo1.Location = new System.Drawing.Point(0, 0);
            this.controlEmployeeInfo1.Name = "controlEmployeeInfo1";
            this.controlEmployeeInfo1.Next = this.controlEmployeeEvaluation1;
            this.controlEmployeeInfo1.Padding = new System.Windows.Forms.Padding(12);
            this.controlEmployeeInfo1.Size = new System.Drawing.Size(587, 521);
            this.controlEmployeeInfo1.TabIndex = 3;
            // 
            // FormRegisterExistingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 521);
            this.Controls.Add(this.controlEmployeeInfo1);
            this.Controls.Add(this.controlEmployeeEvaluation1);
            this.Controls.Add(this.controlSalaryInfo1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegisterExistingEmployee";
            this.Text = "Register Existing Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegisterExistingEmployee_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private ControlEmployeeInfo controlEmployeeInfo1;
        private ControlEmployeeEvaluation controlEmployeeEvaluation1;
        private ControlSalaryInfo controlSalaryInfo1;
    }
}