using System;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        private ApplicationForm application = new ApplicationForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnBtnApplicationClick(object sender, EventArgs e)
        {
            application.ShowDialog();
        }
    }
}
