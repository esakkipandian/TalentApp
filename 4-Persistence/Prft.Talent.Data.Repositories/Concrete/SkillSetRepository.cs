using AutoMapper;
using Prft.Talent.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Logger;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class SkillSetRepository : Repository, ISkillSetRepository
    {
        public SkillSetRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }

        public async Task<IEnumerable<SkillSet>> GetSkillSetsAsync()
        {
            return await DatabaseContext.skills
                .ProjectTo<SkillSet>(Mapper.ConfigurationProvider).ToListAsync();
        }
    }
}