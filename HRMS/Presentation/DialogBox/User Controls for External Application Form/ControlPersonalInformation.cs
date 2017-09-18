using Data.Entities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlPersonalInformation : UserControl
    {
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }

        public Applicant applicant;
        public ControlPersonalInformation()
        {
            InitializeComponent();
            this.applicant = new Applicant();
        }

        public bool ValidateFields()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbx_firstName.Text) || string.IsNullOrWhiteSpace(tbx_firstName.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_midname.Text) || string.IsNullOrWhiteSpace(tbx_midname.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_lastName.Text) || string.IsNullOrWhiteSpace(tbx_lastName.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_firstName.Text) || string.IsNullOrWhiteSpace(tbx_firstName.Text))
                result = false;
            if (string.IsNullOrEmpty(tbx_primaryContact.Text) || string.IsNullOrWhiteSpace(tbx_primaryContact.Text))
                result = false;
            if (cbx_isUnder18.SelectedIndex == -1)
                result = false;

            return result;
        }

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
            Next.BringToFront();
        }

        #region If fields are empty conditions

        private void tbx_firstName_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_firstName.Text) || string.IsNullOrWhiteSpace(tbx_firstName.Text))
                lbl_fname.ImageIndex = 1;
            else
                lbl_fname.ImageIndex = 0;
        }

        private void tbx_midname_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_midname.Text) || string.IsNullOrWhiteSpace(tbx_midname.Text))
                lbl_midName.ImageIndex = 1;
            else
                lbl_midName.ImageIndex = 0;
        }

        private void tbx_lastName_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_lastName.Text) || string.IsNullOrWhiteSpace(tbx_lastName.Text))
                lbl_lastName.ImageIndex = 1;
            else
                lbl_lastName.ImageIndex = 0;
        }

        private void tbx_primaryContact_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_primaryContact.Text) || string.IsNullOrWhiteSpace(tbx_primaryContact.Text))
                lbl_primaryContact.ImageIndex = 1;
            else
                lbl_primaryContact.ImageIndex = 0;
        }

        private void cbx_isUnder18_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbx_isUnder18.SelectedIndex == -1)
                lbl_isUnder18.ImageIndex = 1;
            else
                lbl_isUnder18.ImageIndex = 0;
        }
        #endregion

        
    }
}
