using Data.Access;
using Data.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExistingEmployeeRegistration
{
    public partial class ControlSalaryInfo : UserControl
    {
        public EmployeeSalaryInfo salaryInfo;
        public EmployeeAccess access;
        public UserControl Previous { get; set; }
        public int ID;

        public ControlSalaryInfo()
        {
            InitializeComponent();
            this.salaryInfo = new EmployeeSalaryInfo();
            this.access = new EmployeeAccess();
        }

        public bool ValidateFields()
        {
            bool result = true;

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
        public void LoadInputs()
        {
            salaryInfo = new EmployeeSalaryInfo()
            {
                DateApproved = date_approved.Value,
                DateAccepted = date_accepted.Value,
                DateStarted = date_started.Value,
                ApprovedSalary = IsNoValue(tbx_approvedSalary.Text)? 0 : decimal.Parse(tbx_approvedSalary.Text),
                AnnualBasedSalary = IsNoValue(tbx_annualBasedSalary.Text)? 0 : decimal.Parse(tbx_annualBasedSalary.Text),
                AnnualLanguageAllowance = IsNoValue(tbx_annualLangAllowance.Text)? 0 : decimal.Parse(tbx_annualLangAllowance.Text),
                ShiftAllowance = IsNoValue(tbx_shiftAllowance.Text)? 0 : decimal.Parse(tbx_shiftAllowance.Text),
                RelocationAllowance = IsNoValue(tbx_relocAllowance.Text)? 0 : decimal.Parse(tbx_relocAllowance.Text),
                RelocationAllowanceDetail = tbx_relocAllowanceDetails.Text,
                CostCentre = IsNoValue(tbx_costCenter.Text) ? 0 : decimal.Parse(tbx_costCenter.Text)
            };
        }

        private bool IsNoValue(string text)
        {
            bool result = false;

            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
                result = true;

            return result;
        }
        public void ClearAllFields()
        {
            this.date_accepted.ResetText();
            this.date_approved.ResetText();
            this.tbx_annualBasedSalary.ResetText();
            this.tbx_annualLangAllowance.ResetText();
            this.tbx_approvedSalary.ResetText();
            this.tbx_costCenter.ResetText();
            this.tbx_relocAllowance.ResetText();
            this.tbx_relocAllowanceDetails.ResetText();
            this.tbx_shiftAllowance.ResetText();
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
            ClearAllFields();
        }
        #endregion

        private void OnLoad(object sender, EventArgs e)
        {
            if(ID > 0)
            {
                DataRow row = access.GetSalaryInfo(ID);

                date_approved.Value = CheckDateApproved(row["DateApproved"].ToString());
                date_accepted.Value = CheckDateApproved(row["DateAccepted"].ToString());
                date_started.Value = CheckDateApproved(row["DateStarted"].ToString());
                tbx_approvedSalary.Text = row["ApprovedSalary"].ToString();
                tbx_annualBasedSalary.Text = row["AnnualBasedSalary"].ToString();
                tbx_annualLangAllowance.Text = row["AnnualLanguageAllowance"].ToString();
                tbx_shiftAllowance.Text = row["ShiftAllowance"].ToString();
                tbx_relocAllowance.Text = row["RelocationAllowance"].ToString();
                tbx_relocAllowanceDetails.Text = row["RelocationAllowanceDetail"].ToString();
                tbx_costCenter.Text = row["CostCentre"].ToString();
            }
        }

        public DateTime CheckDateApproved(string value)
        {
            try
            {
                return DateTime.Parse(value);
            }
            catch
            {
                return DateTime.Today;
            }
        }
    }
}
