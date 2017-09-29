using Presentation.DialogBox.ExternalApplicationForm;
using System.Data;
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
        private FormEmploymentHistory employment;
        private FormBackgroundIllness illness;
        private FormContactPerson contacts;
        private FormBackgroundLegal legal;

        public DataTable table_education;
        public DataTable table_employment;
        public DataTable table_illnesses;
        public DataTable table_contacts;
        public DataTable table_legal;
        public DataTable table_conviction;
        public DataTable table_operations;
        #endregion
        public ControlOtherDetails()
        {
            InitializeComponent();
            this.education = new FormBackgroundEducation();
            this.employment = new FormEmploymentHistory();
            this.illness = new FormBackgroundIllness();
            this.contacts = new FormContactPerson();
            this.legal = new FormBackgroundLegal();

            this.table_education = new DataTable();
            this.table_employment = new DataTable();
            this.table_illnesses = new DataTable();
            this.table_operations = new DataTable();
            this.table_contacts = new DataTable();
            this.table_legal = new DataTable();
        }

        #region link-clicked
        private void link_education_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(this.education.ShowDialog() == DialogResult.OK)
            {
                this.table_education = education.table_education;
            }
            Misc.TurnGreenIndicator(education.CheckValue(), lbl_educationBackground);
        }

        private void link_illness_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(this.illness.ShowDialog() == DialogResult.OK)
            {
                this.table_illnesses = illness.table_illnesses;
                this.table_operations = illness.table_operations;
            }
            Misc.TurnGreenIndicator(illness.CheckValue(), lbl_illness);
        }

        private void link_legal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(this.legal.ShowDialog() == DialogResult.OK)
            {
                this.table_legal = legal.table_legalcase;
                this.table_conviction = legal.table_conviction;
            }
            Misc.TurnGreenIndicator(legal.CheckValue(), lbl_legal);
        }

        private void link_employment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(this.employment.ShowDialog() == DialogResult.OK)
            {
                this.table_employment = employment.table_employment;
            }
            Misc.TurnGreenIndicator(employment.CheckValue(), lbl_employment);
        }

        private void link_contacts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(this.contacts.ShowDialog() == DialogResult.OK)
            {
                this.table_contacts = contacts.table_contacts;
            }
            Misc.TurnGreenIndicator(contacts.CheckValue(), lbl_contactPerson);
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
            if (cbx_workExp.Text == "Yes")
            {
                lbl_employment.ImageIndex = 1;
                link_employment.Visible = true;
            }
            else
            {
                lbl_employment.ImageIndex = -1;
                link_employment.Visible = false;
            }
        }
    }
}
