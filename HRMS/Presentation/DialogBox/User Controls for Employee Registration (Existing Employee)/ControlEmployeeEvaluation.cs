using Data.Access;
using Data.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExistingEmployeeRegistration
{
    public partial class ControlEmployeeEvaluation : UserControl
    {
        #region properties
        public UserControl Previous { get; set; }
        public UserControl Next { get; set; }
        #endregion

        #region fields
        public EmployeeHiringManager hiringmanager;
        public EmployeeTitanTitle titantitle;
        public EmployeeBucket bucket;
        public EmployeeArvatoLevel arvatoLevel;
        public EmployeeJobTitle jobtitle;
        public EmployeeTeam team;
        public EmployeeContractType contract_type;

        private DataAccess _eval;
        private EmployeeAccess _emp;
        #endregion
        
        public ControlEmployeeEvaluation()
        {
            InitializeComponent();
            this._emp = new EmployeeAccess();
            this._eval = new DataAccess();
            this.hiringmanager = new EmployeeHiringManager();
            this.titantitle = new EmployeeTitanTitle();
            this.bucket = new EmployeeBucket();
            this.arvatoLevel = new EmployeeArvatoLevel();
            this.jobtitle = new EmployeeJobTitle();
            this.team = new EmployeeTeam();
            this.contract_type = new EmployeeContractType();
        }

        #region methods 
        private bool ValidateFields()
        {
            bool result = true;
            /*
            if (lbl_managerID.ImageIndex == 1)
                result = false;
            if (lbl_managerName.ImageIndex == 1)
                result = false;*/
            if (lbl_titanTitle.ImageIndex == 1)
                result = false;
            if (lbl_langRequirement.ImageIndex == 1)
                result = false;
            if (lbl_bucket.ImageIndex == 1)
                result = false;
            if (lbl_arvatoLevel.ImageIndex == 1)
                result = false;
            if (lbl_jobTitle.ImageIndex == 1)
                result = false;
            if (lbl_team.ImageIndex == 1)
                result = false;
            if (lbl_contractType.ImageIndex == 1)
                result = false;

            return result;
        }
        public void ClearAllFields()
        {
            cbx_arvatoLevel.SelectedIndex = -1;
            cbx_bucket.SelectedIndex = -1;
            cbx_contractType.SelectedIndex = -1;
            cbx_jobTitle.SelectedIndex = -1;
            cbx_langRequirement.SelectedIndex = -1;
            cbx_team.SelectedIndex = -1;
            cbx_titanTitle.SelectedIndex = -1;
        }
        #endregion

        #region If fields are empty conditions
        private void cbx_titanTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_titanTitle.SelectedIndex, lbl_titanTitle);
        }

        private void cbx_langRequirement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_langRequirement.SelectedIndex, lbl_langRequirement);
        }

        private void cbx_bucket_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_bucket.SelectedIndex, lbl_bucket);
        }

        private void cbx_arvatoLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_arvatoLevel.SelectedIndex, lbl_arvatoLevel);
        }

        private void cbx_jobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_jobTitle.SelectedIndex, lbl_jobTitle);
        }

        private void cbx_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_team.SelectedIndex, lbl_team);
        }

        private void cbx_contractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_contractType.SelectedIndex, lbl_contractType);
        }
        private void cbx_hiringManagerName_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_hiringManagerName.Text, lbl_managerName);
        }

        private void cbx_hiringManagerName_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cbx_hiringManagerID.Text = (cbx_hiringManagerName.DataSource as DataTable).Rows[0][0].ToString();
        }
        #endregion

        #region Buttons
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            Previous.BringToFront();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                //
                // hiring manager
                //
                this.hiringmanager.EmployeeID = int.Parse(cbx_hiringManagerID.Text);
                this.hiringmanager.Name = cbx_hiringManagerName.Text;
                //
                // titan title
                //
                this.titantitle.TitanTitle = cbx_titanTitle.Text;
                this.titantitle.LanguageRequirements = cbx_langRequirement.Text;
                //
                // bucket
                //
                this.bucket.Bucket = cbx_bucket.Text;
                //
                // arvato level
                //
                this.arvatoLevel.ArvatoLevel = cbx_arvatoLevel.Text;
                //
                // job title
                //
                this.jobtitle.Position = cbx_jobTitle.Text;
                //
                // team
                //
                this.team.Team = cbx_team.Text;
                //
                // contract type
                //
                this.contract_type.ContractType = cbx_contractType.Text;

                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        
        private void OnLoad(object sender, EventArgs e)
        {
            //
            // clear all fields first!
            //
            ClearAllFields();
            // ---- LOAD ALL DATA REFERENCES FROM DB TO COMBOBOX
            //
            // hiring manager
            //
            this.cbx_hiringManagerName.DisplayMember = "Name";
            this.cbx_hiringManagerName.DisplayMember = "Name";
            this.cbx_hiringManagerName.DataSource = _emp.ShowHiringManagerData();
            //
            // titan title
            //
            this.cbx_titanTitle.DisplayMember = "TitanTitle";
            this.cbx_titanTitle.ValueMember = "TitanTitle";
            this.cbx_titanTitle.DataSource = _eval.ShowTitanTitleData();
            //
            // bucket
            //
            this.cbx_bucket.DisplayMember = "Description";
            this.cbx_bucket.ValueMember = "Description";
            this.cbx_bucket.DataSource = _eval.ShowBucketData();
            //
            // arvato level
            //
            this.cbx_arvatoLevel.DisplayMember = "Level";
            this.cbx_arvatoLevel.ValueMember = "Level";
            this.cbx_arvatoLevel.DataSource = _eval.ShowArvatoLevelData();
            //
            // job title
            //
            this.cbx_jobTitle.DisplayMember = "Title";
            this.cbx_jobTitle.ValueMember = "Title";
            this.cbx_jobTitle.DataSource = _eval.ShowJobTitleData();
            //
            // team
            //
            this.cbx_team.DisplayMember = "Description";
            this.cbx_team.ValueMember = "Description";
            this.cbx_team.DataSource = _eval.ShowTeamData();
            //
            // contract type
            //
            this.cbx_contractType.DisplayMember = "Type";
            this.cbx_contractType.ValueMember = "Type";
            this.cbx_contractType.DataSource = _eval.ShowContractType();
        }
    }
}
