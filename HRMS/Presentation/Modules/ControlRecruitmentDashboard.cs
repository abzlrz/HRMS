using Data.Access;
using Data.Entities;
using Presentation.DialogBox;
using System.Windows.Forms;

namespace Presentation.Modules
{
    public partial class ControlRecruitmentDashboard : UserControl
    {
        DataAccess context;
        EmployeeAccess context_employee;
        int ID;

        public ControlRecruitmentDashboard()
        {
            InitializeComponent();

            this.context = new DataAccess();
            //
            // view_external_applicant
            ///

            /*this.view_external_applicant.Columns["SSS"].Visible = false;
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
            */
        }
        private void ReloadExternalApplicantData()
        {
            this.view_external_applicant.DataSource = context.ExternalApplicant.ShowData();
        }
        private void ReloadEmployeeData()
        {
            this.view_employee.DataSource = context.Employee.ShowData();
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            this.context_employee = new EmployeeAccess();
            this.view_employee.DataSource = context.Employee.ShowData();
            this.view_external_applicant.DataSource = context.ExternalApplicant.ShowData();
            //
            // view_employeee
            //
            this.view_employee.Columns["SSS"].Visible = false;
            this.view_employee.Columns["HDMF"].Visible = false;
            this.view_employee.Columns["BankAccountNo"].Visible = false;
            this.view_employee.Columns["TIN"].Visible = false;
            this.view_employee.Columns["IsActive"].Visible = false;
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var reg_ex_emp = new FormRegisterExistingEmployee(0);
            reg_ex_emp.ShowDialog();
            ReloadEmployeeData();
        }

        private void editEmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var reg_ex_emp = new FormRegisterExistingEmployee(ID);
            reg_ex_emp.ShowDialog();
            ReloadEmployeeData();
        }

        private void deleteToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if(ID > 0)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.context_employee.DeleteEmployee(ID))
                    {
                        MessageBox.Show("Deleted!");
                    }

                    ReloadEmployeeData();
                }
            }
        }

        private void view_employee_SelectionChanged(object sender, System.EventArgs e)
        {
            if (view_employee.SelectedRows.Count > 0)
            {
                ID = int.Parse(view_employee.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
