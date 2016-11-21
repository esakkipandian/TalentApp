using Prft.Talent.Data.Repositories.Abstract;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;
using AutoMapper.QueryableExtensions;
using Prft.Talent.Logger;
using System.Collections.Generic;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class EducationalInformationRepository : Repository, IEducationalInformationRepository
    {
        public EducationalInformationRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger)
            : base(dbContext, mapper, logger)
        {
        }
        public async Task<EducationalInformation> GetEducationalInformationAsync(int candidateId)
        {
            return await Task.FromResult(DatabaseContext.candidateeducations
                        .Where(x => x.PK == candidateId)
                        .ProjectTo<EducationalInformation>(Mapper.ConfigurationProvider)
                        .FirstOrDefault());
        }

    }
}
