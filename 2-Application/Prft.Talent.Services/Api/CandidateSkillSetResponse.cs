using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Api
{
    public class CandidateSkillSetResponse : ResponseBase
    {
        public IEnumerable<CandidateSkillSet> CandidateSkillSets { get; set; }
    }

    public class CandidateSkillSetRequest : RequestBase
    {
        public int CandidateSkillSetId { get; set; }

        public static implicit operator int(CandidateSkillSetRequest v)
        {
            throw new NotImplementedException();
        }
    }
}
