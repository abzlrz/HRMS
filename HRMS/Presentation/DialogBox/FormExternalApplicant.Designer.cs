namespace Presentation.DialogBox
{
    partial class FormExternalApplicant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.controlApplicationDetails1 = new Presentation.DialogBox.ExternalApplication.ControlApplicationDetails();
            this.controlOtherDetails1 = new Presentation.DialogBox.ExternalApplication.ControlBackgroundCheck();
            this.controlAddress1 = new Presentation.DialogBox.ExternalApplication.ControlAddress();
            this.controlPersonalInformation1 = new Presentation.DialogBox.ExternalApplication.ControlPersonalInformation();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_application = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 85);
            this.panel1.TabIndex = 79;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.arvato1;
            this.pictureBox1.Location = new System.Drawing.Point(499, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(30, 47);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(336, 13);
            this.label34.TabIndex = 1;
            this.label34.Text = "This will enable us to inform you about your application and evaluation";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(30, 23);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(201, 15);
            this.label33.TabIndex = 0;
            this.label33.Text = "Please fill-up this Application Form.";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // controlApplicationDetails1
            // 
            this.controlApplicationDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlApplicationDetails1.Location = new System.Drawing.Point(0, 182);
            this.controlApplicationDetails1.Name = "controlApplicationDetails1";
            this.controlApplicationDetails1.Next = this.controlOtherDetails1;
            this.controlApplicationDetails1.Padding = new System.Windows.Forms.Padding(12);
            this.controlApplicationDetails1.Previous = this.controlAddress1;
            this.controlApplicationDetails1.Size = new System.Drawing.Size(641, 535);
            this.controlApplicationDetails1.TabIndex = 81;
            // 
            // controlOtherDetails1
            // 
            this.controlOtherDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlOtherDetails1.Location = new System.Drawing.Point(0, 182);
            this.controlOtherDetails1.Name = "controlOtherDetails1";
            this.controlOtherDetails1.Padding = new System.Windows.Forms.Padding(12);
            this.controlOtherDetails1.Previous = this.controlApplicationDetails1;
            this.controlOtherDetails1.Size = new System.Drawing.Size(641, 535);
            this.controlOtherDetails1.TabIndex = 84;
            // 
            // controlAddress1
            // 
            this.controlAddress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlAddress1.Location = new System.Drawing.Point(0, 182);
            this.controlAddress1.Name = "controlAddress1";
            this.controlAddress1.Next = this.controlApplicationDetails1;
            this.controlAddress1.Padding = new System.Windows.Forms.Padding(12);
            this.controlAddress1.Previous = this.controlPersonalInformation1;
            this.controlAddress1.Size = new System.Drawing.Size(641, 535);
            this.controlAddress1.TabIndex = 82;
            // 
            // controlPersonalInformation1
            // 
            this.controlPersonalInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPersonalInformation1.Location = new System.Drawing.Point(0, 182);
            this.controlPersonalInformation1.Name = "controlPersonalInformation1";
            this.controlPersonalInformation1.Next = this.controlAddress1;
            this.controlPersonalInformation1.Padding = new System.Windows.Forms.Padding(12);
            this.controlPersonalInformation1.Size = new System.Drawing.Size(641, 535);
            this.controlPersonalInformation1.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(12);
            this.panel2.Size = new System.Drawing.Size(641, 97);
            this.panel2.TabIndex = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date_application);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 73);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Date";
            // 
            // date_application
            // 
            this.date_application.Location = new System.Drawing.Point(163, 30);
            this.date_application.Name = "date_application";
            this.date_application.Size = new System.Drawing.Size(321, 20);
            this.date_application.TabIndex = 0;
            // 
            // FormExternalApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 717);
            this.Controls.Add(this.controlPersonalInformation1);
            this.Controls.Add(this.controlAddress1);
            this.Controls.Add(this.controlApplicationDetails1);
            this.Controls.Add(this.controlOtherDetails1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExternalApplicant";
            this.Text = "Application Form";
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ImageList imageList;
        private ExternalApplication.ControlApplicationDetails controlApplicationDetails1;
        private ExternalApplication.ControlAddress controlAddress1;
        private ExternalApplication.ControlPersonalInformation controlPersonalInformation1;
        private ExternalApplication.ControlBackgroundCheck controlOtherDetails1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_application;
    }
}