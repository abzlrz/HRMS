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
        public EmployeeOwner owner;
        public EmployeeRole role;

        private DataAccess _eval;
        private EmployeeAccess _emp;
        public int ID;
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
            this.role = new EmployeeRole();
            this.owner = new EmployeeOwner();
            

            ClearAllFields();
        }

        #region methods 
        private bool ValidateFields()
        {
            bool result = true;

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
            if (lbl_emp_id.ImageIndex == 1)
                result = false;
            if (lbl_owner_firstname.ImageIndex == 1)
                result = false;
            if (lbl_owner_lastname.ImageIndex == 1)
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
        private void cbx_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_role.SelectedIndex, lbl_role);
        }

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
        private void tbx_owner_firstname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_owner_firstname.Text, lbl_owner_firstname);
        }

        private void tbx_owner_lastname_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(tbx_owner_lastname.Text, lbl_owner_lastname);
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
                this.hiringmanager.EmployeeID = int.Parse(tbx_hiringManagerID.Text);
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
                //
                // role
                //
                this.role.Role = cbx_role.Text;
                //
                //
                // owner
                this.owner.EmployeeID = int.Parse(cbx_owner_empID.Text);
                this.owner.Firstname = tbx_owner_firstname.Text;
                this.owner.Lastname = tbx_owner_lastname.Text;

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
            //
            // combobox role
            //
            this.cbx_role.DisplayMember = "Description";
            this.cbx_role.ValueMember = "Description";
            this.cbx_role.DataSource = _eval.ShowRoleData();
            //
            // combobox owner emp id
            //
            this.cbx_owner_empID.DisplayMember = "ID";
            this.cbx_owner_empID.ValueMember = "ID";
            this.cbx_owner_empID.DataSource = _emp.ShowHiringManagerData();
            
            if(ID > 0)
            {
                DataRow row_manager = _emp.GetHiringManager(ID);
                DataRow row_titantitle = _emp.GetTitanTitle(ID);
                DataRow row_bucket = _emp.GetBucket(ID);
                DataRow row_arvatolevel = _emp.GetArvatoLevel(ID);
                DataRow row_job = _emp.GetJob(ID);
                DataRow row_team = _emp.GetTeam(ID);
                DataRow row_contract = _emp.GetContractType(ID);
                DataRow row_role = _emp.GetRole(ID);
                DataRow row_owner = _emp.GetManager(ID);

                this.tbx_hiringManagerID.Text = row_manager["HiringManagerID"].ToString();
                this.tbx_hiringManagerID.Text = row_manager["HiringManagerName"].ToString();
                this.cbx_titanTitle.Text = row_titantitle["TitanTitle"].ToString();
                this.cbx_langRequirement.Text = row_titantitle["LanguageRequirements"].ToString();
                this.cbx_bucket.Text = row_bucket["Bucket"].ToString();
                this.cbx_arvatoLevel.Text = row_arvatolevel["ArvatoLevel"].ToString();
                this.cbx_jobTitle.Text = row_job["Position"].ToString();
                this.cbx_team.Text = row_team["Team"].ToString();
                this.cbx_contractType.Text = row_contract["ContractType"].ToString();
                this.cbx_role.Text = row_role["Role"].ToString();
                this.cbx_owner_empID.Text = row_owner["EmployeeID"].ToString();
                this.tbx_owner_firstname.Text = row_owner["Firstname"].ToString();
                this.tbx_owner_lastname.Text = row_owner["Lastname"].ToString();
            }
            else
            {
                //
                // clear all fields
                //
                ClearAllFields();
            }
        }

        private void cbx_owner_empID_TextChanged(object sender, EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_owner_empID.Text, lbl_emp_id);
        }

        private void cbx_hiringManagerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = _emp.GetHiringManager(cbx_hiringManagerName.Text);
            tbx_hiringManagerID.Text = row["ID"].ToString();

        }

        private void cbx_owner_empID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = _emp.GetEmployeeInfo(int.Parse(cbx_owner_empID.Text));
            tbx_owner_firstname.Text = row["Firstname"].ToString();
            tbx_owner_lastname.Text = row["Lastname"].ToString();
        }
    }
}
