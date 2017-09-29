namespace Presentation.Miscellaneous
{
    partial class ControlYesNoRadioButton
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
            this.No = new System.Windows.Forms.RadioButton();
            this.Yes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Transparent;
            this.No.Checked = true;
            this.No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.No.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.No.Location = new System.Drawing.Point(67, 3);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(62, 31);
            this.No.TabIndex = 7;
            this.No.TabStop = true;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = false;
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.Transparent;
            this.Yes.Dock = System.Windows.Forms.DockStyle.Left;
            this.Yes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Yes.Location = new System.Drawing.Point(3, 3);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(64, 31);
            this.Yes.TabIndex = 6;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = false;
            // 
            // ControlYesNoRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ControlYesNoRadioButton";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(132, 37);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RadioButton No;
        public System.Windows.Forms.RadioButton Yes;
    }
}
