using Data.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Types
{
    public interface IUserAccess
    {
        bool Login(User user);
        bool InsertUser(User user);
        DataTable ShowData();
    }
    public interface IExternalApplicationAccess
    {
        DataTable ShowAllData();
        DataRow GetDataByID(int id);
        bool Insert(ExternalApplicant obj);
        bool Update(ExternalApplicant obj, int id);
        bool Delete(int id);
    }
    public interface IEmployeeAccess
    {
        bool Insert(EmployeeMaster form);
        bool Insert(Employee employee);
        bool Insert(EmployeeAddress address);
        bool Insert(EmployeeSalaryInfo salary);
        bool Insert(EmployeeHiringManager manager);
        bool Insert();
    }
}