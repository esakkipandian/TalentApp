﻿using Prft.Talent.Data.Repositories.Abstract.Candidate;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent.Candidate;
using AutoMapper.QueryableExtensions;
using Prft.Talent.Logger;

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
            objectToAdd.PK = personalInformation.CandidateId;
            DatabaseContext.candidates.Add(objectToAdd);
            return await DatabaseContext.SaveChangesAsync();
        }
    }
}
