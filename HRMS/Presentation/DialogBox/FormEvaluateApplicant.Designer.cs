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
            this.ctrl_eval = new Presentation.DialogBox.ApplicantEvaluation.ControlApplicantEvaluation();
            this.ctrl_eval_details = new Presentation.DialogBox.ApplicantEvaluation.ControlApplicantEvaluationDetails();
            this.SuspendLayout();
            // 
            // ctrl_eval
            // 
            this.ctrl_eval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_eval.Location = new System.Drawing.Point(0, 0);
            this.ctrl_eval.Name = "ctrl_eval";
            this.ctrl_eval.Padding = new System.Windows.Forms.Padding(12);
            this.ctrl_eval.Previous = this.ctrl_eval_details;
            this.ctrl_eval.Size = new System.Drawing.Size(587, 521);
            this.ctrl_eval.TabIndex = 1;
            // 
            // ctrl_eval_details
            // 
            this.ctrl_eval_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_eval_details.Location = new System.Drawing.Point(0, 0);
            this.ctrl_eval_details.Name = "ctrl_eval_details";
            this.ctrl_eval_details.Next = this.ctrl_eval;
            this.ctrl_eval_details.Padding = new System.Windows.Forms.Padding(12);
            this.ctrl_eval_details.Size = new System.Drawing.Size(587, 521);
            this.ctrl_eval_details.TabIndex = 2;
            // 
            // FormEvaluateApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 521);
            this.Controls.Add(this.ctrl_eval_details);
            this.Controls.Add(this.ctrl_eval);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvaluateApplicant";
            this.Text = "Interview Evaluation";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }

        #endregion
        private ApplicantEvaluation.ControlApplicantEvaluation ctrl_eval;
        private ApplicantEvaluation.ControlApplicantEvaluationDetails ctrl_eval_details;
    }
}