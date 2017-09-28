namespace Presentation
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnApply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.x3 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApply.Location = new System.Drawing.Point(857, 378);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(402, 75);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Check Vacancies";
            this.tip.SetToolTip(this.btnApply, "Press F1");
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.OnApplyClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.tbx_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbx_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(61, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 674);
            this.panel1.TabIndex = 15;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(207, 477);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 67);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.OnClick);
            // 
            // tbx_password
            // 
            this.tbx_password.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbx_password.Location = new System.Drawing.Point(175, 411);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(232, 29);
            this.tbx_password.TabIndex = 1;
            this.tbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(249, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // tbx_username
            // 
            this.tbx_username.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbx_username.Location = new System.Drawing.Point(175, 345);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(232, 29);
            this.tbx_username.TabIndex = 0;
            this.tbx_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(249, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.Transparent;
            this.x3.Dock = System.Windows.Forms.DockStyle.Right;
            this.x3.FlatAppearance.BorderSize = 0;
            this.x3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(151)))), ((int)(((byte)(206)))));
            this.x3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x3.ForeColor = System.Drawing.Color.Transparent;
            this.x3.Image = global::Presentation.Properties.Resources.exit;
            this.x3.Location = new System.Drawing.Point(1335, 0);
            this.x3.Margin = new System.Windows.Forms.Padding(0);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(27, 24);
            this.x3.TabIndex = 3;
            this.tip.SetToolTip(this.x3, "Close");
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.closeClick);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.Color.Transparent;
            this.x2.Dock = System.Windows.Forms.DockStyle.Right;
            this.x2.FlatAppearance.BorderSize = 0;
            this.x2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(151)))), ((int)(((byte)(206)))));
            this.x2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x2.ForeColor = System.Drawing.Color.Transparent;
            this.x2.Image = global::Presentation.Properties.Resources.restore;
            this.x2.Location = new System.Drawing.Point(1308, 0);
            this.x2.Margin = new System.Windows.Forms.Padding(0);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(27, 24);
            this.x2.TabIndex = 4;
            this.tip.SetToolTip(this.x2, "Restore Down");
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.restoreDownClick);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.Color.Transparent;
            this.x1.Dock = System.Windows.Forms.DockStyle.Right;
            this.x1.FlatAppearance.BorderSize = 0;
            this.x1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(151)))), ((int)(((byte)(206)))));
            this.x1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x1.ForeColor = System.Drawing.Color.Transparent;
            this.x1.Image = global::Presentation.Properties.Resources.minimize;
            this.x1.Location = new System.Drawing.Point(1281, 0);
            this.x1.Margin = new System.Windows.Forms.Padding(0);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(27, 24);
            this.x1.TabIndex = 5;
            this.tip.SetToolTip(this.x1, "Minimize");
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.minimizeClick);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(169)))));
            this.header.Controls.Add(this.label3);
            this.header.Controls.Add(this.x1);
            this.header.Controls.Add(this.x2);
            this.header.Controls.Add(this.x3);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1362, 24);
            this.header.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "  Login - Arvato HRMS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentation.Properties.Resources.arvato_feet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.header);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Label label3;
    }
}