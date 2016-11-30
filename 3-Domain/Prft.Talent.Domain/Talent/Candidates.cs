using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Domain.Talent
{
    public class Candidates :BaseDomain
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public decimal ActualCTC { get; set; }
        public decimal ExpectedCTC { get; set; }       
        public string OfferDescription { get; set; }
        public int NoticePeriod { get; set; }
        public int Source { get; set; }
        public decimal ExperiencedYears { get; set; }
        public int CampusSelected { get; set; }
        public DateTime ScheduledDate { get; set; }
    }
}