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
    public class CollegesController : ApiController
    {
         private readonly ICollegesServices _collegesService;
        private readonly IPrftLogger _logger;
        public CollegesController(ICollegesServices collegeservices, IPrftLogger logger)
        {

            _collegesService = collegeservices;
            _logger = logger;
           }
        public async Task<CollegesReponse> Get()
        {
            var Collges = await _collegesService.GetCollegesAsync();
            //LogException();
            return Collges;
        }
    }
}
