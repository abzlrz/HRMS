using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExistingEmployeeRegistration
{
    public partial class ControlSalaryInfo : UserControl
    {
        private EmployeeSalaryInfo _salaryInfo;
        public UserControl Previous { get; set; }

        public ControlSalaryInfo()
        {
            InitializeComponent();
        }

        public EmployeeSalaryInfo GetSalaryInfo()
        {
            return this._salaryInfo = new EmployeeSalaryInfo()
            {
                DateApproved = date_approved.Value,
                DateAccepted = date_accepted.Value,
                DateStarted = date_started.Value,
                ApprovedSalary = decimal.Parse(tbx_approvedSalary.Text),
                AnnualBasedSalary = decimal.Parse(tbx_annualBasedSalary.Text),
                AnnualLanguageAllowance = decimal.Parse(tbx_annualLangAllowance.Text),
                ShiftAllowance = decimal.Parse(tbx_shiftAllowance.Text),
                RelocationAllowance = decimal.Parse(tbx_relocAllowance.Text),
                RelocationAllowanceDetail = decimal.Parse(tbx_relocAllowanceDetails.Text),
                CostCentre = decimal.Parse(tbx_costCenter.Text)
            };
        }

        bool ValidateFields()
        {
            bool result = false;

            if (lbl_dateApproved.ImageIndex == 1)
                result = false;
            if (lbl_dateAccepted.ImageIndex == 1)
                result = false;
            if (lbl_dateStarted.ImageIndex == 1)
                result = false;
            if (lbl_approvedSalary.ImageIndex == 1)
                result = false;
            if (lbl_annualBasedSalary.ImageIndex == 1)
                result = false;
            if (lbl_annualLangAllowance.ImageIndex == 1)
                result = false;
            if (lbl_shiftAllowance.ImageIndex == 1)
                result = false;

            return result;
        }

        #region If fields are empty conditions
        private void date_approved_ValueChanged(object sender, EventArgs e)
        {
            lbl_dateApproved.ImageIndex = 0;
        }

        private void date_accepted_ValueChanged(object sender, EventArgs e)
        {
            lbl_dateAccepted.ImageIndex = 0;
        }

        private void date_started_ValueChanged(object sender, EventArgs e)
        {
            lbl_dateStarted.ImageIndex = 0;
        }

        private void tbx_approvedSalary_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_approvedSalary.Text, lbl_approvedSalary);
        }

        private void tbx_annualBasedSalary_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_annualBasedSalary.Text, lbl_annualBasedSalary);
        }

        private void tbx_annualLangAllowance_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_annualLangAllowance.Text, lbl_annualLangAllowance);
        }

        private void tbx_shiftAllowance_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_shiftAllowance.Text, lbl_shiftAllowance);
        }
        #endregion

        #region Buttons
        private void btn_previous_Click(object sender, EventArgs e)
        {
            Previous.BringToFront();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            date_accepted.ResetText();
            date_approved.ResetText();
            tbx_annualBasedSalary.ResetText();
            tbx_annualLangAllowance.ResetText();
            tbx_approvedSalary.ResetText();
            tbx_costCenter.ResetText();
            tbx_relocAllowance.ResetText();
            tbx_relocAllowanceDetails.ResetText();
            tbx_shiftAllowance.ResetText();
        }
        #endregion
    }
}
