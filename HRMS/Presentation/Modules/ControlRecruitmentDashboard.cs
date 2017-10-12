using Data.Access;
using Data.Entities;
using Presentation.DialogBox;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Presentation.Modules
{
    public partial class ControlRecruitmentDashboard : UserControl
    {
        private DataAccess context;
        private ExternalApplicantAccess context_applicant;
        private EmployeeAccess context_employee;
        private FormEmployeeDashboard form_dash;
        private BindingSource bs_employee;

        private int employee_ID;
        private int applicant_ID;

        public ControlRecruitmentDashboard()
        {
            InitializeComponent();
            this.context = new DataAccess();
            this.context_employee = new EmployeeAccess();
            this.context_applicant = new ExternalApplicantAccess();
            this.bs_employee = new BindingSource();

            this.bs_employee.DataSource = context_employee.ShowData();
            this.view_employee.DataSource = bs_employee;
        }

        private void ReloadData()
        {
            this.bs_employee.DataSource = context_employee.ShowData();
            this.view_employee.DataSource = bs_employee;
        }
        
        private void OnLoad(object sender, System.EventArgs e)
        {
            this.context_employee = new EmployeeAccess();
            this.view_employee.DataSource = context.Employee.ShowData();
            this.view_external_applicant.DataSource = context_applicant.ShowData();
            this.view_applicant_evaluated.DataSource = context_applicant.ShowApplicantEvaluated();
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
            ///
            this.view_external_applicant.Columns["SSS"].Visible = false;
            this.view_external_applicant.Columns["HDMF"].Visible = false;
            this.view_external_applicant.Columns["BankAccountNo"].Visible = false;
            this.view_external_applicant.Columns["TIN"].Visible = false;
        }

        #region Employee Region
        private void ReloadEmployeeData()
        {
            this.view_employee.DataSource = context.Employee.ShowData();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var reg_ex_emp = new FormRegisterExistingEmployee(0);
            reg_ex_emp.ShowDialog();
            ReloadEmployeeData();
        }
        private void editEmployeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var reg_ex_emp = new FormRegisterExistingEmployee(employee_ID);
            reg_ex_emp.ShowDialog();
            ReloadEmployeeData();
        }
        private void deleteToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (employee_ID > 0)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    view_employee.ClearSelection();
                    if (this.context_employee.DeleteEmployee(employee_ID))
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
                employee_ID = int.Parse(view_employee.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void viewInformationToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.form_dash = new FormEmployeeDashboard(employee_ID);
            this.form_dash.ShowDialog();
        }
        private void resignToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new FormEmployeeExit(employee_ID);
        }
        private void performanceAppraisalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new FormEmployeePerformanceAppraisal(employee_ID);
            form.ShowDialog();
        }
        #endregion

        #region Applicant Region
        private void ReloadExternalApplicantData()
        {
            this.view_external_applicant.DataSource = context.ExternalApplicant.ShowData();
        }
        private void evaluateToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var app_evaluation = new FormEvaluateApplicant(int.Parse(view_external_applicant.SelectedRows[0].Cells[0].Value.ToString()));
            app_evaluation.ShowDialog();
            ReloadExternalApplicantData();
            ReloadApplicantEvaluated();
        }

        private void ReloadApplicantEvaluated()
        {
            this.view_applicant_evaluated.DataSource = context_applicant.ShowApplicantEvaluated();
        }

        private void view_external_applicant_SelectionChanged(object sender, System.EventArgs e)
        {
            if (view_external_applicant.SelectedRows.Count > 0)
            {
                applicant_ID = int.Parse(view_external_applicant.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        #endregion

        private void tbx_applicant_search_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_employee_search.Text))
                ReloadData();
            else
                view_external_applicant.DataSource = context_employee.SearchData(tbx_employee_search.Text, "ExternalApplicant", "Applicant");
        }

        private void tbx_employee_search_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_employee_search.Text))
                ReloadData();
            else
                view_employee.DataSource = context_employee.SearchData(tbx_employee_search.Text, "Employee", "Employee");
        }

        private void deleteToolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            if(applicant_ID > 0)
            {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.context_applicant.DeleteApplicant(applicant_ID))
                    {
                        MessageBox.Show("Deleted!");
                    }

                    ReloadApplicantData();
                }
            }
        }

        private void ReloadApplicantData()
        {
            view_external_applicant.DataSource = context.ExternalApplicant.ShowData();
        }

        private void view_applicant_evaluated_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var result = view_applicant_evaluated.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (result == "Accepted")
                view_applicant_evaluated.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            if (result == "Rejected")
                view_applicant_evaluated.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            if (result == "Shortlisted")
                view_applicant_evaluated.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
        }
    }
}
