using Prft.Talent.Domain.Talent.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Api.Candidate
{
    public class CandidateSkillSetResponse : ResponseBase
    {
        public IEnumerable<CandidateSkillSet> CandidateSkillSet { get; set; }
    }

    public class SetCandidateSkillSetResponse : ResponseBase
    {
        public int SuccessFlag { get; set; }
    }

    public class CandidateSkillSetRequest : RequestBase
    {
        public CandidateSkillSet CandidateSkillSet { get; set; }
    }

    public class CandidateSkillSetIdRequest : RequestBase
    {
        public int CandidateSkillSetId { get; set; }
    }
}
