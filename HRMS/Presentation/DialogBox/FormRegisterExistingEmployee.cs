using Data.Access;
using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormRegisterExistingEmployee : Form
    {
        private ExistingEmployee employee;
        private DataAccess context;

        public FormRegisterExistingEmployee()
        {
            InitializeComponent();

            this.context = new DataAccess();
            this.employee = new ExistingEmployee();
            this.controlSalaryInfo1.btn_save.Click += Btn_save_Click;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (controlSalaryInfo1.ValidateFields())
                InsertData();
            else
                MessageBox.Show("Please complete all the required fields!");
        }

        private void InsertData()
        {
            // load inputs first from salary info
            controlSalaryInfo1.LoadInputs();
            employee.ID = 0;
            employee.Employee = controlEmployeeInfo1.employee;
            employee.Address = controlEmployeeInfo1.address;
            employee.HiringManager = controlEmployeeEvaluation1.hiringmanager;
            employee.TitanTitle = controlEmployeeEvaluation1.titantitle;
            employee.Bucket = controlEmployeeEvaluation1.bucket;
            employee.ArvatoLevel = controlEmployeeEvaluation1.arvatoLevel;
            employee.JobTitle = controlEmployeeEvaluation1.jobtitle;
            employee.Team = controlEmployeeEvaluation1.team;
            employee.ContractType = controlEmployeeEvaluation1.contract_type;
            employee.Role = controlEmployeeEvaluation1.role;
            employee.Owner = controlEmployeeEvaluation1.owner;
            employee.SalaryInfo = controlSalaryInfo1.salaryInfo;

            var success = context.Employee.InsertData(employee);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                this.Dispose();
                this.Close();
            }
            else
                MessageBox.Show("Error.");
        }

        private void FormRegisterExistingEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            controlEmployeeInfo1.ClearAllFields();
            controlEmployeeEvaluation1.ClearAllFields();
            controlSalaryInfo1.ClearAllFields();

            controlEmployeeInfo1.BringToFront();
        }
    }
}
