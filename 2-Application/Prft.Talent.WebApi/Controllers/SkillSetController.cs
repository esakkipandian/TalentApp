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
    public class SkillSetController : ApiController
    {
        public readonly ISkillSetService _skillSetService;

        public SkillSetController(ISkillSetService skillSetService)
        {
            _skillSetService = skillSetService;
        }

        public async Task<SkillSetResponse> Get()
        {
            var candidateskillsets = await _skillSetService.GetSkillSetsAsync();
            return candidateskillsets;
        }
    }
}