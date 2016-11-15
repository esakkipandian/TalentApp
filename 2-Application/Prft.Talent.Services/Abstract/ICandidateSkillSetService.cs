using Prft.Talent.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract
{
    public interface ICandidateSkillSetService : IApi
    {
        Task<CandidateSkillSetResponse> GetCandidateSkillSetsAsync();

        Task<CandidateSkillSetResponse> GetCandidateSkillSetAsync(CandidateSkillSetRequest CandidateSkillSetId);
    }
}
