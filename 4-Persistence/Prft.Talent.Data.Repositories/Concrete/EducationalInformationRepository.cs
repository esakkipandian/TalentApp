using Prft.Talent.Data.Repositories.Abstract;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;
using Prft.Talent.Logger;
using System.Collections.Generic;
using Prft.Talent.Data.Entities;

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
                        .Where(x => x.CandidateId == candidateId )
                        .ProjectTo<EducationalInformation>(Mapper.ConfigurationProvider)
                        .FirstOrDefault());
        }
        public async Task<int> SaveEducationalInformationAsync(EducationalInformation EducationalInformation)
        {
            var objectToAdd = Mapper.Map<Entities.candidateeducation>(EducationalInformation);
            objectToAdd.IsActive = true;
            DatabaseContext.candidateeducations.Add(objectToAdd);
            return await DatabaseContext.SaveChangesAsync();
        }
        public async Task<int> UpdateEducationalInformationAsync(EducationalInformation EducationalInformation)
        {
            var objectToUpdate = Mapper.Map<Entities.candidateeducation>(EducationalInformation);
            objectToUpdate.IsActive = true;
            DatabaseContext.Entry(objectToUpdate).State = EntityState.Modified;
            return await DatabaseContext.SaveChangesAsync();
        }
    }
}
