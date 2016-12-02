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
    public class BackOfficeInformationController:ApiController
    {
        private readonly IBackOfficeService _backofficeService;
        private readonly IPrftLogger _logger;
        public BackOfficeInformationController(IBackOfficeService backOfficeservices, IPrftLogger logger)
        {

            _backofficeService = backOfficeservices;
            _logger = logger;
        }

        public async Task<BackOfficeInformationResponse> Get(int id)
        {
            var BackOfficeInformation = await _backofficeService.GetBackOfficeAsync(id);
            //LogException();
            return BackOfficeInformation;
        }
    }
}