using Prft.Talent.Logger;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using System.Threading.Tasks;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class CandidatesController : ApiController
    {
        private readonly ICandidatesService _candidateService;
        private readonly IPrftLogger _logger;

        public CandidatesController(ICandidatesService candidateService, IPrftLogger logger)
        {
            _candidateService = candidateService;
            _logger = logger;
        }
        // GET api/<controller>
        public async Task<CandidatesResponse> GetCandidate()
        {
            var candidateInformation = await _candidateService.GetCandidatesAsync();
            //LogException();
            return candidateInformation;
        }


    }
}