using Prft.Talent.Domain.Talent.Candidate;
using Prft.Talent.Logger;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Abstract.Candidate;
using Prft.Talent.Services.Api;
using Prft.Talent.Services.Api.Candidate;
using System.Threading.Tasks;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class CandidatesController : ApiController
    {
        private readonly ICandidatesService _candidateService;
        private readonly IPrftLogger _logger;
        private readonly IPersonalInformationService _personalInformationService;


        public CandidatesController(ICandidatesService candidateService, IPrftLogger logger, IPersonalInformationService personalInformationService)
        {
            _candidateService = candidateService;
            _logger = logger;
            _personalInformationService = personalInformationService;
        }
        // GET api/<controller>
        public async Task<CandidatesResponse> GetCandidate()
        {
            var candidateInformation = await _candidateService.GetCandidatesAsync();
            //LogException();
            return candidateInformation;
        }

        public async Task<PersonalInformationResponse> GetCandidatePersonalInformation(int id)
        {
            var personalInformation = await _personalInformationService.GetCandidatePersonalInformationAsync(
                new GetPersonalInformationRequest
                {
                    CandidateId = id
                });
            return personalInformation;
        }


        [HttpGet]
        [Route("api/PersonalInformation/AddPersonalInformation")]
        public async Task<int> AddPersonalInformation(PersonalInformation personalInformation)
        {
            var successFlag = await _personalInformationService.SetCandidatePersonalInformationAsync(
                new PersonalInformationRequest
                {
                    CandidatePersonalInformation = personalInformation
                });
            return successFlag.SuccessFlag;
        }

    }
}