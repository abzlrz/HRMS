using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using static Data.Properties.Settings;

namespace Data.Access
{
    public class EmployeeAccess
    {

        public DataTable ShowData()
        {
            var data = new DataTable();
            using(var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowEmployeeWithPosition;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowHiringManagerData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowHiringManagerData;

                adapter.Fill(data);
            }
            return data;
        }
        public bool InsertData(ExistingEmployee employee)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.RegisterExistingEmployee;

                command.Parameters.AddWithValue("@firstname", employee.Employee.Firstname);
                command.Parameters.AddWithValue("@middlename", employee.Employee.Middlename);
                command.Parameters.AddWithValue("@lastname", employee.Employee.Lastname);
                command.Parameters.AddWithValue("@primarycontact", employee.Employee.PrimaryContact);
                command.Parameters.AddWithValue("@secondarycontact", employee.Employee.SecondaryContact);
                command.Parameters.AddWithValue("@maritalstatus", employee.Employee.MaritalStatus);
                command.Parameters.AddWithValue("@email", employee.Employee.Email);
                command.Parameters.AddWithValue("@sss", employee.Employee.SSS);
                command.Parameters.AddWithValue("@tin", employee.Employee.TIN);
                command.Parameters.AddWithValue("@hdmf", employee.Employee.HDMF);
                command.Parameters.AddWithValue("@bankaccount", employee.Employee.BPICard);
                command.Parameters.AddWithValue("@houseno", employee.Address.HouseNo);
                command.Parameters.AddWithValue("@street", employee.Address.Street);
                command.Parameters.AddWithValue("@postal_area", employee.Address.PostalArea);
                command.Parameters.AddWithValue("@postalno", employee.Address.PostalNo);
                command.Parameters.AddWithValue("@hiringmanager_ID", employee.HiringManager.ID);
                command.Parameters.AddWithValue("@hiringmanager_name", employee.HiringManager.Name);
                command.Parameters.AddWithValue("@titantitle", employee.TitanTitle.TitanTitle);
                command.Parameters.AddWithValue("@language_req", employee.TitanTitle.LanguageRequirements);
                command.Parameters.AddWithValue("@bucket", employee.Bucket.Bucket);
                command.Parameters.AddWithValue("@arvatolevel", employee.ArvatoLevel.ArvatoLevel);
                command.Parameters.AddWithValue("@position", employee.JobTitle.Position);
                command.Parameters.AddWithValue("@team", employee.Team.Team);
                command.Parameters.AddWithValue("@contract_type", employee.ContractType.ContractType);
                command.Parameters.AddWithValue("@date_approved", employee.SalaryInfo.DateApproved);
                command.Parameters.AddWithValue("@date_accepted", employee.SalaryInfo.DateAccepted);
                command.Parameters.AddWithValue("@date_started", employee.SalaryInfo.DateStarted);
                command.Parameters.AddWithValue("@approved_salary", employee.SalaryInfo.ApprovedSalary);
                command.Parameters.AddWithValue("@annualbased_salary", employee.SalaryInfo.AnnualBasedSalary);
                command.Parameters.AddWithValue("@annual_lang_allowance", employee.SalaryInfo.AnnualLanguageAllowance);
                command.Parameters.AddWithValue("@shift_allowance", employee.SalaryInfo.ShiftAllowance);
                command.Parameters.AddWithValue("@reloc_allowance", employee.SalaryInfo.RelocationAllowance);
                command.Parameters.AddWithValue("@reloc_allowance_detail", employee.SalaryInfo.RelocationAllowanceDetail);
                command.Parameters.AddWithValue("@costcentre", employee.SalaryInfo.CostCentre);

                command.Connection.Open();
                var rows = command.ExecuteNonQuery();
                command.Connection.Close();

                return rows > 0;
            }
        }
        public bool UpdateData(int? Id, ExistingEmployee employee)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.UpdateEmployee;
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@firstname", employee.Employee.Firstname);
                command.Parameters.AddWithValue("@middlename", employee.Employee.Middlename);
                command.Parameters.AddWithValue("@lastname", employee.Employee.Lastname);
                command.Parameters.AddWithValue("@primarycontact", employee.Employee.PrimaryContact);
                command.Parameters.AddWithValue("@secondarycontact", employee.Employee.SecondaryContact);
                command.Parameters.AddWithValue("@maritalstatus", employee.Employee.MaritalStatus);
                command.Parameters.AddWithValue("@email", employee.Employee.Email);
                command.Parameters.AddWithValue("@sss", employee.Employee.SSS);
                command.Parameters.AddWithValue("@tin", employee.Employee.TIN);
                command.Parameters.AddWithValue("@hdmf", employee.Employee.HDMF);
                command.Parameters.AddWithValue("@bankaccount", employee.Employee.BPICard);
                command.Parameters.AddWithValue("@houseno", employee.Address.HouseNo);
                command.Parameters.AddWithValue("@street", employee.Address.Street);
                command.Parameters.AddWithValue("@postal_area", employee.Address.PostalArea);
                command.Parameters.AddWithValue("@postalno", employee.Address.PostalNo);
                command.Parameters.AddWithValue("@hiringmanager_ID", employee.HiringManager.ID);
                command.Parameters.AddWithValue("@hiringmanager_name", employee.HiringManager.Name);
                command.Parameters.AddWithValue("@titantitle", employee.TitanTitle.TitanTitle);
                command.Parameters.AddWithValue("@language_req", employee.TitanTitle.LanguageRequirements);
                command.Parameters.AddWithValue("@bucket", employee.Bucket.Bucket);
                command.Parameters.AddWithValue("@arvatolevel", employee.ArvatoLevel.ArvatoLevel);
                command.Parameters.AddWithValue("@position", employee.JobTitle.Position);
                command.Parameters.AddWithValue("@team", employee.Team.Team);
                command.Parameters.AddWithValue("@contract_type", employee.ContractType.ContractType);
                command.Parameters.AddWithValue("@date_approved", employee.SalaryInfo.DateApproved);
                command.Parameters.AddWithValue("@date_accepted", employee.SalaryInfo.DateAccepted);
                command.Parameters.AddWithValue("@date_started", employee.SalaryInfo.DateStarted);
                command.Parameters.AddWithValue("@approved_salary", employee.SalaryInfo.ApprovedSalary);
                command.Parameters.AddWithValue("@annualbased_salary", employee.SalaryInfo.AnnualBasedSalary);
                command.Parameters.AddWithValue("@annual_lang_allowance", employee.SalaryInfo.AnnualLanguageAllowance);
                command.Parameters.AddWithValue("@shift_allowance", employee.SalaryInfo.ShiftAllowance);
                command.Parameters.AddWithValue("@reloc_allowance", employee.SalaryInfo.RelocationAllowance);
                command.Parameters.AddWithValue("@reloc_allowance_detail", employee.SalaryInfo.RelocationAllowanceDetail);
                command.Parameters.AddWithValue("@costcentre", employee.SalaryInfo.CostCentre);

                command.Connection.Open();
                var rows = command.ExecuteNonQuery();
                command.Connection.Close();

                return rows > 0;
            }
        }
    }
}
