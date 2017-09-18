using Data.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Types
{
    public interface IUserAccess
    {
        bool Login(User user);
        bool ChangePassword(User user);
    }
    public interface IExternalApplicationAccess
    {
        DataTable ShowAllData();
        DataRow GetDataByID(int id);
        bool Insert(ExternalApplicant obj);
        bool Update(ExternalApplicant obj, int id);
        bool Delete(int id);
    }
}