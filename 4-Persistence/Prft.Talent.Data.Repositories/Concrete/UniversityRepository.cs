using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Prft.Talent.Data.Repositories.Abstract;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Logger;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class UniversityRepository : Repository, IUniversityRepository
 {
        public UniversityRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper,logger) { }

       

        public async Task<IEnumerable<University>> GetUniversityAsync()
        {
            return await DatabaseContext.universities
                .ProjectTo<University>(Mapper.ConfigurationProvider).ToListAsync();


        }

    }
}
