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
    public class EducationInformationController : ApiController
    {
        public readonly IEducationalIformationService _educationService;

        public EducationInformationController(IEducationalIformationService educationService)
        {
            _educationService = educationService;
        }

        public async Task<EducationalInforamtionResponse> Get(int id)
        {
            var education = await _educationService.GetEducationalInformationAsync(new EducationalInformationRequest { CandidateId=id});
            return education;
        }
    }
}