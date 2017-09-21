using Data.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlPersonalInformation : UserControl
    {
        #region properties
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }
        #endregion

        #region fields
        public Applicant applicant;
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
        #endregion

        #region buttons
        private void btn_clear_Click(object sender, System.EventArgs e)
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

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
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
    }
}
