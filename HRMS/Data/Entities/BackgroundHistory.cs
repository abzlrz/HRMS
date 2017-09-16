using System;

namespace Data.Entities
{
    public class Education
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Years SY { get; set; }
    }

    public struct Years
    {
        public DateTime _from { get; set; }
        public DateTime _to { get; set; }

        public Years(DateTime from, DateTime to)
        {
            _from = from;
            _to = to;
        }
    } 

    public class Work
    {
        public string PositionTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SupervisorName { get; set; }
        public Years FromTo { get; set; }
        public string Nature { get; set; }
        public string MonthlyCompensation { get; set; }
        public string ReasonForLeaving { get; set; }
    }
    
    public class Illness
    {
        public bool HadIllness { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public bool IsPerpetual { get; set; }
    }

    public class Conviction
    {
        public bool IsConvicted { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }

    public class LegalCase
    {
        public bool IsLawSuited { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
