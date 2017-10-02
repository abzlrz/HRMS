using Data.Entities;
using System.Data;
using System.Data.SqlClient;
using Data.Types;
using System;
using static Data.Properties.Settings;

namespace Data.Access
{
    public class UserAccess
    {
        public bool Login(User user)
        {
            var table = new DataTable();
            DataRow row;

            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(DB.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "[User].sp_login";
                adapter.SelectCommand.Parameters.AddWithValue("@id", user.Username);
                adapter.SelectCommand.Parameters.AddWithValue("@password", user.Password);

                adapter.Fill(table);
                row = table.Rows.Count > 0 ? table.Rows[0] : null;

                return row == null ? false : true;
            }
        }

        public DataRow GetUserByID(int id)
        {
            var table = new DataTable();
            DataRow row;
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.GetUserByID;

                adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                adapter.Fill(table);
                row = table.Rows.Count > 0 ? table.Rows[0] : null;

                return row;
            }
        }

        public bool Insert(User user)
        {
            using(var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Default.InsertUser;

                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }

        public DataTable ShowData()
        {
            
            var data = new DataTable();
            using(var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowBucketData;

                adapter.Fill(data);
            }
            return data;
            throw new NotImplementedException();
        }

        public bool Update(int id, User user)
        {
            using(var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Default.UpdateUser;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }
        public bool Delete(int id)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Default.DeleteUser;

                cmd.Parameters.AddWithValue("@id", id);

                cmd.Connection.Open();
                var row = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return row > 0;
            }
        }

    }
}