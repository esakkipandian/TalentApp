using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Logger;
using Prft.Talent.Services;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Services.Concrete;
using System.Threading.Tasks;

namespace Prft.Talent.WebApi.Controllers
{
    public class UniversityController : ApiController
    {
        private readonly IUniversityServices _universityService;
        private readonly IPrftLogger _logger;
        public UniversityController(IUniversityServices collegeservices, IPrftLogger logger)
        {

            _universityService = collegeservices;
            _logger = logger;
        }
        public async Task<UniversityResponse> Get(int id)
        {
            var University = await _universityService.GetUniversityAsync(id);
            //LogException();
            return University;
        }
    }
}
