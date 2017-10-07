namespace Presentation
{
    partial class Form2
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
            this.controlBackgroundCheck1 = new Presentation.DialogBox.ExternalApplication.ControlBackgroundCheck();
            this.SuspendLayout();
            // 
            // controlBackgroundCheck1
            // 
            this.controlBackgroundCheck1.Location = new System.Drawing.Point(12, 12);
            this.controlBackgroundCheck1.Name = "controlBackgroundCheck1";
            this.controlBackgroundCheck1.Padding = new System.Windows.Forms.Padding(12);
            this.controlBackgroundCheck1.Previous = null;
            this.controlBackgroundCheck1.Size = new System.Drawing.Size(641, 515);
            this.controlBackgroundCheck1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(559, 434);
            this.Controls.Add(this.controlBackgroundCheck1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private DialogBox.ExternalApplication.ControlBackgroundCheck controlBackgroundCheck1;
    }
}