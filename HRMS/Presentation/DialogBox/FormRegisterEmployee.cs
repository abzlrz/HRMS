using Data.Access;
using Data.Entities;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormRegisterEmployee : Form
    {
        private EmployeeAccess access;
        private EmployeePartial employee;
        private int ID;
        public FormRegisterEmployee()
        {
            InitializeComponent();
            this.controlEmployeeDetailsAndSalaryInfo1.btn_save.Click += SaveEmployee;
        }

        public FormRegisterEmployee(int  Id)
        {
            InitializeComponent();
            this.employee = new EmployeePartial();
            this.access = new EmployeeAccess();
            this.ID = Id;

            controlEmployeeApplicationDetails1.ID = Id;
            controlEmployeeEvaluationDetails1.ID = Id;
            controlEmployeeDetailsAndSalaryInfo1.ID = Id;

            this.controlEmployeeDetailsAndSalaryInfo1.btn_save.Click += SaveEmployee;
        }

        private void SaveEmployee(object sender, System.EventArgs e)
        {
            if (controlEmployeeDetailsAndSalaryInfo1.ValidateFields())
            {
                controlEmployeeDetailsAndSalaryInfo1.GetValues();

                employee.ApplicantID = ID;
                employee.Team = controlEmployeeDetailsAndSalaryInfo1.team;
                employee.Contract = controlEmployeeDetailsAndSalaryInfo1.contract_type;
                employee.SalaryInfo = controlEmployeeDetailsAndSalaryInfo1.salary_info;

                var success = access.InsertEmployee(employee);
                if (success)
                {
                    MessageBox.Show("Data finally Registered!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
        }

        private void FormRegisterEmployee_Load(object sender, System.EventArgs e)
        {
            
        }
    }
}
