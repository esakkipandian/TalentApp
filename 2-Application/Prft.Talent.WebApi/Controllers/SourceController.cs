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
    public class SourceController : ApiController
    {
        private readonly ISourceService _sourceService;
        private readonly IPrftLogger _logger;
        public SourceController(ISourceService sourceservices, IPrftLogger logger)
        {

            _sourceService = sourceservices;
            _logger = logger;
        }
        public async Task<SourceResponse> Get()
        {
            var sources = await _sourceService.GetSourceAsync();
            //LogException();
            return sources;
        }
    }
}
