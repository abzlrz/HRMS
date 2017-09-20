using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExistingEmployeeRegistration
{
    public partial class ControlEmployeeInfo : UserControl
    {
        private Employee employee;
        private EmployeeAddress address;
        public UserControl Next { get; set; }
        
        public ControlEmployeeInfo()
        {
            InitializeComponent();
        }

        public EmployeeAddress GetAddress()
        {
            return this.address = new EmployeeAddress()
            {
                HouseNo = tbx_presentAddNo.Text,
                Street = tbx_presentAddStreet.Text,
                PostalArea = tbx_presentPostalArea.Text,
                PostalNo = tbx_presentPostalNo.Text
            };
        }
        public Employee GetEmployeeInfo()
        {
            return this.employee = new Employee()
            {
                Firstname = tbx_firstname.Text,
                Middlename = tbx_middlename.Text,
                Lastname = tbx_lastname.Text,
                PrimaryContact = tbx_primaryContact.Text,
                SecondaryContact = tbx_secondaryContact.Text,
                MaritalStatus = cbx_maritalStatus.Text,
                Email = tbx_email.Text,
                SSS = tbx_SSS.Text,
                TIN = tbx_TIN.Text,
                HDMF = tbx_HDMF.Text,
                BPICard = tbx_BPI.Text
            };
        }
        
        bool ValidateFields()
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

            return result;
        }
        
        #region Buttons
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Fill up all the required fields.");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_firstname.ResetText();
            tbx_middlename.ResetText();
            tbx_lastname.ResetText();
            tbx_primaryContact.ResetText();
            tbx_secondaryContact.ResetText();
            cbx_maritalStatus.SelectedIndex = -1;
            tbx_email.ResetText();
            tbx_SSS.ResetText();
            tbx_TIN.ResetText();
            tbx_HDMF.ResetText();
            tbx_BPI.ResetText();
            tbx_presentAddNo.ResetText();
            tbx_presentAddStreet.ResetText();
            tbx_presentPostalArea.ResetText();
            tbx_presentPostalNo.ResetText();
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
            Misc.TurnGreenIndicator(tbx_primaryContact.Text, lbl_primaryContact);
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

    }
}
