namespace Data.Entities
{
    public class ReferralDue
    {
        public int EmployeeID { get; set; }
        public int ApplicantID { get; set; }
        public string AgencyName { get; set; }
        public string AgencyFee { get; set; }
        public decimal RefDue { get; set; }
    }
}