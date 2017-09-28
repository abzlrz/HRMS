using Data.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlPersonalInformation : UserControl
    {
        #region properties
        public UserControl Next { get; set; }
        #endregion

        #region fields
        public Applicant applicant;
        private bool isUnder18 = false;
        #endregion

        public ControlPersonalInformation()
        {
            InitializeComponent();
            this.applicant = new Applicant();
        }

        #region methods
        private bool ValidateFields()
        {
            bool result = true;

            if (lbl_fname.ImageIndex == 1)
                result = false;
            if (lbl_midName.ImageIndex == 1)
                result = false;
            if (lbl_lastName.ImageIndex == 1)
                result = false;
            if (lbl_primaryContact.ImageIndex == 1)
                result = false;
            if (lbl_isUnder18.ImageIndex == 1)
                result = false;

            return result;
        }
        public void ClearAllFields()
        {
            tbx_firstName.ResetText();
            tbx_midname.ResetText();
            tbx_lastName.ResetText();
            tbx_nickname.ResetText();
            tbx_primaryContact.ResetText();
            tbx_secondaryContact.ResetText();
            cbx_isUnder18.SelectedIndex = -1;
            tbx_email.ResetText();
            tbx_SSS.ResetText();
            tbx_TIN.ResetText();
            tbx_HDMF.ResetText();
            tbx_bankAccnt.ResetText();
        }
        #endregion

        #region buttons
        private void btn_clear_Click(object sender, System.EventArgs e)
        {
            ClearAllFields();
        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
                //
                // external applicant
                //
                this.applicant.Firstname = tbx_firstName.Text;
                this.applicant.Middlename = tbx_midname.Text;
                this.applicant.Lastname = tbx_lastName.Text;
                this.applicant.Nickname = tbx_nickname.Text;
                this.applicant.PrimaryContactNumber = tbx_primaryContact.Text;
                this.applicant.SecondaryContactNumber = tbx_primaryContact.Text;
                this.applicant.IsUnder18 = isUnder18;
                this.applicant.Email = tbx_email.Text;
                this.applicant.SSS = tbx_SSS.Text;
                this.applicant.TIN = tbx_TIN.Text;
                this.applicant.HDMF = tbx_HDMF.Text;
                this.applicant.BankAccount = tbx_bankAccnt.Text;
                this.applicant.ApplicationDate = DateTime.Today;

                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region If fields are empty conditions

        private void tbx_firstName_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_firstName.Text, lbl_fname);
        }

        private void tbx_midname_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_midname.Text, lbl_midName);
        }

        private void tbx_lastName_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_lastName.Text, lbl_lastName);
        }

        private void tbx_primaryContact_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_primaryContact.Text, lbl_primaryContact);
        }

        private void cbx_isUnder18_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_isUnder18.Text, lbl_isUnder18);
        }
        #endregion

        private void cbx_isUnder18_TextChanged(object sender, System.EventArgs e)
        {
            isUnder18 = cbx_isUnder18.Equals("Yes") ? true : false;
        }
    }
}
