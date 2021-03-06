﻿using System;
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

        public DataRow GetJobInfo(int iD)
        {
            DataTable table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getJobInfo";

                adapter.SelectCommand.Parameters.AddWithValue("@id", iD);

                adapter.Fill(table);

                adapter.SelectCommand.Connection.Open();
                var rows = table.Rows.Count > 0 ? table.Rows[0] : null;
                adapter.SelectCommand.Connection.Close();

                return rows;
            }
        }

        public bool InsertEmployee(EmployeePartial employee)
        {
            using(var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_register_employee";

                cmd.Parameters.AddWithValue("@id", employee.ApplicantID);
                cmd.Parameters.AddWithValue("@team", employee.Team.Team);
                cmd.Parameters.AddWithValue("@contract_type", employee.Contract.ContractType);
                cmd.Parameters.AddWithValue("@date_approved ", employee.SalaryInfo.DateApproved);
                cmd.Parameters.AddWithValue("@date_accepted ", employee.SalaryInfo.DateAccepted);
                cmd.Parameters.AddWithValue("@date_started ", employee.SalaryInfo.DateStarted);
                cmd.Parameters.AddWithValue("@approved_salary ", employee.SalaryInfo.ApprovedSalary);
                cmd.Parameters.AddWithValue("@annual_based_salary ", employee.SalaryInfo.AnnualBasedSalary);
                cmd.Parameters.AddWithValue("@annual_lang_allowance ", employee.SalaryInfo.AnnualLanguageAllowance);
                cmd.Parameters.AddWithValue("@shift_allowance ", employee.SalaryInfo.ShiftAllowance);
                cmd.Parameters.AddWithValue("@reloc_allowance ", employee.SalaryInfo.RelocationAllowance);
                cmd.Parameters.AddWithValue("@reloc_allowance_detail ", employee.SalaryInfo.RelocationAllowanceDetail);
                cmd.Parameters.AddWithValue("@cost_centre ", employee.SalaryInfo.CostCentre);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }

        public DataRow GetContactPerson(int Id)
        {
            DataTable table = new DataTable();
            using(var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getContactPerson";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);

                adapter.SelectCommand.Connection.Open();
                var rows = table.Rows.Count > 0 ? table.Rows[0] : null;
                adapter.SelectCommand.Connection.Close();

                return rows;
            }
        }

        public DataTable ShowDataFullname()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_showEmployeeName";

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

        public DataTable SearchData(string text, string schema, string table)
        {
            var dt = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_FindStringInTable";

                adapter.SelectCommand.Parameters.AddWithValue("@stringToFind", text);
                adapter.SelectCommand.Parameters.AddWithValue("@schema", schema);
                adapter.SelectCommand.Parameters.AddWithValue("@table", table);

                adapter.Fill(dt);

                return dt;
            }
        }

        public DataRow GetManagerName(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getManagerName";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetManagerID(string text)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getManagerID";

                adapter.SelectCommand.Parameters.AddWithValue("@name", text);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetEmployeeID(string name)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getEmployeeIDByName";

                adapter.SelectCommand.Parameters.AddWithValue("@name", name);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
        }

        public DataRow GetEmployeeName(int Id)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getEmployeeNameByID";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);
            }
            return table.Rows.Count > 0 ? table.Rows[0] : null;
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

        public DataRow GetHiringManager(string name)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getHiringManagerByName";

                adapter.SelectCommand.Parameters.AddWithValue("@name", name);

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

        public DataRow GetManager(int Id)
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

