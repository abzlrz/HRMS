using System;
using System.Windows.Forms;

namespace UI
{
    public partial class TrainingFeedbackAssesmentForm : Form
    {
        public TrainingFeedbackAssesmentForm()
        {
            InitializeComponent();

            btnProceed.Click += (a, x) => EnableControl(true);
            btnReset.Click += (a, x) => ResetAll();
            btnChangeEmployee.Click += (a, x) => EnableControl(false);
        }

        void AddErrorMessage(string error)
        {
            
        }

        void EnableControl(bool arg)
        {
            gbxPerformance.Enabled = arg;
            gbxSummary.Enabled = arg;
            gbxShortlist.Enabled = !arg;
            gbxInfo.Enabled = !arg;
        }

        void ResetAll()
        {
            if (MessageBox.Show("The data you entered will be all reset. Are you sure?", "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                EnableControl(false);
                this.ClearAllFields();
            }
        }

        bool ValidateSelectedInfo()
        {
            throw new NotImplementedException();
        }
    }
}