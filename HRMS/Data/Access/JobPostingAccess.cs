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
                adapter.SelectCommand.CommandText = Default.ShowJobPostingData;

                adapter.Fill(table);
            }

            return table;
        }

        public bool InsertData(JobPosting item)
        {
            using(var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(Default.ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = Default.InsertJobPostings;

                cmd.Parameters.AddWithValue("@positiontype", item.PositionType);
                cmd.Parameters.AddWithValue("@position", item.Position);
                cmd.Parameters.AddWithValue("@posted_date", item.PostedDate);
                cmd.Parameters.AddWithValue("@close_date", item.CloseDate);
                cmd.Parameters.AddWithValue("@wage", item.Wage);
                cmd.Parameters.AddWithValue("@headcount", item.HeadCount);
                cmd.Parameters.AddWithValue("@location", item.Location);
                cmd.Parameters.AddWithValue("@qualification", item.Qualification);
                cmd.Parameters.AddWithValue("@jobdesc", item.JobDescription);
                cmd.Parameters.AddWithValue("@comments", item.Comments);

                cmd.Connection.Open();
                var rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

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
                adapter.SelectCommand.CommandText = Default.GetJobPostingByID;

                adapter.SelectCommand.Parameters.AddWithValue("@id", id);

                adapter.Fill(table);
                row = table.Rows.Count > 0 ? table.Rows[0] : null;

                return row;
            }
        }
    }
}
