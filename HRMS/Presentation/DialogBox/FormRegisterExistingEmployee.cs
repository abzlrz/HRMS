using Data.Entities;
using System;
using System.Windows.Forms;

namespace Presentation.DialogBox
{
    public partial class FormRegisterExistingEmployee : Form
    {
        private ExistingEmployeeRegistrationForm employee;
        public FormRegisterExistingEmployee()
        {
            InitializeComponent();
            this.employee = new ExistingEmployeeRegistrationForm();
            controlSalaryInfo1.btn_save.Click += Btn_save_Click;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            employee.Employee = controlEmployeeInfo1.GetEmployeeInfo();
            employee.Address = controlEmployeeInfo1.GetAddress();
            employee.HiringManager = controlEmployeeEvaluation1.GetHiringManager();
            employee.TitanTitle = controlEmployeeEvaluation1.GetTitanTitle();
            employee.Bucket = controlEmployeeEvaluation1.GetBucket();
            employee.ArvatoLevel = controlEmployeeEvaluation1.GetArvatoLevel();
            employee.JobTitle = controlEmployeeEvaluation1.GetJobTitle();
            employee.Team = controlEmployeeEvaluation1.GetTeam();
            employee.ContractType = controlEmployeeEvaluation1.GetContractType();
            employee.SalaryInfo = controlSalaryInfo1.GetSalaryInfo();

            InsertData(employee);
        }

        private void InsertData(ExistingEmployeeRegistrationForm employee)
        {
            throw new NotImplementedException();
        }
    }
}
