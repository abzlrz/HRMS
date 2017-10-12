using Data.Access;
using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.EmployeeRegistration
{
    public partial class ControlEmployeeDetailsAndSalaryInfo : UserControl
    {
        private DataAccess access;
        public UserControl Previous { get; set; }
        public EmployeeSalaryInfo salary_info;
        public EmployeeTeam team;
        public EmployeeContractType contract_type;
        public int ID;

        public ControlEmployeeDetailsAndSalaryInfo()
        {
            InitializeComponent();
            this.access = new DataAccess();
        }
        public void GetValues()
        {
            this.team = new EmployeeTeam()
            {
                Team = cbx_team.Text
            };
            this.contract_type = new EmployeeContractType()
            {
                ContractType = cbx_contract.Text
            };
            this.salary_info = new EmployeeSalaryInfo()
            {
                DateApproved = date_approved.Value,
                DateAccepted = date_accepted.Value,
                DateStarted = date_started.Value,
                ApprovedSalary = IsNoValue(tbx_approvedSalary.Text) ? 0 : decimal.Parse(tbx_approvedSalary.Text),
                AnnualBasedSalary = IsNoValue(tbx_annualBasedSalary.Text) ? 0 : decimal.Parse(tbx_annualBasedSalary.Text),
                AnnualLanguageAllowance = IsNoValue(tbx_annualLangAllowance.Text) ? 0 : decimal.Parse(tbx_annualLangAllowance.Text),
                ShiftAllowance = IsNoValue(tbx_shiftAllowance.Text) ? 0 : decimal.Parse(tbx_shiftAllowance.Text),
                RelocationAllowance = IsNoValue(tbx_relocAllowance.Text) ? 0 : decimal.Parse(tbx_relocAllowance.Text),
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

        #region If fields are empty conditions
        private void cbx_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_team.SelectedIndex, lbl_team);
        }

        public bool ValidateFields()
        {
            bool result = true;

            if (lbl_team.ImageIndex == 1)
                result = false;
            if (lbl_contractType.ImageIndex == 1)
                result = false;
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

            return result;
        }

        private void cbx_contract_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_contract.SelectedIndex, lbl_contractType);
        }

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
            cbx_contract.SelectedIndex = -1;
            cbx_team.SelectedIndex = -1;
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

        private void OnLoad(object sender, EventArgs e)
        {
            this.cbx_team.DisplayMember = "Description";
            this.cbx_team.ValueMember = "Description";
            this.cbx_team.DataSource = access.ShowTeamData();

            this.cbx_contract.DisplayMember = "Type";
            this.cbx_contract.ValueMember = "Type";
            this.cbx_contract.DataSource = access.ShowContractType();
        }
    }
}
