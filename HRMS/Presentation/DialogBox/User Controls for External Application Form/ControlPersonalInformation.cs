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
        private bool sss = false;
        private bool tin = false;
        private bool hdmf = false;
        private bool bpi = false;
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


            if (sss)
            {
                if (lbl_sss.ImageIndex == 1)
                    result = false;
                else
                    result = true;
            }



            if (tin)
            {
                if (lbl_tin.ImageIndex == 1)
                    result = false;
                else
                    result = true;
            }



            if (hdmf)
            {
                if (lbl_hdmf.ImageIndex == 1)
                    result = false;
                else
                    result = true;
            }


            if (bpi)
            {
                if (lbl_bpi.ImageIndex == 1)
                    result = false;
                else
                    result = true;
            }


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

        private void tbx_lastName_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_lastName.Text, lbl_lastName);
        }

        private void tbx_primaryContact_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_primaryContact, lbl_primaryContact);
        }

        private void cbx_isUnder18_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_isUnder18.SelectedIndex, lbl_isUnder18);
        }

        private void cbx_isUnder18_TextChanged(object sender, System.EventArgs e)
        {
            isUnder18 = cbx_isUnder18.Equals("Yes") ? true : false;
        }

        private void cx_sss_CheckedChanged(object sender, EventArgs e)
        {
            if (cx_sss.Checked)
            {
                sss = true;
                tbx_SSS.Enabled = true;
                lbl_sss.ImageIndex = 1;
            }
            else
            {
                sss = false;
                tbx_SSS.Enabled = false;
                lbl_sss.ImageIndex = -1;
                tbx_SSS.Text = string.Empty;
            }
        }

        private void cx_tin_CheckedChanged(object sender, EventArgs e)
        {
            if (cx_tin.Checked)
            {
                tin = true;
                tbx_TIN.Enabled = true;
                lbl_tin.ImageIndex = 1;
            }
            else
            {
                tin = false;
                tbx_TIN.Enabled = false;
                lbl_tin.ImageIndex = -1;
                tbx_TIN.Text = string.Empty;
            }
        }

        private void cx_hdmf_CheckedChanged(object sender, EventArgs e)
        {
            if (cx_hdmf.Checked)
            {
                hdmf = true;
                tbx_HDMF.Enabled = true;
                lbl_hdmf.ImageIndex = 1;
            }
            else
            {
                hdmf = false;
                tbx_HDMF.Enabled = false;
                lbl_hdmf.ImageIndex = -1;
                tbx_HDMF.Text = string.Empty;
            }
        }

        private void cx_bpi_CheckedChanged(object sender, EventArgs e)
        {
            if (cx_bpi.Checked)
            {
                bpi = true;
                tbx_bankAccnt.Enabled = true;
                lbl_bpi.ImageIndex = 1;
            }
            else
            {
                bpi = false;
                tbx_bankAccnt.Enabled = false;
                lbl_bpi.ImageIndex = -1;
                tbx_bankAccnt.Text = string.Empty;
            }
        }
        #endregion

        private void tbx_SSS_TextChanged(object sender, EventArgs e)
        {
            if (sss)
                Misc.TurnGreenIndicator(tbx_SSS, lbl_sss);
        }

        private void tbx_TIN_TextChanged(object sender, EventArgs e)
        {
            if (tin)
                Misc.TurnGreenIndicator(tbx_TIN, lbl_tin);
        }

        private void tbx_HDMF_TextChanged(object sender, EventArgs e)
        {
            if (hdmf)
                Misc.TurnGreenIndicator(tbx_HDMF, lbl_hdmf);
        }

        private void tbx_bankAccnt_TextChanged(object sender, EventArgs e)
        {
            if (bpi)
                Misc.TurnGreenIndicator(tbx_bankAccnt, lbl_bpi);
        }
    }
}
