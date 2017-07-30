using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void OnApplicationClick(object sender, EventArgs e)
        {
            application.ShowDialog();
        }
    }
}
