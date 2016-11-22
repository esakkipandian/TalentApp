using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Domain.Talent.Candidate
{
    public class PersonalInformation : BaseDomain
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string AlternateContact { get; set; }
        public bool? IsExperienced { get; set; }
        public string ActualCTC { get; set; }
        public string ExpectedCTC { get; set; }
        public string NoticePeroid { get; set; }
        public bool haveOffer { get; set; }
        public string OfferDescription { get; set; }


    }
}
