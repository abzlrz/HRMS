using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExistingEmployeeRegistration
{
    public partial class ControlEmployeeInfo : UserControl
    {
        public Employee employee;
        public EmployeeAddress address;
        public UserControl Next { get; set; }
        
        public ControlEmployeeInfo()
        {
            InitializeComponent();
            this.employee = new Employee();
            this.address = new EmployeeAddress();
        }
        private bool ValidateFields()
        {
            bool result = true;

            if (lbl_firstname.ImageIndex == 1)
                result = false;
            if (lbl_lastname.ImageIndex == 1)
                result = false;
            if (lbl_primaryContact.ImageIndex == 1)
                result = false;
            if (lbl_maritalStatus.ImageIndex == 1)
                result = false;
            if (lbl_email.ImageIndex == 1)
                result = false;
            if (lbl_presentStreet.ImageIndex == 1)
                result = false;
            if (lbl_presentPostalArea.ImageIndex == 1)
                result = false;
            if (lbl_presentPostalNo.ImageIndex == 1)
                result = false;

            if (lbl_sss.ImageIndex == 1)
                result = false;
            if (lbl_tin.ImageIndex == 1)
                result = false;
            if (lbl_hdmf.ImageIndex == 1)
                result = false;
            if (lbl_bpi.ImageIndex == 1)
                result = false;

            return result;
        }
        public void ClearAllFields()
        {
            this.tbx_firstname.ResetText();
            this.tbx_middlename.ResetText();
            this.tbx_lastname.ResetText();
            this.tbx_primaryContact.ResetText();
            this.tbx_secondaryContact.ResetText();
            this.cbx_maritalStatus.SelectedIndex = -1;
            this.tbx_email.ResetText();
            this.tbx_SSS.ResetText();
            this.tbx_TIN.ResetText();
            this.tbx_HDMF.ResetText();
            this.tbx_BPI.ResetText();
            this.tbx_presentAddNo.ResetText();
            this.tbx_presentAddStreet.ResetText();
            this.tbx_presentPostalArea.ResetText();
            this.tbx_presentPostalNo.ResetText();
        }
        
        #region Buttons
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //
                // employee info
                //
                this.employee.Firstname = tbx_firstname.Text;
                this.employee.Middlename = tbx_middlename.Text;
                this.employee.Lastname = tbx_lastname.Text;
                this.employee.PrimaryContact = tbx_primaryContact.Text;
                this.employee.SecondaryContact = tbx_secondaryContact.Text;
                this.employee.MaritalStatus = cbx_maritalStatus.Text;
                this.employee.Email = tbx_email.Text;
                this.employee.SSS = tbx_SSS.Text;
                this.employee.TIN = tbx_TIN.Text;
                this.employee.HDMF = tbx_HDMF.Text;
                this.employee.BPICard = tbx_BPI.Text;
                //
                // employee address
                //
                this.address.HouseNo = tbx_presentAddNo.Text;
                this.address.Street = tbx_presentAddStreet.Text;
                this.address.PostalArea = tbx_presentPostalArea.Text;
                this.address.PostalNo = tbx_presentPostalNo.Text;

                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Fill up all the required fields.");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
        #endregion

        #region If fields are empty conditions
        private void tbx_firstname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_firstname.Text, lbl_firstname);
        }
        
        private void tbx_lastname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_lastname.Text, lbl_lastname);
        }

        private void tbx_primaryContact_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_primaryContact, lbl_primaryContact, true);
        }

        private void cbx_maritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_maritalStatus.SelectedIndex, lbl_maritalStatus);
        }

        private void tbx_email_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_email.Text, lbl_email);
        }

        private void tbx_presentAddNo_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_presentAddNo.Text, lbl_presentAddNo);
        }

        private void tbx_presentAddStreet_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_presentAddStreet.Text, lbl_presentStreet);
        }

        private void tbx_presentPostalArea_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_presentPostalArea.Text, lbl_presentPostalArea);
        }

        private void tbx_presentPostalNo_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_presentPostalNo.Text, lbl_presentPostalNo);
        }
        #endregion

        private void tbx_SSS_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_SSS, lbl_sss, false);
        }

        private void tbx_TIN_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_TIN, lbl_tin, false);
        }

        private void tbx_HDMF_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_HDMF, lbl_hdmf, false);
        }

        private void tbx_BPI_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_BPI, lbl_bpi, false);
        }

        private void tbx_secondaryContact_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_secondaryContact, lbl_secondaryContact, false);
        }
    }
}
