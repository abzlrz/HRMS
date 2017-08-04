using System;
using System.Windows.Forms;

namespace UI
{
    public partial class EmployeeRegistrationForm : Form
    {
        public EmployeeRegistrationForm()
        {
            InitializeComponent();
            btnProceed.Click += (a, x) => EnableControls(true);
            btnReset.Click += (a, x) => EnableControls(false);
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
    }
}
