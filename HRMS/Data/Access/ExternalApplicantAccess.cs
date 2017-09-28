using Data.Types;
using System;
using System.ComponentModel;
using Data.Entities;
using System.Data;
using System.Data.SqlClient;
using static Data.Properties.Settings;

namespace Data.Access
{
    public class ExternalApplicantAccess
    {
        public DataTable ShowData()
        {
            var data = new DataTable();
            using (var adapter = new SqlDataAdapter())
            {
                adapter.SelectCommand = new SqlCommand();
                adapter.SelectCommand.Connection = new SqlConnection(Default.ConnectionString);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.CommandText = Default.ShowExternalApplicantData;

                adapter.Fill(data);
            }
            return data;
        }
       
    }
}
