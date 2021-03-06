﻿using Presentation.DialogBox;
using System;
using System.Drawing;
using System.Windows.Forms;
using Data.Access;
using Data.Entities;
using Presentation.Maintenance;
using static Presentation.Properties.Settings;
using System.Data;
using System.Data.SqlClient;

namespace Presentation
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
            this.form_main = new FormMain();
            //
            // employee user info
            this.access_employee = new EmployeeAccess();

            // user acces begin here
            this.access = new UserAccess();

            // draggable flowlayoutpanel
            this.draggable = new Draggable(header, this);

            this.user = new User();

            // reduce flicker
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            // user management
            this.form_userManagement = new FormUserManagement();

            //clearance login
            this.form_loginclearance = new FormClearanceLogin(this);

            //check vancancies
            this.form_vacancies = new FormCheckVacancies();
        }
        private void ImplementDraggable()
        {
            this.header.MouseMove += draggable.Move;
            this.header.MouseDown += draggable.Down;
            this.header.MouseUp += draggable.Up;
        }
        private void RestoreDown()
        {
            // 
            // panel1
            // 
            this.panel1.Location = new Point(12, 39);
            this.panel1.Size = new Size(353, 466);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new Point(95, 355);
            this.btnLogin.Size = new Size(170, 67);
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new Point(63, 289);
            this.tbx_password.Size = new Size(232, 29);
            this.tbx_password.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(137, 264);
            this.label2.Size = new Size(76, 21);
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new Point(63, 223);
            this.tbx_username.Size = new Size(232, 29);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 198);
            this.label1.Size = new System.Drawing.Size(81, 21);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Point(40, 35);
            this.pictureBox1.Size = new Size(280, 130);
            // 
            // btnApply
            // 
            this.btnApply.Location = new Point(421, 209);
            this.btnApply.Size = new Size(270, 75);
            this.btnApply.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form
            //
            this.Size = new Size(759, 520);
            this.WindowState = FormWindowState.Normal;
            this.Location = new Point(152, 223);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
            //
            // x2
            //
            this.tip.SetToolTip(this.x2, "Maximize");
        }
        private void Maximize()
        {
            // 
            // panel1
            // 
            this.panel1.Location = new Point(61, 54);
            this.panel1.Size = new Size(566, 674);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new Point(207, 477);
            this.btnLogin.Size = new Size(170, 67);
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new Point(175, 411);
            this.tbx_password.Size = new Size(232, 29);
            this.tbx_password.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(249, 386);
            this.label2.Size = new Size(232, 29);
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new Point(175, 345);
            this.tbx_username.Size = new Size(232, 29);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(249, 320);
            this.label1.Size = new System.Drawing.Size(81, 21);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Point(152, 157);
            this.pictureBox1.Size = new Size(280, 130);
            // 
            // btnApply
            // 
            this.btnApply.Location = new Point(857, 378);
            this.btnApply.Size = new Size(402, 75);
            this.btnApply.Font = new Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form2
            //
            this.Size = new Size(1366, 768);
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(152, 223);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
            //
            // x2
            //
            this.tip.SetToolTip(this.x2, "Restore Down");
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            try
            {
                this.user.Username = tbx_username.Text;
                this.user.Password = tbx_password.Text;

                if (access.Login(user))
                {
                    DataRow row = access.GetUserByID(int.Parse(user.Username));
                    DataRow row_user = access_employee.GetEmployeeInfo(int.Parse(user.Username));

                    Default.UserAccessType = row["TitanTitle"].ToString();
                    Default.EmployeeID = user.Username;
                    Default.UserFirstname = row_user["Firstname"].ToString();
                    Default.UserLastname = row_user["Lastname"].ToString();

                    this.form_main.ShowDialog();
                    this.Hide();
                }
                else if(tbx_username.Text.Equals(Default.username3086) 
                    && tbx_password.Text.Equals(Default.password3086))
                {
                    Default.UserAccessType = "Admin";
                    this.form_main.Show();
                    this.Hide();
                }
                else
                {
                    if(attempts == 0)
                    {
                        MessageBox.Show("You've been locked!");
                        form_loginclearance.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is Invalid");
                        attempts--;
                    }
                }
            }
            catch
            {
                if (attempts == 0)
                {
                    form_loginclearance.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username or Password is Invalid");
                    attempts--;
                }
            }
        }

        private void OnApplyClick(object sender, System.EventArgs e)
        {
            this.form_vacancies.ShowDialog();
        }
        private void restoreDownClick(object sender, EventArgs e)
        {
            clicked = !clicked;

            if (clicked)
            {
                this.x2.Image = Properties.Resources.max;
                ImplementDraggable();
                RestoreDown();
            }
            else
            {
                this.x2.Image = Properties.Resources.restore;
                Maximize();

            }
        }
        private void closeClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private Color ArvatoBlue = Color.FromArgb(0, 104, 169);
        private Color ArvatoGreen = Color.FromArgb(176, 200, 0);
        private Color ArvatoRed = Color.FromArgb(233, 15, 64);
        private Draggable draggable;
        
        private FormUserManagement form_userManagement;
        private FormClearanceLogin form_loginclearance;
        private FormCheckVacancies form_vacancies;
        private FormMain form_main;

        private UserAccess access;
        private EmployeeAccess access_employee;
        private User user;
        private int attempts = 4;
        
        private bool clicked = false;
    }
}