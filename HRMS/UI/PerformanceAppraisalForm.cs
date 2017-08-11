using System;
using System.Windows.Forms;

namespace UI
{
    public partial class PerformanceAppraisalForm : Form
    {
        public PerformanceAppraisalForm()
        {
            InitializeComponent();

            btnProceed.Click += (a, x) => EnableControl(true);
            btnChangeEmployee.Click += (a, x) => EnableControl(false);
            btnReset.Click += (a, x) => ResetAll();
        }

        void AddErrorMessage(string error)
        {
            throw new NotImplementedException();
        }
        void EnableControl(bool arg)
        {
            gbxPeriod.Enabled = arg;
            gbxDescription.Enabled = arg;
            gbxInfo.Enabled = !arg;
            gbxEmployee.Enabled = !arg;
        }
        void ResetAll()
        {
            this.ClearAllFields();
            EnableControl(false);
        }
        bool ValidateSelectedInfo()
        {
            throw new NotImplementedException();
        }
    }
}
