namespace Presentation.DialogBox
{
    partial class FormRegisterEmployee
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
            this.controlEmployeeApplicationDetails1 = new Presentation.DialogBox.EmployeeRegistration.ControlEmployeeApplicationDetails();
            this.controlEmployeeDetailsAndSalaryInfo1 = new Presentation.DialogBox.EmployeeRegistration.ControlEmployeeDetailsAndSalaryInfo();
            this.controlEmployeeEvaluationDetails1 = new Presentation.DialogBox.EmployeeRegistration.ControlEmployeeEvaluationDetails();
            this.SuspendLayout();
            // 
            // controlEmployeeApplicationDetails1
            // 
            this.controlEmployeeApplicationDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmployeeApplicationDetails1.Location = new System.Drawing.Point(0, 0);
            this.controlEmployeeApplicationDetails1.Name = "controlEmployeeApplicationDetails1";
            this.controlEmployeeApplicationDetails1.Next = this.controlEmployeeDetailsAndSalaryInfo1;
            this.controlEmployeeApplicationDetails1.Padding = new System.Windows.Forms.Padding(12);
            this.controlEmployeeApplicationDetails1.Previous = this.controlEmployeeApplicationDetails1;
            this.controlEmployeeApplicationDetails1.Size = new System.Drawing.Size(587, 521);
            this.controlEmployeeApplicationDetails1.TabIndex = 0;
            // 
            // controlEmployeeDetailsAndSalaryInfo1
            // 
            this.controlEmployeeDetailsAndSalaryInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmployeeDetailsAndSalaryInfo1.Location = new System.Drawing.Point(0, 0);
            this.controlEmployeeDetailsAndSalaryInfo1.Name = "controlEmployeeDetailsAndSalaryInfo1";
            this.controlEmployeeDetailsAndSalaryInfo1.Padding = new System.Windows.Forms.Padding(12);
            this.controlEmployeeDetailsAndSalaryInfo1.Previous = this.controlEmployeeApplicationDetails1;
            this.controlEmployeeDetailsAndSalaryInfo1.Size = new System.Drawing.Size(587, 521);
            this.controlEmployeeDetailsAndSalaryInfo1.TabIndex = 2;
            // 
            // controlEmployeeEvaluationDetails1
            // 
            this.controlEmployeeEvaluationDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEmployeeEvaluationDetails1.Location = new System.Drawing.Point(0, 0);
            this.controlEmployeeEvaluationDetails1.Name = "controlEmployeeEvaluationDetails1";
            this.controlEmployeeEvaluationDetails1.Next = this.controlEmployeeApplicationDetails1;
            this.controlEmployeeEvaluationDetails1.Padding = new System.Windows.Forms.Padding(12);
            this.controlEmployeeEvaluationDetails1.Size = new System.Drawing.Size(587, 521);
            this.controlEmployeeEvaluationDetails1.TabIndex = 1;
            // 
            // FormRegisterEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(587, 521);
            this.Controls.Add(this.controlEmployeeEvaluationDetails1);
            this.Controls.Add(this.controlEmployeeApplicationDetails1);
            this.Controls.Add(this.controlEmployeeDetailsAndSalaryInfo1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegisterEmployee";
            this.Text = "Register Employee";
            this.Load += new System.EventHandler(this.FormRegisterEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EmployeeRegistration.ControlEmployeeApplicationDetails controlEmployeeApplicationDetails1;
        private EmployeeRegistration.ControlEmployeeDetailsAndSalaryInfo controlEmployeeDetailsAndSalaryInfo1;
        private EmployeeRegistration.ControlEmployeeEvaluationDetails controlEmployeeEvaluationDetails1;
    }
}