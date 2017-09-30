using System;
using System.Data;
using System.Data.SqlClient;
using static Data.Properties.Settings;

namespace Data.Access
{
    public class DataAccess
    {
        public EmployeeAccess Employee { get; set; } = new EmployeeAccess();
        public ExternalApplicantAccess ExternalApplicant { get; set; } = new ExternalApplicantAccess();
        public InternalApplicantAccess InternalApplicant { get; set; } = new InternalApplicantAccess();

        #region SELECT
        public DataTable ShowTitanTitleData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowTitanTitleData;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowReasonAnalysisData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowReasonAnalysisData;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowRoleData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowRoleData;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowReasonForLeavingData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowReasonForLeavingData;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowAppraisalTypeData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowAppraisalType;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowBucketData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowBucketData;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowJobTitleData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowJobTitleData;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowTeamData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowTeamData;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowContractType()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowContractType;

                adapter.Fill(data);
            }
            return data;
        }
        public DataTable ShowApplicationSourceData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowApplicationSourceData;

                adapter.Fill(data);
            }
            return data;
        }
        #endregion

        #region INSERT
        public bool InsertAppSource(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertAppSource;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool InsertAppraisalType(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertAppraisalType;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool InsertBucket(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertBucket;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool InsertJobTitle(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertJobTitle;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool InsertReasonAnalysis(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertReasonAnalysis;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool InsertReasonForLeaving(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertReasonForLeaving;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool InsertRole(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertRole;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool InsertTeam(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertTeam;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool InsertTitanTitle(string text)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.InsertTitanTitle;

                command.Parameters.AddWithValue("@val", text);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        #endregion

        #region DELETE
        public bool DeleteApplicationSource(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteAppSource;
                
                command.Parameters.AddWithValue("@val", val);
                
                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool DeleteAppraisalType(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteAppraisalType;

                command.Parameters.AddWithValue("@val", val);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool DeleteBucket(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteBucket;

                command.Parameters.AddWithValue("@val", val);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool DeleteJobTitle(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteJobTitle;

                command.Parameters.AddWithValue("@val", val);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public bool DeleteReasonAnalysis(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteReasonAnalysis;

                command.Parameters.AddWithValue("@val", val);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool DeleteReasonForLeaving(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteReasonForLeaving;

                command.Parameters.AddWithValue("@val", val);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool DeleteTeam(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteTeam;

                command.Parameters.AddWithValue("@val", val);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool DeleteRole(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteRole;

                command.Parameters.AddWithValue("@val", val);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }
        public bool DeleteTitanTitle(string val)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = Default.DeleteTitanTitle;

                command.Parameters.AddWithValue("@val", val);

                command.Connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                command.Connection.Close();

                return rowsAffected > 0;
            }
        }       

        #endregion
    }
}
