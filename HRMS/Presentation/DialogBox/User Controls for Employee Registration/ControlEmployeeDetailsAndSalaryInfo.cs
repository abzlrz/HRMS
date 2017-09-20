using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.EmployeeRegistration
{
    public partial class ControlEmployeeDetailsAndSalaryInfo : UserControl
    {
        public UserControl Previous { get; set; }

        public ControlEmployeeDetailsAndSalaryInfo()
        {
            InitializeComponent();
        }

        #region If fields are empty conditions
        private void cbx_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_team.SelectedIndex, lbl_team);
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
    }
}
