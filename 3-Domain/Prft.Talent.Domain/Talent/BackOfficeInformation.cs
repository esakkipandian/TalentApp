using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Domain.Talent
{
   public  class BackOfficeInformation:BaseDomain
    {

        public int pk { get; set; }
        public int CandidateId { get; set; }
        public decimal CTC { get; set; }
        public decimal VaraiblePay { get; set; }
        public DateTime LastIncrementedDate { get; set; }
        public bool IsForm16Verified { get; set; }

    }
}
