using Prft.Talent.Data.Repositories.Abstract.Candidate;
using Prft.Talent.Services.Abstract.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Services.Api.Candidate;

namespace Prft.Talent.Services.Concrete.Candidate
{
    public class CandidateSkillSetService : ICandidateSkillSetService
    {
        private readonly ICandidateSkillSetRepository _candidateSkillSetRepository;

        public CandidateSkillSetService(ICandidateSkillSetRepository candidateSkillSetRepository)
        {
            _candidateSkillSetRepository = candidateSkillSetRepository;
        }

        public async Task<CandidateSkillSetResponse> GetCandidateSkillSetsAsync(CandidateSkillSetIdRequest candidateSkillSetRequest)
        {
            return new CandidateSkillSetResponse
            {
                CandidateSkillSet = await _candidateSkillSetRepository.GetCandidateSkillSetsAsync(candidateSkillSetRequest.CandidateSkillSetId)
            };
        }

        public async Task<SetCandidateSkillSetResponse> AddCandidateSkillSetsAsync(CandidateSkillSetRequest candidateSkillSetRequest)
        {
            return new SetCandidateSkillSetResponse
            {
                SuccessFlag = await _candidateSkillSetRepository.AddCandidateSkillSetsAsync(candidateSkillSetRequest.CandidateSkillSet)
            };
        }

        public async Task<SetCandidateSkillSetResponse> DeleteCandidateSkillSetsAsync(CandidateSkillSetIdRequest candidateSkillSetRequest)
        {
            return new SetCandidateSkillSetResponse
            {
                SuccessFlag = await _candidateSkillSetRepository.DeleteCandidateSkillSetsAsync(candidateSkillSetRequest.CandidateSkillSetId)
            };
        }
    }
}
