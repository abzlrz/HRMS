using System;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class ApplicationForm : Form
    {
        private string errorMsg;
        public ApplicationForm()
        {
            InitializeComponent();
        }
        void ApplicationSourceContent(bool arg)
        {
            tbxReferralEmpID.Enabled = arg;
            tbxReferralFirstname.Enabled = arg;
            tbxReferralLastname.Enabled = arg;
            a2.Visible = arg;
        }
        void HistoryOfApplicationContent(bool arg)
        {
            cbxWorkedBefore.Enabled = arg;
            dtWorkedFrom.Enabled = arg;
            dtWorkedTo.Enabled = arg;
            cbxAppliedBefore.Enabled = arg;
            dtAppliedTo.Enabled = arg;
            dtAppliedDate.Enabled = arg;
            b2.Visible = arg;
            b3.Visible = arg;
            b4.Visible = arg;
            b5.Visible = arg;
            b6.Visible = arg;
            b7.Visible = arg;
        }
        private void AddErrorMessage(string error)
        {
            if (this.errorMsg == string.Empty)
            {
                this.errorMsg = Resources.ErrorMsgHeader + "\n\n";
            }
            this.errorMsg += error + "\n";
        }
        private bool ValidateRegistration()
        {
            errorMsg = string.Empty;

            if (cbxReferralSource.SelectedIndex == -1)
            {
                this.AddErrorMessage("Referral source is required.");
            }

            if (cbxReferralSource.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(tbxReferralEmpID.Text))
                {
                    this.AddErrorMessage("Employment Referral: \n\tEmployment ID is required.");
                }
            }

            if (cbxApplicationType.SelectedIndex == -1)
            {
                this.AddErrorMessage("Application type is required.");
            }

            if (cbxApplicationType.SelectedIndex == 1)
            {
                if (cbxAppliedBefore.SelectedIndex == -1)
                {
                    this.AddErrorMessage("With Experience: \n\tApplied before field is required.");
                }

                if (cbxWorkedBefore.SelectedIndex == -1)
                {
                    this.AddErrorMessage("\tWorked before field is required.");
                }
            }

            if (string.IsNullOrEmpty(tbxAppPosition.Text))
            {
                this.AddErrorMessage("Applied position is required.");
            }

            if (cbxAppLoc.SelectedIndex == -1)
            {
                this.AddErrorMessage("Preferred site field is required.");
            }

            if (string.IsNullOrEmpty(tbxPersonalFname.Text))
            {
                this.AddErrorMessage("Firstname is required.");
            }

            if (string.IsNullOrEmpty(tbxPersonalLname.Text))
            {
                this.AddErrorMessage("Lastname is required.");
            }

            if (string.IsNullOrEmpty(tbxPersonalPrimContact.Text))
            {
                this.AddErrorMessage("Primary contact number is required.");
            }

            if (cbxPersonal18.SelectedIndex == -1)
            {
                this.AddErrorMessage("Age confirmation is required.");
            }

            if (cbxPersonalStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage("Marital status is required.");
            }
            
            return errorMsg != string.Empty ? false : true;
        }
        
        private void OnCbxApplicationTypeSelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxApplicationType.SelectedIndex == 1)
                HistoryOfApplicationContent(true);
            else
                HistoryOfApplicationContent(false);
        }
        private void OnCbxReferralSourceSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxReferralSource.SelectedIndex == 1)
                ApplicationSourceContent(true);
            else
                ApplicationSourceContent(false);
        }
        private void OnClearAllClick(object sender, EventArgs e)
        {
            this.ClearAllFields();
        }
        private void OnOKClick(object sender, EventArgs e)
        {
            if (this.ValidateRegistration())
            {
                //insert method here
            }
            else
            {
                MessageBox.Show(errorMsg);
            }
        }
        private void OnTbxPersonalPrimContactLeave(object sender, EventArgs e)
        {
            tbxPersonalPrimContact.AcceptEntry("[^0-9]");
        }
        private void OnTbxPersonalSecondContactLeave(object sender, EventArgs e)
        {
            tbxPersonalSecondContact.AcceptEntry("[^0-9]");
        }
        private void OnTbxReferralEmpIDLeave(object sender, EventArgs e)
        {
            tbxReferralEmpID.AcceptEntry("[^0-9]");
        }
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            this.ClosingConfirm(e);
        }
    }
}
