using Data.Entities;
using System;
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
        private EmployeeHiringManager _details;
        private EmployeeTitanTitle _titantitle;
        private EmployeeBucket _bucket;
        private EmployeeArvatoLevel _arvatoLevel;
        private EmployeeJobTitle _jobTitle;
        private EmployeeTeam _team;
        private EmployeeContractType _contractType;
        #endregion
        
        public ControlEmployeeEvaluation()
        {
            InitializeComponent();
        }

        #region get values
        public EmployeeHiringManager GetHiringManager()
        {
            return this._details = new EmployeeHiringManager()
            {
                HiringManagerID = int.Parse(cbx_hiringManagerID.Text),
                HiringManagerName = cbx_hiringManagerName.Text
            };
        }

        public EmployeeTitanTitle GetTitanTitle()
        {
            return this._titantitle = new EmployeeTitanTitle()
            {
                TitanTitle = cbx_titanTitle.Text,
                LanguageRequirements = cbx_langRequirement.Text
            };
        }

        public EmployeeBucket GetBucket()
        {
            return this._bucket = new EmployeeBucket()
            {
                Bucket = cbx_bucket.Text
            };
        }

        public EmployeeArvatoLevel GetArvatoLevel()
        {
            return this._arvatoLevel = new EmployeeArvatoLevel()
            {
                ArvatoLevel = cbx_arvatoLevel.Text
            };
        }

        public EmployeeJobTitle GetJobTitle()
        {
            return this._jobTitle = new EmployeeJobTitle()
            {
                Position = cbx_jobTitle.Text
            };
        }
        
        public EmployeeTeam GetTeam()
        {
            return this._team = new EmployeeTeam()
            {
                Team = cbx_team.Text
            };
        }

        public EmployeeContractType GetContractType()
        {
            return this._contractType = new EmployeeContractType()
            {
                ContractType = cbx_contractType.Text
            };
        }
        #endregion

        #region methods 
        private bool ValidateFields()
        {
            bool result = true;

            if (lbl_managerID.ImageIndex == 1)
                result = false;
            if (lbl_managerName.ImageIndex == 1)
                result = false;
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
        #endregion

        #region Buttons
        private void btn_clear_Click(object sender, EventArgs e)
        {
            cbx_arvatoLevel.SelectedIndex = -1;
            cbx_bucket.SelectedIndex = -1;
            cbx_contractType.SelectedIndex = -1;
            cbx_jobTitle.SelectedIndex = -1;
            cbx_langRequirement.SelectedIndex = -1;
            cbx_team.SelectedIndex = -1;
            cbx_titanTitle.SelectedIndex = -1;
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            Previous.BringToFront();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
