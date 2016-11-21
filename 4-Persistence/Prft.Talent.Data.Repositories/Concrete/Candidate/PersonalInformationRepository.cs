using Prft.Talent.Data.Repositories.Abstract.Candidate;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent.Candidate;
using AutoMapper.QueryableExtensions;
using Prft.Talent.Logger;
using System.Data.Entity;

namespace Prft.Talent.Data.Repositories.Concrete.Candidate
{
    public class PersonalInformationRepository : Repository, IPersonalInformationRepository
    {
        public PersonalInformationRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger)
            : base(dbContext, mapper, logger)
        {
        }

        public async Task<PersonalInformation> GetCandidatePersonalInformationAsync(int candidateId)
        {
            return await Task.FromResult(DatabaseContext.candidates
                        .Where(x => x.PK == candidateId)
                        .ProjectTo<PersonalInformation>(Mapper.ConfigurationProvider)
                        .FirstOrDefault());
        }

        public async Task<int> SetCandidatePersonalInformationAsync(PersonalInformation personalInformation)
        {
            var objectToAdd = Mapper.Map<Entities.candidate>(personalInformation);
            objectToAdd.IsActive = true;
            DatabaseContext.candidates.Add(objectToAdd);
            await DatabaseContext.SaveChangesAsync();
            return objectToAdd.PK;
        }

        public async Task<int> UpdateCandidatePersonalInformationAsync(PersonalInformation personalInformation)
        {
            //<<<<<<< Updated upstream
            //            var objectToAdd = Mapper.Map<Entities.candidate>(personalInformation);
            //            var candidate = DatabaseContext.candidates.Where(x => x.PK == personalInformation.CandidateId).SingleOrDefault();
            //            if (candidate != null)
            //            {
            //                candidate = objectToAdd;
            //                return await DatabaseContext.SaveChangesAsync();
            //            }
            //            return candidate.PK;
            //=======
            var objectToUpdate = Mapper.Map<Entities.candidate>(personalInformation);
            objectToUpdate.IsActive = true;
            DatabaseContext.Entry(objectToUpdate).State = EntityState.Modified;
            var successFlag = await DatabaseContext.SaveChangesAsync();
            if (successFlag > 0)
            {
                return objectToUpdate.PK;
            }
            return 0;
        }

        public async Task<int> DeleteCandidatePersonalInformationAsync(int candidateId)
        {
            var candidate = DatabaseContext.candidates.Where(x => x.PK == candidateId).SingleOrDefault();
            if (candidate != null)
            {
                candidate.IsActive = false;
                candidate.IsExperienced = true;
                return await DatabaseContext.SaveChangesAsync();
            }
            return 0;
        }
    }
}
