using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Domain.Talent.Candidate
{
    public class CandidateSkillSet : BaseDomain
    {
        public int CandidateSkillSetId { get; set; }

        public int CandidateId { get; set; }

        public int SkillId { get; set; }

        public int Rating { get; set; }

        public DateTime? SinceLastUsed { get; set; }

        public bool? IsPrimary { get; set; }

        public bool? IsActive { get; set; }
    }
}
