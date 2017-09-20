namespace Presentation.DialogBox
{
    partial class FormEvaluateApplicant
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
            this.controlApplicantEvaluationDetails1 = new Presentation.DialogBox.ApplicantEvaluation.ControlApplicantEvaluationDetails();
            this.controlApplicantEvaluation1 = new Presentation.DialogBox.ApplicantEvaluation.ControlApplicantEvaluation();
            this.SuspendLayout();
            // 
            // controlApplicantEvaluationDetails1
            // 
            this.controlApplicantEvaluationDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlApplicantEvaluationDetails1.Location = new System.Drawing.Point(0, 0);
            this.controlApplicantEvaluationDetails1.Name = "controlApplicantEvaluationDetails1";
            this.controlApplicantEvaluationDetails1.Next = this.controlApplicantEvaluation1;
            this.controlApplicantEvaluationDetails1.Padding = new System.Windows.Forms.Padding(12);
            this.controlApplicantEvaluationDetails1.Size = new System.Drawing.Size(587, 521);
            this.controlApplicantEvaluationDetails1.TabIndex = 0;
            // 
            // controlApplicantEvaluation1
            // 
            this.controlApplicantEvaluation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlApplicantEvaluation1.Location = new System.Drawing.Point(0, 0);
            this.controlApplicantEvaluation1.Name = "controlApplicantEvaluation1";
            this.controlApplicantEvaluation1.Padding = new System.Windows.Forms.Padding(12);
            this.controlApplicantEvaluation1.Previous = this.controlApplicantEvaluationDetails1;
            this.controlApplicantEvaluation1.Size = new System.Drawing.Size(587, 521);
            this.controlApplicantEvaluation1.TabIndex = 1;
            // 
            // FormEvaluateApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 521);
            this.Controls.Add(this.controlApplicantEvaluationDetails1);
            this.Controls.Add(this.controlApplicantEvaluation1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvaluateApplicant";
            this.Text = "Interview Evaluation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EvaluateApplicant_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicantEvaluation.ControlApplicantEvaluationDetails controlApplicantEvaluationDetails1;
        private ApplicantEvaluation.ControlApplicantEvaluation controlApplicantEvaluation1;
    }
}