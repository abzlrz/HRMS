namespace Data
{
    public class Applicant
    {

    }

    public class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string TitanTitle { get; set; }
        public string LanguageReq { get; set; }
        public HiringManager Manager { get; set; }
        public EmployeeRequirements Requirements { get; set; }

    }

    public class HiringManager
    {
        public string Name { get; set; }
        public string EmployeeID { get; set; }
    }

    public class EmployeeRequirements
    {
        public string TIN { get; set; }
        public string SSS { get; set; }
        public string PhilHealth { get; set; }
        public string PagIbig { get; set; }
        public string ValidID { get; set; }
        public string IDPicture { get; set; }
        public string NBI { get; set; }
        public string COE { get; set; }
        public string TOR { get; set; }
        public string NSO { get; set; }
        public string NewHireAcknowledgement { get; set; }
        public string NDA { get; set; }
        public string InterviewDocs { get; set; }
        public string Resume { get; set; }
        public string InvestigationCheckForm { get; set; }
        public string InvestigationResult { get; set; }
        public string EmployeeInformationForm { get; set; }
        public string JobDescription { get; set; }
        public string EmployeeContract { get; set; }
        public string PEMESlip { get; set; }
    }
}
