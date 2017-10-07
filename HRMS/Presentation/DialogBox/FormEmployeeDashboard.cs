using Data.Access;
using System.Data;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormEmployeeDashboard : Form
    {
        private int ID;
        private EmployeeAccess access;
        public FormEmployeeDashboard(int Id)
        {
            InitializeComponent();
            this.access = new EmployeeAccess();
            this.ID = Id;
        }

        private void FormEmployeeDashboard_Load(object sender, System.EventArgs e)
        {
            DataRow row = access.GetEmployeeInfo(ID);
            DataRow row_address = access.GetAddress(ID);
            DataRow row_manager = access.GetHiringManager(ID);
            DataRow row_jobinfo = access.GetJobInfo(ID);
            DataRow row_owner = access.GetOwner(ID);
            DataRow row_salary = access.GetSalaryInfo(ID);

            //
            // form text
            //
            string employee_name = string.Format("{0}, {1} {2}", 
                row["Lastname"].ToString(),
                row["Firstname"].ToString(),
                row["Lastname"].ToString());

            this.Text = string.Format(row["ID"].ToString() +" - "+ employee_name);
            
            this.lbl_info_employee_id.Text = row["ID"].ToString();
            this.lbl_info_firstname.Text = row["Firstname"].ToString();
            this.lbl_info_middlename.Text = row["Middlename"].ToString();
            this.lbl_info_lastname.Text = row["Lastname"].ToString();
            this.lbl_info_primary_contact.Text = row["PrimaryContact"].ToString();
            this.lbl_info_secondary_contact.Text = row["SecondaryContact"].ToString();
            this.lbl_info_maritalstatus.Text = row["MaritalStatus"].ToString();
            this.lbl_info_email.Text = row["Email"].ToString();
            this.lbl_info_sss.Text = row["SSS"].ToString();
            this.lbl_info_tin.Text = row["TIN"].ToString();
            this.lbl_info_hdmf.Text = row["HDMF"].ToString();
            this.lbl_info_bpi.Text = row["BankAccountNo"].ToString();

            this.lbl_address_no.Text = row_address["HouseNo"].ToString();
            this.lbl_address_street.Text = row_address["Street"].ToString();
            this.lbl_address_postal_area.Text = row_address["PostalArea"].ToString();
            this.lbl_address_postal_no.Text = row_address["PostalNo"].ToString();

            this.lbl_hiringmanager_id.Text = row_manager["HiringManagerEmpID"].ToString();
            this.lbl_hiringmanager_name.Text = row_manager["HiringManagerName"].ToString();

            this.lbl_job_titantitle.Text = row_jobinfo["TitanTitle"].ToString();
            this.lbl_job_bucket.Text = row_jobinfo["Bucket"].ToString();
            this.lbl_job_title.Text = row_jobinfo["Position"].ToString();
            this.lbl_job_team.Text = row_jobinfo["Team"].ToString();
            this.lbl_job_contract_type.Text = row_jobinfo["ContractType"].ToString();
            this.lbl_job_role.Text = row_jobinfo["Role"].ToString();

            this.lbl_owner_id.Text = row_owner["EmployeeID"].ToString();
            this.lbl_owner_firstname.Text = row_owner["Firstname"].ToString();
            this.lbl_owner_lastname.Text = row_owner["Lastname"].ToString();

            this.lbl_salary_date_approved.Text = row_salary["DateApproved"].ToString();
            this.lbl_salary_date_accepted.Text = row_salary["DateAccepted"].ToString();
            this.lbl_salary_date_started.Text = row_salary["DateStarted"].ToString();
            this.lbl_salary_approved.Text = row_salary["ApprovedSalary"].ToString();
            this.lbl_salary_annual.Text = row_salary["AnnualBasedSalary"].ToString();
            this.lbl_salary_annual_allowance.Text = row_salary["AnnualLanguageAllowance"].ToString();
            this.lbl_salary_shift_allowance.Text = row_salary["ShiftAllowance"].ToString();
            this.lbl_salary_reloc_allowance.Text = row_salary["RelocationAllowance"].ToString();
            this.lbl_salary_reloc_detail.Text = row_salary["RelocationAllowanceDetail"].ToString();
            this.lbl_salary_cost_centre.Text = row_salary["CostCentre"].ToString();
        }
    }
}
