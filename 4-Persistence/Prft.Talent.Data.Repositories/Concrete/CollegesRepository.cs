using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Prft.Talent.Data.Repositories.Abstract;
using AutoMapper;
using AutoMapper.QueryableExtensions;

using Prft.Talent.Logger;

namespace Prft.Talent.Data.Repositories.Concrete
{
   public class CollegesRepository:Repository,ICollegesRepository
    {
        public CollegesRepository(PrftDatabaseContext dbContext, IMapper mapper,IPrftLogger logger) : base(dbContext, mapper,logger) { }

        public async Task<IEnumerable<Colleges>> GetCollegesAsync(int qId)
        {
            if (qId == 4)
            {
                return new List<Colleges>
            {
                new Colleges { CollegeCode="GILL" ,CollegeName="Gill Adharsh",Id="11"},
                new Colleges { CollegeCode="SVMS" ,CollegeName="Shrine Velankani",Id="12"},
                new Colleges { CollegeCode="SBMS" ,CollegeName="Saint Bedes",Id="13"}
            };
            }
            else
            {
                return await DatabaseContext.colleges
                    .ProjectTo<Colleges>(Mapper.ConfigurationProvider).ToListAsync();

            }
        }

    }
}
