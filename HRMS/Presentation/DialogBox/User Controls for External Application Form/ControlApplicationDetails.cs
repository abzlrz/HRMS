using Data.Access;
using Data.Entities;
using Presentation.DialogBox.ExternalApplicationForm;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox.ExternalApplication
{
    public partial class ControlApplicationDetails : UserControl
    {
        #region properties
        public UserControl Next { get; set; }
        public UserControl Previous { get; set; }
        #endregion

        #region fields
        public ApplicationSource source;
        public Position position;
        private JobPostingAccess access_jobposting;
        private DataAccess access;
        private EmployeeAccess access_employee;
        private FormBackgroundEducation form_education;
        private FormEmploymentHistory form_employment;
        public DataTable table_education;
        public DataTable table_employment;
        #endregion

        public ControlApplicationDetails()
        {
            InitializeComponent();
            this.source = new ApplicationSource();
            this.position = new Position();
            this.access = new DataAccess();
            this.access_jobposting = new JobPostingAccess();
            this.access_employee = new EmployeeAccess();
            this.form_employment = new FormEmploymentHistory();
            this.form_education = new FormBackgroundEducation();
            this.table_education = new DataTable();
            this.table_employment = new DataTable();
        }

        #region methods
        private bool ValidateFields()
        {
            bool result = true;

            if (lbl_source.ImageIndex == 1)
                result = false;
            if(lbl_source.ImageIndex == 0)
            {
                if (lbl_employeeID.ImageIndex == 1)
                    result = false;
                if (lbl_employeeName.ImageIndex == 1)
                    result = false;
            }
            if (lbl_position.ImageIndex == 1)
                result = false;
            if (lbl_preferredSite.ImageIndex == 1)
                result = false;

            return result;
        }
        public void ClearAllFields()
        {
            cbx_source.SelectedIndex = -1;
            cbx_employeeID.SelectedIndex = -1;
            cbx_employeeName.SelectedIndex = -1;
        }
        #endregion

        #region if fields are empty conditions

        private void cbx_employeeName_TextChanged(object sender, System.EventArgs e)
        {
            Misc.TurnGreenIndicator(cbx_employeeName.Text, lbl_employeeName);
        }

        private void cbx_employeeID_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataRow row = access_employee.GetEmployeeName(int.Parse(cbx_employeeID.Text));
            this.cbx_employeeName.Text = row["Name"].ToString();

            Misc.TurnGreenIndicator(cbx_employeeID.Text, lbl_employeeID);
        }
        #endregion

        #region buttons
        private void btn_clearAll_Click(object sender, System.EventArgs e)
        {
            ClearAllFields();
        }

        private void btn_next_Click(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
                //
                // application source
                //
                source.Source = cbx_source.Text;
                source.ReferralID = int.Parse(cbx_employeeID.Text);
                source.ReferralName = cbx_employeeName.Text;
                //
                // position applied
                //
                position.PositionTitle = lbl_position_title.Text;
                position.PreferredSite = lbl_site.Text;

                Next.BringToFront();
            }
            else
            {
                MessageBox.Show("Please fill-up all the required fields", "Arvato HRMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_previous_Click(object sender, System.EventArgs e)
        {
            Previous.BringToFront();
        }

        #endregion

        private void OnLoad(object sender, System.EventArgs e)
        {
            ClearAllFields();
            //
            // cbx_applicationsource
            //
            this.cbx_source.DisplayMember = "Source";
            this.cbx_source.ValueMember = "Source";
            this.cbx_source.DataSource = access.ShowApplicationSourceData();
            //
            //
            //
            this.cbx_employeeName.DisplayMember = "Name";
            this.cbx_employeeName.ValueMember = "Name";
            this.cbx_employeeName.DataSource = access_employee.ShowDataFullname();
            //
            //
            //
            this.cbx_employeeID.DisplayMember = "ID";
            this.cbx_employeeID.ValueMember = "ID";
            this.cbx_employeeID.DataSource = access_employee.ShowDataFullname();
        }

        private void link_education_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(this.form_education.ShowDialog() == DialogResult.OK)
            {
                this.table_education = form_education.table_education;
                Misc.TurnGreenIndicator(table_education, lbl_educationBackground);
            }
        }

        private void link_employment_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(this.form_employment.ShowDialog() == DialogResult.OK)
            {
                this.table_employment = form_employment.table_employment;
                Misc.TurnGreenIndicator(table_employment, lbl_employment);
            }
        }

        private void cbx_employeeName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DataRow row = access_employee.GetEmployeeID(cbx_employeeName.Text);
            this.cbx_employeeID.Text = row["ID"].ToString();
        }

        private void cbx_workExp_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(cbx_workExp.Text.Equals("Yes"))
            {
                link_employment.Visible = true;
                lbl_employment.ImageIndex = 1;
            }
            else
            {
                link_employment.Visible = false;
                lbl_employment.ImageIndex = -1;
            }

            Misc.TurnGreenIndicator(cbx_workExp.SelectedIndex, lbl_workExp);
        }

        private void cbx_source_TextChanged(object sender, System.EventArgs e)
        {

            Misc.TurnGreenIndicator(cbx_source.SelectedIndex, lbl_source);

            if (cbx_source.Text.Equals("Employee Referral"))
            {
                cbx_employeeID.Enabled = true;
                cbx_employeeName.Enabled = true;
                lbl_employeeID.ImageIndex = 1;
                lbl_employeeName.ImageIndex = 1;
            }
            else
            {
                cbx_employeeID.Enabled = false;
                cbx_employeeName.Enabled = false;
                lbl_employeeID.ImageIndex = -1;
                lbl_employeeName.ImageIndex = -1;
            }
        }
    }
}
