using Prft.Talent.Logger;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Prft.Talent.WebApi.Controllers
{
    public class CandidatesController : ApiController
    {
        private readonly ICandidateService _candidateService;
        private readonly IPrftLogger _logger;

        public CandidatesController(ICandidateService candidateService, IPrftLogger logger)
        {
            _candidateService = candidateService;
            _logger = logger;
        }
        // GET api/<controller>
        public async Task<CandidateResponse> GetCandidate()
        {
            var candidateInformation = await _candidateService.GetCandidatesAsync();
            //LogException();
            return candidateInformation;
        }


    }
}