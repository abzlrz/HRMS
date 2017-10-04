namespace Presentation.Miscellaneous
{
    partial class FormNewPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewPassword));
            this.btn_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.cx_viewpassword = new System.Windows.Forms.CheckBox();
            this.lbl_indicator = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(126, 149);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(104, 32);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "&OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input your new password";
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(39, 61);
            this.tbx_password.MaxLength = 10;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(276, 29);
            this.tbx_password.TabIndex = 2;
            this.tbx_password.UseSystemPasswordChar = true;
            this.tbx_password.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // cx_viewpassword
            // 
            this.cx_viewpassword.AutoSize = true;
            this.cx_viewpassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cx_viewpassword.Location = new System.Drawing.Point(39, 96);
            this.cx_viewpassword.Name = "cx_viewpassword";
            this.cx_viewpassword.Size = new System.Drawing.Size(102, 17);
            this.cx_viewpassword.TabIndex = 5;
            this.cx_viewpassword.Text = "view password";
            this.cx_viewpassword.UseVisualStyleBackColor = true;
            this.cx_viewpassword.CheckedChanged += new System.EventHandler(this.cx_viewpassword_CheckedChanged);
            // 
            // lbl_indicator
            // 
            this.lbl_indicator.AutoSize = true;
            this.lbl_indicator.ImageIndex = 1;
            this.lbl_indicator.ImageList = this.imageList;
            this.lbl_indicator.Location = new System.Drawing.Point(321, 67);
            this.lbl_indicator.Name = "lbl_indicator";
            this.lbl_indicator.Size = new System.Drawing.Size(10, 13);
            this.lbl_indicator.TabIndex = 8;
            this.lbl_indicator.Text = " ";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "green_dot.png");
            this.imageList.Images.SetKeyName(1, "red_dot.png");
            this.imageList.Images.SetKeyName(2, "yellow_dot.png");
            // 
            // FormNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 193);
            this.Controls.Add(this.lbl_indicator);
            this.Controls.Add(this.cx_viewpassword);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNewPassword";
            this.Text = "Welcome! - Arvato HRMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.CheckBox cx_viewpassword;
        private System.Windows.Forms.Label lbl_indicator;
        private System.Windows.Forms.ImageList imageList;
    }
}