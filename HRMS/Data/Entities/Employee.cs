using System;

namespace Data.Entities
{
    public class ExistingEmployeeRegistrationForm
    {
        public Employee Employee { get; set; }
        public EmployeeAddress Address { get; set; }
        public EmployeeHiringManager HiringManager { get; set; }
        public EmployeeTitanTitle TitanTitle { get; set; }
        public EmployeeBucket Bucket { get; set; }
        public EmployeeArvatoLevel ArvatoLevel { get; set; }
        public EmployeeJobTitle JobTitle { get; set; }
        public EmployeeTeam Team { get; set; }
        public EmployeeContractType ContractType { get; set; }
        public EmployeeSalaryInfo SalaryInfo { get; set; }
    }

    public class Employee
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string PrimaryContact { get; set; }
        public string SecondaryContact { get; set; }
        public string MaritalStatus { get; set; }
        public string Email { get; set; }
        public string SSS { get; set; }
        public string TIN { get; set; }
        public string HDMF { get; set; }
        public string BPICard { get; set; }
    }

    public class EmployeeAddress
    {
        public int EmployeeID { get; set; }
        public string HouseNo { get; set; }
        public string Street { get; set; }
        public string PostalArea { get; set; }
        public string PostalNo { get; set; }
    }

    public class EmployeeSalaryInfo
    {
        public int EmployeeID { get; set; }
        public DateTime DateApproved { get; set; }
        public DateTime DateAccepted { get; set; }
        public DateTime DateStarted { get; set; }
        public decimal ApprovedSalary { get; set; }
        public decimal AnnualBasedSalary { get; set; }
        public decimal AnnualLanguageAllowance { get; set; }
        public decimal ShiftAllowance { get; set; }
        public decimal RelocationAllowance { get; set; }
        public decimal RelocationAllowanceDetail { get; set; }
        public decimal CostCentre { get; set; }
    }

    public class EmployeeHiringManager
    {
        public int EmployeeID { get; set; }
        public int HiringManagerID { get; set; }
        public string HiringManagerName { get; set; }
    }
    
    public class EmployeeTitanTitle
    {
        public int EmployeeID { get; set; }
        public string TitanTitle { get; set; }
        public string LanguageRequirements { get; set; }
    }

    public class EmployeeBucket
    {
        public int EmployeeID { get; set; }
        public string Bucket { get; set; }
    }

    public class EmployeeTeam
    {
        public int EmployeeID { get; set; }
        public string Team { get; set; }
    }

    public class EmployeeJobTitle
    {
        public int EmployeeID { get; set; }
        public string Position { get; set; }
    }

    public class EmployeeContractType
    {
        public int EmployeeID { get; set; }
        public string ContractType { get; set; }
    }

    public class EmployeeArvatoLevel
    {
        public int EmployeeID { get; set; }
        public string ArvatoLevel { get; set; }
    }

    public class EmployeeOwner
    {
        public int EmployeeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    public class EmployeeRole
    {
        public int EmployeeID { get; set; }
        public string Role { get; set; }
    }
}
