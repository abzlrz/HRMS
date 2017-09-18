using Data.Entities;
using System.Data;
using System.Data.SqlClient;
using Data.Types;

namespace Data.Access
{
    public class UserAccess : IUserAccess
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
                adapter.SelectCommand.CommandText = "sp_login";
                adapter.SelectCommand.Parameters.AddWithValue("@id", int.Parse(user.ID));
                adapter.SelectCommand.Parameters.AddWithValue("@password", user.Password);

                adapter.Fill(table);
                row = table.Rows.Count > 0 ? table.Rows[0] : null;

                return row == null ? false : true;
            }
        }
        public bool ChangePassword(User user)
        {
            using (var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(DB.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_changePassword";

                command.Parameters.AddWithValue("@id", user.ID);
                command.Parameters.AddWithValue("@password", user.Password);

                command.Connection.Open();
                var rows = command.ExecuteNonQuery();
                command.Connection.Close();

                return rows > 0;
            }
        }
    }
}