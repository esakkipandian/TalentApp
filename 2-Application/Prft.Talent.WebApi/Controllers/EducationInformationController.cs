using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class EducationInformationController : ApiController
    {
        public readonly IEducationalIformationService _educationService;

        public EducationInformationController(IEducationalIformationService educationService)
        {
            _educationService = educationService;
        }

        [HttpGet]
        public async Task<EducationalInforamtionResponse> Get(int id)
        {
            var education = await _educationService.GetEducationalInformationAsync(new EducationalInformationRequest { CandidateId = id });
            return education;
        }
        [HttpPost]
        [Route("api/EducationInformation/Post")]
        public async Task<int> Post(EducationalInformation educationInformation)
        {
            var successFlag = await _educationService.SaveEducationalInformationAsync(educationInformation);
            return successFlag.SuccessFlag;
            //_educationService.SaveEducationalInformationAsync(educationInformation);
        }

        [HttpPut]
        [Route("api/EducationInformation/Update")]
        public async Task<int> Update(EducationalInformation educationInformation)
        {
            var successFlag = await _educationService.UpdateEducationalInformationAsync(educationInformation);
            return successFlag.SuccessFlag;
            //  _educationService.UpdateEducationalInformationAsync(educationInformation);
        }
        [HttpPut]
        [Route("api/EducationInformation/Delete")]
        public async Task<int> Delete(EducationalInformation EducationalInformation)
        {
            var successFlag = await _educationService.DeleteEducationalInformationAsync(EducationalInformation);
            return successFlag.SuccessFlag;
        }

    }
}