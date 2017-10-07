using Data.Access;
using System.Data;
using System.Windows.Forms;
using System;
using Data.Entities;

namespace Presentation.DialogBox.ApplicantEvaluation
{
    public partial class ControlApplicantEvaluationDetails : UserControl
    {
        private DataAccess access;
        private EmployeeAccess access_employee;
        public EvaluationDetails evaluation;
        public UserControl Next { get; set; }

        public int ID;

        public ControlApplicantEvaluationDetails()
        {
            InitializeComponent();
            this.access = new DataAccess();
            this.access_employee = new EmployeeAccess();
            this.evaluation = new EvaluationDetails();
        }

        private void ResetFields()
        {
            this.cbx_position.SelectedIndex = -1;
            this.cbx_arvatoLevel.SelectedIndex = -1;
            this.cbx_bucket.SelectedIndex = -1;
            this.cbx_titanTitle.SelectedIndex = -1;
            this.cbx_languageRequirement.SelectedIndex = -1;
            this.cbx_managerID.SelectedIndex = -1;
        }

        #region Buttons
        private void btn_next_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
                evaluation.ApplicantName = lbl_name.Text;
                evaluation.JobTitle = cbx_position.Text;
                evaluation.Bucket = cbx_bucket.Text;
                evaluation.TitanTitle = cbx_titanTitle.Text;
                evaluation.LanguageRequirement = cbx_languageRequirement.Text.Equals("yes") ? true : false;
                evaluation.ArvatoLevel = cbx_arvatoLevel.Text;
                evaluation.HiringManagerID = int.Parse(cbx_managerID.Text);

                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Please complete the fields!");
            }
        }

        private bool ValidateFields()
        {
            bool result = true;

            if (lbl_jobTitle.ImageIndex == 1)
                result = false;
            if (lbl_bucket.ImageIndex == 1)
                result = false;
            if (lbl_titanTitle.ImageIndex == 1)
                result = false;
            if (lbl_langRequirement.ImageIndex == 1)
                result = false;
            if(lbl_arvatoLevel.ImageIndex == 1)
                result = false;
            if(lbl_managerID.ImageIndex == 1)
                result = false;

            return result;
        }

        private void btn_clear_Click(object sender, System.EventArgs e)
        {
            ResetFields();
        }
        #endregion

        #region If fields are empty conditions

        private void cbx_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_position.SelectedIndex, lbl_jobTitle);
        }
        private void cbx_bucket_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_bucket.SelectedIndex, lbl_bucket);
        }

        private void cbx_titanTitle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_titanTitle.Text, lbl_titanTitle);
        }

        private void cbx_languageRequirement_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_languageRequirement.SelectedIndex, lbl_langRequirement);
        }

        private void cbx_arvatoLevel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_arvatoLevel.SelectedIndex, lbl_arvatoLevel);
        }
       
        #endregion

        private void OnLoad(object sender, System.EventArgs e)
        {
            cbx_position.DisplayMember = "Title";
            cbx_position.ValueMember = "Title";
            cbx_position.DataSource = access.ShowJobTitleData();

            cbx_bucket.DisplayMember = "Description";
            cbx_bucket.ValueMember = "Description";
            cbx_bucket.DataSource = access.ShowBucketData();
            
            cbx_titanTitle.DisplayMember = "TitanTitle";
            cbx_titanTitle.ValueMember = "TitanTitle";
            cbx_titanTitle.DataSource = access.ShowTitanTitleData();

            cbx_managerID.DisplayMember = "ID";
            cbx_managerID.ValueMember = "ID";
            cbx_managerID.DataSource = access_employee.ShowHiringManagerData();
            

            ResetFields();
        }

        private void cbx_managerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_managerID.Text, lbl_managerID);
        }
    }
}
