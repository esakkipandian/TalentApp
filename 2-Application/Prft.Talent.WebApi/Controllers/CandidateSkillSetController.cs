using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class CandidateSkillSetController : ApiController
    {
        public readonly ICandidateSkillSetService _candidateSkillSetService;

        public CandidateSkillSetController(ICandidateSkillSetService candidateSkillSetService)
        {
            _candidateSkillSetService = candidateSkillSetService;
        }

        public async Task<CandidateSkillSetResponse> Get()
        {
            var candidateskillsets = await _candidateSkillSetService.GetCandidateSkillSetsAsync();
            return candidateskillsets;
        }

        public async Task<CandidateSkillSetResponse> Get(int id)
        {
            var candidateskillsets = await _candidateSkillSetService.GetCandidateSkillSetAsync(new CandidateSkillSetRequest { CandidateSkillSetId = id });
            return candidateskillsets;
        }
    }
}