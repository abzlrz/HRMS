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
                adapter.SelectCommand.CommandText = "sp_showEmployee";

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

        public bool InsertUpdateData(EmployeeMaster employee)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.RegisterExistingEmployee;

                command.Parameters.AddWithValue("@id ", employee.ID);
                command.Parameters.AddWithValue("@firstname ", employee.Employee.Firstname);
                command.Parameters.AddWithValue("@middlename ", employee.Employee.Middlename);
                command.Parameters.AddWithValue("@lastname ", employee.Employee.Lastname);
                command.Parameters.AddWithValue("@primary_contact ", employee.Employee.PrimaryContact);
                command.Parameters.AddWithValue("@secondary_contact ", employee.Employee.SecondaryContact);
                command.Parameters.AddWithValue("@marital_status ", employee.Employee.MaritalStatus);
                command.Parameters.AddWithValue("@email ", employee.Employee.Email);
                command.Parameters.AddWithValue("@sss ", employee.Employee.SSS);
                command.Parameters.AddWithValue("@tin ", employee.Employee.TIN);
                command.Parameters.AddWithValue("@hdmf ", employee.Employee.HDMF);
                command.Parameters.AddWithValue("@bank_account ", employee.Employee.BPICard);
                command.Parameters.AddWithValue("@is_active", true);
                command.Parameters.AddWithValue("@houseno ", employee.Address.HouseNo);
                command.Parameters.AddWithValue("@street ", employee.Address.Street);
                command.Parameters.AddWithValue("@postal_area ", employee.Address.PostalArea);
                command.Parameters.AddWithValue("@postalno ", employee.Address.PostalNo);
                command.Parameters.AddWithValue("@hiringmanager_emp_id ", employee.HiringManager.ID);
                command.Parameters.AddWithValue("@hiringmanager_name ", employee.HiringManager.Name);
                command.Parameters.AddWithValue("@titantitle ", employee.TitanTitle.TitanTitle);
                command.Parameters.AddWithValue("@lang_req ", employee.TitanTitle.LanguageRequirements);
                command.Parameters.AddWithValue("@bucket ", employee.Bucket.Bucket);
                command.Parameters.AddWithValue("@arvatolevel ", employee.ArvatoLevel.ArvatoLevel);
                command.Parameters.AddWithValue("@position ", employee.JobTitle.Position);
                command.Parameters.AddWithValue("@team ", employee.Team.Team);
                command.Parameters.AddWithValue("@contract_type ", employee.ContractType.ContractType);
                command.Parameters.AddWithValue("@role ", employee.Role.Role);
                command.Parameters.AddWithValue("@owner_emp_id ", employee.Owner.EmployeeID);
                command.Parameters.AddWithValue("@owner_firstname ", employee.Owner.Firstname);
                command.Parameters.AddWithValue("@owner_lastname ", employee.Owner.Lastname);
                command.Parameters.AddWithValue("@date_approved ", employee.SalaryInfo.DateApproved);
                command.Parameters.AddWithValue("@date_accepted ", employee.SalaryInfo.DateAccepted);
                command.Parameters.AddWithValue("@date_started ", employee.SalaryInfo.DateStarted);
                command.Parameters.AddWithValue("@approved_salary ", employee.SalaryInfo.ApprovedSalary);
                command.Parameters.AddWithValue("@annual_based_salary ", employee.SalaryInfo.AnnualBasedSalary);
                command.Parameters.AddWithValue("@annual_lang_allowance ", employee.SalaryInfo.AnnualLanguageAllowance);
                command.Parameters.AddWithValue("@shift_allowance ", employee.SalaryInfo.ShiftAllowance);
                command.Parameters.AddWithValue("@reloc_allowance ", employee.SalaryInfo.RelocationAllowance);
                command.Parameters.AddWithValue("@reloc_allowance_detail ", employee.SalaryInfo.RelocationAllowanceDetail);
                command.Parameters.AddWithValue("@cost_centre ", employee.SalaryInfo.CostCentre);
                
                command.Connection.Open();
                var rows = command.ExecuteNonQuery();
                command.Connection.Close();

                return rows > 0;
            }
        }

        public bool DeleteEmployee(int Id)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_deleteEmployee";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }

        public DataRow GetSalaryInfo(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getSalaryInfo";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetEmployeeInfo(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getEmployeeByID";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetAddress(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getAddress";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetHiringManager(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getHiringManager";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetTitanTitle(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getTitanTitle";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetBucket(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getBucket";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetRole(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getRole";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetContractType(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getContractType";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetArvatoLevel(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getArvatoLevel";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetOwner(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getOwner";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetTeam(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getTeam";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetJob(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getJob";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }
    }
 }

