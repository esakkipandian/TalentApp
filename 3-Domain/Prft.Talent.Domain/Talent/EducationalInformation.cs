using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Domain.Talent
{
    public class EducationalInformation : BaseDomain
    {
        public int CandidateId { get; set; }
        public string DegreeName { get; set; }
        public string Course { get; set; }
        public string Specialization { get; set; }
        public string University { get; set; }
        public string College { get; set; }        
        public string PassedOut { get; set; }
        public decimal Percentage { get; set; }
    }
}
