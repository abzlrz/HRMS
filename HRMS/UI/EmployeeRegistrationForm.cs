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
    public partial class EmployeeRegistrationForm : Form
    {
        public EmployeeRegistrationForm()
        {
            InitializeComponent();
        }
        private void EnableControls(bool arg)
        {
            gbxSalaryInfo.Enabled = arg;
            gbxAppSource.Enabled = arg;
            btnReset.Enabled = arg;
            btnRegister.Enabled = arg;
            gbxAppInfo.Enabled = !arg;
            gbxEvaluationInfo.Enabled = !arg;
            gbxShortlist.Enabled = !arg;
        }
        private void OnProceedClick(object sender, EventArgs e)
        {
            EnableControls(true);
        }

        private void OnResetClick(object sender, EventArgs e)
        {
            EnableControls(false);
        }
    }
}
