using Data.Access;
using Data.Entities;
using System;
using System.Windows.Forms;
using Presentation.DialogBox.ExistingEmployeeRegistration;
using System.Data;

namespace Presentation.DialogBox
{
    public partial class FormRegisterExistingEmployee : Form
    {
        private EmployeeMaster employee;
        private DataAccess context;
        private int ID;
        public FormRegisterExistingEmployee(int id)
        {
            InitializeComponent();

            this.context = new DataAccess();
            this.employee = new EmployeeMaster();

            if(id == 0)
            {
                this.controlSalaryInfo1.btn_save.Click += InsertClick;
            }
            else
            {
                ID = id;
                PopulateFields(controlEmployeeInfo1, controlEmployeeEvaluation1, controlSalaryInfo1, id);
                this.controlSalaryInfo1.btn_save.Click += UpdateClick;
            }
        }

        private void PopulateFields(ControlEmployeeInfo controlEmployeeInfo1,
            ControlEmployeeEvaluation controlEmployeeEvaluation1,
            ControlSalaryInfo controlSalaryInfo1, int id)
        {
            controlEmployeeInfo1.ID = id;
            controlEmployeeEvaluation1.ID = id;
            controlSalaryInfo1.ID = id;
        }

        private void UpdateClick(object sender, EventArgs e)
        {
            if (controlSalaryInfo1.ValidateFields())
                UpdateData();
            else
                MessageBox.Show("Please complete all the required fields!");
        }

        private void UpdateData()
        {
            controlSalaryInfo1.LoadInputs();
            employee.ID = ID;
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

            var success = context.Employee.InsertUpdateData(employee);
            if (success)
            {
                MessageBox.Show("Data Successfully Updated!");
                this.Dispose();
                this.Close();
            }
            else
                MessageBox.Show("Error.");
        }

        private void InsertClick(object sender, EventArgs e)
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

            var success = context.Employee.InsertUpdateData(employee);
            if (success)
            {
                MessageBox.Show("Data Successfully Added!");
                this.Dispose();
                this.Close();
            }
            else
                MessageBox.Show("Error.");
        }
    }
}
