using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Services.Api;

namespace Prft.Talent.Services.Concrete
{
    public class CandidateSkillSetService : ICandidateSkillSetService
    {
        private readonly ICandidateSkillSetRepository _candidateSkillSetRepository;

        public CandidateSkillSetService(ICandidateSkillSetRepository candidateSkillSetRepository)
        {
            _candidateSkillSetRepository = candidateSkillSetRepository;
        }

        public async Task<CandidateSkillSetResponse> GetCandidateSkillSetAsync(CandidateSkillSetRequest CandidateSkillSetId)
        {
            var result = await _candidateSkillSetRepository.GetCandidateSkillSetAsync(CandidateSkillSetId.CandidateSkillSetId);
            return new Api.CandidateSkillSetResponse
            {
                CandidateSkillSets = result
            };
        }

        public async Task<CandidateSkillSetResponse> GetCandidateSkillSetsAsync()
        {
            return new CandidateSkillSetResponse
            {
                CandidateSkillSets = await _candidateSkillSetRepository.GetCandidateSkillSetsAsync()
            };
        }
    }
}
