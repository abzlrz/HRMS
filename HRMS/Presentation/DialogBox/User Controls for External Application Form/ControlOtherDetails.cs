using Presentation.DialogBox.ExternalApplicationForm;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlOtherDetails : UserControl
    {
        #region properties
        public UserControl Previous { get; set; }
        #endregion

        #region fields
        private FormBackgroundEducation education;
        //private FormBackgroundEmployment employment;
        private FormBackgroundIllness illness;
        private FormContactPerson contacts;
        private FormLegalBackground legal;
        #endregion
        public ControlOtherDetails()
        {
            InitializeComponent();
            this.education = new FormBackgroundEducation();
            //this.employment = new FormBackgroundEmployment();
            this.illness = new FormBackgroundIllness();
            this.contacts = new FormContactPerson();
            this.legal = new FormLegalBackground();
        }

        #region link-clicked
        private void link_education_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_illness_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_legal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_employment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void link_contacts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        #endregion

        #region buttons
        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }
        private void btn_save_Click(object sender, System.EventArgs e)
        {
            //Insert(application.info);
            //Insert(?, application.evaluation)
            //Insert(?, application.otherdetails);
        }
        #endregion

        private void cbx_workExp_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_workExp.SelectedIndex, lbl_workExp);
            if(lbl_workExp.ImageIndex  == 0)
            {
                lbl_employment.ImageIndex = 1;
            }
        }
    }
}
