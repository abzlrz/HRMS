using Data.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Access
{
    public class UserAccess
    {
        SqlConnection Connection { get; set; }

        public bool Login(User user)
        {
            var table = new DataTable();
            DataRow row;

            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = Connection;
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_Login";
                adapter.SelectCommand.Parameters.AddWithValue("@username", int.Parse(user.Username));
                adapter.SelectCommand.Parameters.AddWithValue("@password", user.Password);

                adapter.Fill(table);
                row = table.Rows.Count > 0 ? table.Rows[0] : null;

                return row == null ? false : true;
            }
        }
        public bool ChangePassword(int id, User user)
        {
            return false;
        }
        public UserAccess()
        {
            this.Connection = new SqlConnection(DBConnection.ConnectionString);
        }
    }
}
