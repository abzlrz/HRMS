using Data.Access;
using Presentation.DialogBox;
using System.Windows.Forms;

namespace Presentation.Modules
{
    public partial class ControlRecruitmentDashboard : UserControl
    {
        DataAccess context;
        FormRegisterExistingEmployee reg_ex_emp;

        public ControlRecruitmentDashboard()
        {
            InitializeComponent();

            this.context = new DataAccess();
            this.reg_ex_emp = new FormRegisterExistingEmployee();
            this.view_employee.DataSource = context.Employee.ShowData();
            this.view_external_applicant.DataSource = context.ExternalApplicant.ShowData();
            this.view_internal_applicant.DataSource = context.InternalApplicant.ShowData();
            //
            // view_employeee
            //
            this.view_employee.Columns["SSS"].Visible = false;
            this.view_employee.Columns["HDMF"].Visible = false;
            this.view_employee.Columns["BankAccountNo"].Visible = false;
            this.view_employee.Columns["TIN"].Visible = false;
            this.view_employee.Columns["IsActive"].Visible = false;
            //
            // view_external_applicant
            //
            this.view_external_applicant.Columns["SSS"].Visible = false;
            this.view_external_applicant.Columns["HDMF"].Visible = false;
            this.view_external_applicant.Columns["BankAccountNo"].Visible = false;
            this.view_external_applicant.Columns["TIN"].Visible = false;
            this.view_external_applicant.Columns["IsActive"].Visible = false;
            //
            // view_internal_applicant
            //
            this.view_internal_applicant.Columns["SSS"].Visible = false;
            this.view_internal_applicant.Columns["HDMF"].Visible = false;
            this.view_internal_applicant.Columns["BankAccountNo"].Visible = false;
            this.view_internal_applicant.Columns["TIN"].Visible = false;
            this.view_internal_applicant.Columns["IsActive"].Visible = false;

        }
        private void ReloadExternalApplicantData()
        {
            this.view_external_applicant.DataSource = context.ExternalApplicant.ShowData();
        }
        private void ReloadInternalApplicantData()
        {
            this.view_internal_applicant.DataSource = context.InternalApplicant.ShowData();
        }
        private void ReloadEmployeeData()
        {
            this.view_employee.DataSource = context.Employee.ShowData();
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            ReloadEmployeeData();
            ReloadExternalApplicantData();
            ReloadInternalApplicantData();
        }

        private void checklistToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.reg_ex_emp.ShowDialog();
            ReloadEmployeeData();
        }
    }
}
