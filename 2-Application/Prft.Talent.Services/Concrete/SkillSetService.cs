using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Services.Api;

namespace Prft.Talent.Services.Concrete
{
    public class SkillSetService : ISkillSetService
    {
        private readonly ISkillSetRepository _SkillSetRepository;

        public SkillSetService(ISkillSetRepository skillSetRepository)
        {
            _SkillSetRepository = skillSetRepository;
        }

        public async Task<SkillSetResponse> GetSkillSetsAsync()
        {
            return new SkillSetResponse
            {
                SkillSets = await _SkillSetRepository.GetSkillSetsAsync()
            };
        }
    }
}
