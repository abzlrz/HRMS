using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace Data.Entities
{

    public class ExternalApplicant
    {
        public Applicant Applicant { get; set; }
        public ApplicationSource ApplicationSource { get; set; }
        public DataTable EducationHistory { get; set; }
        public DataTable EmploymentHistory { get; set; }
        public Illness Illness { get; set; }
        public Illness PerpetualIllness { get; set; }
        public LegalCase LegalCase { get; set; }
        public LegalConviction LegalConviction { get; set; }
        public MedicalOperation MedicalOperation { get; set; }
        public ContactPerson Contacts { get; set; }
        public ApplicantAddress PresentAddress { get; set; }
        public ApplicantAddress PermanentAddress { get; set; }
        public Position ApplicationPosition { get; set; }
    }

    public class ApplicationSource
    {
        public int ApplicantID { get; set; }
        public string Source { get; set; }
        public int ReferralID { get; set; }
        public string ReferralName { get; set; }
    }

    public class Applicant
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Nickname { get; set; } = null;
        public string PrimaryContactNumber { get; set; }
        public string SecondaryContactNumber { get; set; } = null;
        public bool IsUnder18 { get; set; }
        public string Email { get; set; }
        public string SSS { get; set; }
        public string TIN { get; set; }
        public string HDMF { get; set; }
        public string BankAccount { get; set; }
        public DateTime ApplicationDate { get; set; }
    }

    public class Education
    {
        public int ApplicantID { get; set; }
        public string School { get; set; }
        public string Location { get; set; }
        public string AcademicDegree { get; set; }
        public string CourseProgram { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class Employment
    {
        public int ApplicantID { get; set; }
        public string PositionTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Supervisor { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Nature { get; set; }
        public decimal MonthlyCompensation { get; set; }
        public string ReasonForLeaving { get; set; }
    }

    public class Illness
    {
        public int ApplicantID { get; set; }
        public string IsDiagnosed { get; set; }
        public string Details { get; set; }
    }

    public class LegalCase
    {
        public int ApplicantID { get; set; }
        public string IsLawsuited { get; set; }
        public string Details { get; set; }
    }

    public class LegalConviction
    {
        public int ApplicantID { get; set; }
        public string IsConvicted { get; set; }
        public string Details { get; set; }
    }

    public class MedicalOperation
    {
        public int ApplicantID { get; set; }
        public string IsOperated { get; set; }
        public string Details { get; set; }
    }

    public class Position
    {
        public int ApplicantID { get; set; }
        public string PositionTitle { get; set; }
        public string PreferredSite { get; set; }
    }

    public class ApplicantAddress
    {
        public int ApplicantID { get; set; }
        public string HouseNo { get; set; } = null;
        public string Street { get; set; }
        public string PostalArea { get; set; }
        public string PostalNo { get; set; }
    }

    public class ContactPerson
    {
        public int ApplicantID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string ContactNumber { get; set; }
        public string RelationShip { get; set; }
    }
}