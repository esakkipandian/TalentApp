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
    public class QualificationController : ApiController
    {      
        private readonly IQualificationService _qualificationService;
        private readonly IPrftLogger _logger;
        public QualificationController( IPrftLogger logger, IQualificationService qualificationServices)
        {
            _logger = logger;
            _qualificationService = qualificationServices;
        }
       
        public async Task<QualificationResponse> Get()
        {
            var qualification = await _qualificationService.GetQualificationAsync();
            return qualification;
        }

    }
}
