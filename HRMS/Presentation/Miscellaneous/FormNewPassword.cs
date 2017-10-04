using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Miscellaneous
{
    public partial class FormNewPassword : Form
    {
        private int minlength = 8;
        public FormNewPassword()
        {
            InitializeComponent();
        }
        
        private void tbx_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_password.Text, lbl_indicator, minlength);
        }

        private void cx_viewpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cx_viewpassword.Checked)
                tbx_password.UseSystemPasswordChar = false;
            else
                tbx_password.UseSystemPasswordChar = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(lbl_indicator.ImageIndex == 1)
                MessageBox.Show("Must be atleast " + minlength + " characters of length.");
        }
    }
}
