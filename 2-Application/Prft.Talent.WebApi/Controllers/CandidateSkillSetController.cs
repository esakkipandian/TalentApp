﻿using Prft.Talent.Domain.Talent.Candidate;
using Prft.Talent.Logger;
using Prft.Talent.Services.Abstract.Candidate;
using Prft.Talent.Services.Api.Candidate;
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
        private readonly IPrftLogger _logger;
        private readonly ICandidateSkillSetService _candidateSkillSetService;


        public CandidateSkillSetController(IPrftLogger logger, ICandidateSkillSetService candidateSkillSetService)
        {
            _logger = logger;
            _candidateSkillSetService = candidateSkillSetService;
        }

        public async Task<CandidateSkillSet> GetCandidateSkillSet(int id)
        {
            var candidateSkillSets = await _candidateSkillSetService.GetCandidateSkillSetsAsync(
                new CandidateSkillSetIdRequest
                {
                    CandidateId = id
                });
            return candidateSkillSets.CandidateSkillSet;
        }

        [HttpPost]
        [Route("api/Candidates/AddCandidateSkillSets")]
        public async Task<int> AddCandidateSkillSet(CandidateSkillSet candidateSkillSet)
        {
            var successFlag = await _candidateSkillSetService.AddCandidateSkillSetsAsync(
                new CandidateSkillSetRequest
                {
                    CandidateSkillSet = candidateSkillSet
                });
            return successFlag.SuccessFlag;
        }

        public async Task<int> DeleteCandidateSkillSet(int id)
        {
            var successFlag = await _candidateSkillSetService.DeleteCandidateSkillSetsAsync(
                new CandidateSkillSetIdRequest
                {
                    CandidateId = id
                });
            return successFlag.SuccessFlag;
        }
    }
}