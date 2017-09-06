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
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.SelectCommand.CommandText = "select * from [User].[User] where [Username] = @username AND [Password] = @password";
                adapter.SelectCommand.Parameters.AddWithValue("@username", user.Username);
                adapter.SelectCommand.Parameters.AddWithValue("@password", user.Password);

                adapter.Fill(table);
                row = table.Rows.Count > 0 ? table.Rows[0] : null;

                return row == null ? false : true;
            }
        }
        public UserAccess(string connectionString)
        {
            this.Connection = new SqlConnection(connectionString);
        }
    }
}
