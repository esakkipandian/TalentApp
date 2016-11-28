using Prft.Talent.Domain.Talent.Candidate;
using Prft.Talent.Services.Api.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract.Candidate
{
    public interface ICandidateSkillSetService : IApi 
    {
        Task<CandidateSkillSetResponse> GetCandidateSkillSetsAsync(CandidateSkillSetIdRequest candidateSkillSetRequest);

        Task<SetCandidateSkillSetResponse> AddCandidateSkillSetsAsync(CandidateSkillSetRequest candidateSkillSetRequest);

        Task<SetCandidateSkillSetResponse> DeleteCandidateSkillSetsAsync(CandidateSkillSetIdRequest candidateSkillSetRequest);

        Task<SetCandidateSkillSetResponse> UpdateCandidateSkillSetAsync(CandidateSkillSetRequest candidateSkillSetRequest);

    }
}
