using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class JobPosting
    {
        public int ID { get; set; }
        public string PositionType { get; set; }
        public string Position { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Wage { get; set; }
        public int HeadCount { get; set; }
        public string Location { get; set; }
        public string Benefits { get; set; }
        public string Qualification { get; set; }
        public string JobDescription { get; set; }
        public string Comments { get; set; }
    }
}
