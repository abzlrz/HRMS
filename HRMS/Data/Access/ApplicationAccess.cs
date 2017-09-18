using Data.Types;
using System;
using System.ComponentModel;
using Data.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Access
{
    public class ExternalApplicationAccess : IExternalApplicationAccess
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataRow GetDataByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ExternalApplicant obj)
        {
            using(var command = new SqlCommand())
            {
                command.Connection = new SqlConnection(DB.ConnectionString);
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_";
            }

            throw new NotImplementedException();
        }

        public DataTable ShowAllData()
        {
            throw new NotImplementedException();
        }

        public bool Update(ExternalApplicant obj, int id)
        {
            throw new NotImplementedException();
        }
    }
}
