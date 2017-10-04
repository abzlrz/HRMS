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
    public class JobPostingAccess
    {
        public DataTable ShowData()
        {
            var table = new DataTable();

            using(var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_showJobPosting";

                adapter.Fill(table);
            }

            return table;
        }

        public bool InsertUpdateData(JobPosting item)
        {
            using(var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(Default.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_insertUpdateJobPosting";

                command.Parameters.AddWithValue("@id", item.ID);
                command.Parameters.AddWithValue("@position_type ", item.PositionType);
                command.Parameters.AddWithValue("@position ", item.Position);
                command.Parameters.AddWithValue("@posted_date ", item.PostedDate);
                command.Parameters.AddWithValue("@close_date ", item.CloseDate);
                command.Parameters.AddWithValue("@wage", item.Wage);
                command.Parameters.AddWithValue("@head_count", item.HeadCount);
                command.Parameters.AddWithValue("@location ", item.Location);
                command.Parameters.AddWithValue("@benefits", item.Benefits);
                command.Parameters.AddWithValue("@qualification ", item.Qualification);
                command.Parameters.AddWithValue("@job_desc ", item.JobDescription);
                command.Parameters.AddWithValue("@comments ", item.Comments);
                
                command.Connection.Open();
                var rows = command.ExecuteNonQuery();
                command.Connection.Close();

                return rows > 0;
            }
        }

        public DataRow GetDataByID(int id)
        {
            var table = new DataTable();
            DataRow row;
            using(var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = "sp_getJobPostingByID";

                adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                adapter.Fill(table);
                row = table.Rows.Count > 0 ? table.Rows[0] : null;

                return row;
            }
        }

        public bool Delete(int Id)
        {
            using(var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_deleteJobPosting";

                cmd.Parameters.AddWithValue("@id", Id);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rows > 0;
            }
        }
    }
}
