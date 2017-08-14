using System;
using System.Windows.Forms;
using UI.SubForms;

namespace UI
{
    public partial class EmployeeRegistrationForm : Form
    {
        private TrainingScheduleDialogBox trainingSchedForm = new TrainingScheduleDialogBox();
        public EmployeeRegistrationForm()
        {
            InitializeComponent();
            btnProceed.Click += (a, x) => EnableControls(true);
            btnReset.Click += (a, x) => {
                EnableControls(false);
                this.ClearAllFields();
            };
            btnChangeEmployee.Click += (a, x) => EnableControls(false);
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

        private void OnRegisterClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Schedule for training?", "Schedule?",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                trainingSchedForm.ShowDialog();
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
