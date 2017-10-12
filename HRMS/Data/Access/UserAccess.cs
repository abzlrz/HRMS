using Data.Entities;
using System.Data;
using System.Data.SqlClient;
using System;
using static Data.Properties.Settings;

namespace Data.Access
{
    public class UserAccess
    {
        public DataRow GetUserByID(int Id)
        {
            DataTable table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getUserByID";

                adapter.SelectCommand.Parameters.AddWithValue("@id", Id);

                adapter.Fill(table);

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public bool LoginAsAdmin(User user)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_user_login_admin";

                adapter.SelectCommand.Parameters.AddWithValue("@id", int.Parse(user.Username));
                adapter.SelectCommand.Parameters.AddWithValue("@password", user.Password);

                adapter.Fill(table);

                return table.Rows.Count > 0 ? true : false;
            }
        }

        public bool Login(User user)
        {
            var table = new DataTable();
            using(var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_user_login_admin";

                adapter.SelectCommand.Parameters.AddWithValue("@id", int.Parse(user.Username));
                adapter.SelectCommand.Parameters.AddWithValue("@password", user.Password);

                adapter.Fill(table);

                return table.Rows.Count > 0 ? true : false;
            }
        }

        public void ReloadHRUsers()
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_reload_hr_users";

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public DataTable ShowHRUsers()
        {
            DataTable table = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_showHRUsers";

                adapter.Fill(table);
            }
            return table;
        }

        public bool UpdateUserPassword(string text, int id)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_updateUserPassword";

                cmd.Parameters.AddWithValue("@id", id); 
                cmd.Parameters.AddWithValue("@password", text);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }

        public bool UnblockUser(int Id)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_unblockUser";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }
    }
}