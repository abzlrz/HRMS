namespace Presentation.View
{
    partial class ControlTraining
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TrainingSchedule = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TrainingFeedback = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxAppliedBefore = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TrainingSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.TrainingFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TrainingSchedule);
            this.tabControl1.Controls.Add(this.TrainingFeedback);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1106, 471);
            this.tabControl1.TabIndex = 1;
            // 
            // TrainingSchedule
            // 
            this.TrainingSchedule.Controls.Add(this.dataGridView1);
            this.TrainingSchedule.Controls.Add(this.panel1);
            this.TrainingSchedule.Location = new System.Drawing.Point(4, 22);
            this.TrainingSchedule.Name = "TrainingSchedule";
            this.TrainingSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.TrainingSchedule.Size = new System.Drawing.Size(1098, 445);
            this.TrainingSchedule.TabIndex = 0;
            this.TrainingSchedule.Text = "Training Schedule";
            this.TrainingSchedule.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1092, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 48);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Firstname",
            "Lastname",
            "Date Evaluated",
            "Job Title"});
            this.comboBox1.Location = new System.Drawing.Point(218, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Tag = "required";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 5;
            // 
            // TrainingFeedback
            // 
            this.TrainingFeedback.Controls.Add(this.dataGridView2);
            this.TrainingFeedback.Controls.Add(this.panel2);
            this.TrainingFeedback.Location = new System.Drawing.Point(4, 22);
            this.TrainingFeedback.Name = "TrainingFeedback";
            this.TrainingFeedback.Padding = new System.Windows.Forms.Padding(3);
            this.TrainingFeedback.Size = new System.Drawing.Size(1098, 445);
            this.TrainingFeedback.TabIndex = 1;
            this.TrainingFeedback.Text = "Training Feedback";
            this.TrainingFeedback.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1092, 391);
            this.dataGridView2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxAppliedBefore);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 48);
            this.panel2.TabIndex = 3;
            // 
            // cbxAppliedBefore
            // 
            this.cbxAppliedBefore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAppliedBefore.FormattingEnabled = true;
            this.cbxAppliedBefore.Items.AddRange(new object[] {
            "ID",
            "Firstname",
            "Lastname",
            "Date Evaluated",
            "Job Title"});
            this.cbxAppliedBefore.Location = new System.Drawing.Point(218, 14);
            this.cbxAppliedBefore.Name = "cbxAppliedBefore";
            this.cbxAppliedBefore.Size = new System.Drawing.Size(146, 21);
            this.cbxAppliedBefore.TabIndex = 2;
            this.cbxAppliedBefore.Tag = "required";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 20);
            this.textBox2.TabIndex = 3;
            // 
            // ControlTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ControlTraining";
            this.Size = new System.Drawing.Size(1106, 471);
            this.tabControl1.ResumeLayout(false);
            this.TrainingSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TrainingFeedback.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TrainingSchedule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage TrainingFeedback;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxAppliedBefore;
        private System.Windows.Forms.TextBox textBox2;
    }
}
