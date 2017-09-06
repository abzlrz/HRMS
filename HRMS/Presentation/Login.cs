using Presentation.DialogBox;
using System;
using System.Drawing;
using System.Windows.Forms;
using Data.Access;
using Data.Entities;

namespace Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.panel1.BackColor = Color.FromArgb(150, ArvatoBlue);
            this.applicationForm = new ApplicationForm();
            this.main = new Main();
            this.access = new UserAccess("Data Source=.;Initial Catalog=HRMS;Integrated Security=True");

            this.user = new User();
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            try
            {
                this.user.Username = tbx_username.Text;
                this.user.Password = tbx_password.Text;

                if (access.Login(user))
                {
                    this.main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is Invalid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnApplyClick(object sender, System.EventArgs e)
        {
            this.applicationForm.ShowDialog();
        }
        private void exitClick(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private Color ArvatoBlue = Color.FromArgb(0, 104, 169);
        private Color ArvatoGreen = Color.FromArgb(176, 200, 0);
        private Color ArvatoRed = Color.FromArgb(233, 15, 64);
        private ApplicationForm applicationForm;
        private Main main;
        private UserAccess access;
        private User user;
    }
}
