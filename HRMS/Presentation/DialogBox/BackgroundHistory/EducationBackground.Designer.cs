﻿namespace Presentation.DialogBox.BackgroundHistory
{
    partial class EducationBackground
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.tbx_School = new System.Windows.Forms.TextBox();
            this.tbx_location = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.main.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 318);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(196, 256);
            this.dataGridView.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_remove);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 62);
            this.panel3.TabIndex = 3;
            // 
            // btn_remove
            // 
            this.btn_remove.Enabled = false;
            this.btn_remove.Location = new System.Drawing.Point(58, 11);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.removeClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(296, 256);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.addClick);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(296, 256);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.saveClick);
            // 
            // main
            // 
            this.main.Controls.Add(this.tableLayoutPanel6);
            this.main.Controls.Add(this.btn_add);
            this.main.Controls.Add(this.btn_save);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(208, 12);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(423, 318);
            this.main.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.01133F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.98867F));
            this.tableLayoutPanel6.Controls.Add(this.dt2, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.label27, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label31, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label32, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tbx_School, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbx_location, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.comboBox1, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.dt1, 1, 4);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 6;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(353, 201);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // dt2
            // 
            this.dt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt2.Location = new System.Drawing.Point(112, 150);
            this.dt2.Margin = new System.Windows.Forms.Padding(0);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(241, 20);
            this.dt2.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 112;
            this.label1.Text = "From Date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(112, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 111;
            this.textBox1.Tag = "required";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 90);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(106, 30);
            this.label27.TabIndex = 90;
            this.label27.Text = "Course/Program:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(106, 30);
            this.label31.TabIndex = 51;
            this.label31.Text = "School/University:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 30);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(106, 30);
            this.label32.TabIndex = 52;
            this.label32.Text = "Location:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(3, 60);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(106, 30);
            this.label35.TabIndex = 83;
            this.label35.Text = "Academic Degree:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbx_School
            // 
            this.tbx_School.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_School.Location = new System.Drawing.Point(112, 0);
            this.tbx_School.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_School.Name = "tbx_School";
            this.tbx_School.Size = new System.Drawing.Size(241, 20);
            this.tbx_School.TabIndex = 108;
            this.tbx_School.Tag = "required";
            // 
            // tbx_location
            // 
            this.tbx_location.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbx_location.Location = new System.Drawing.Point(112, 30);
            this.tbx_location.Margin = new System.Windows.Forms.Padding(0);
            this.tbx_location.Name = "tbx_location";
            this.tbx_location.Size = new System.Drawing.Size(241, 20);
            this.tbx_location.TabIndex = 109;
            this.tbx_location.Tag = "required";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Diploma",
            "Bachelor",
            "Masteral",
            "Doctorate",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(112, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 51);
            this.label2.TabIndex = 113;
            this.label2.Text = "To Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dt1
            // 
            this.dt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt1.Location = new System.Drawing.Point(112, 120);
            this.dt1.Margin = new System.Windows.Forms.Padding(0);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(241, 20);
            this.dt1.TabIndex = 114;
            // 
            // EducationBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.main);
            this.Controls.Add(this.panel2);
            this.Name = "EducationBackground";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(643, 342);
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbx_School;
        private System.Windows.Forms.TextBox tbx_location;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt1;
    }
}
