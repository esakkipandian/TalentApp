using Prft.Talent.Data.Repositories.Abstract.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Prft.Talent.Logger;
using Prft.Talent.Domain.Talent.Candidate;
using AutoMapper.QueryableExtensions;

namespace Prft.Talent.Data.Repositories.Concrete.Candidate
{
    public class CandidateSkillSetRepository : Repository, ICandidateSkillSetRepository
    {
        public CandidateSkillSetRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger)
        {
        }

        public async Task<CandidateSkillSet> GetCandidateSkillSetsAsync(int candidateId)
        {
            return await Task.FromResult(DatabaseContext.candidateskills
                        .Where(x => x.PK == candidateId)
                        .ProjectTo<CandidateSkillSet>(Mapper.ConfigurationProvider)
                        .FirstOrDefault());
        }

        public async Task<int> AddCandidateSkillSetsAsync(CandidateSkillSet candidateSkillSet)
        {
            var objectToAdd = Mapper.Map<Entities.candidateskill>(candidateSkillSet);
            objectToAdd.IsActive = true;
            DatabaseContext.candidateskills.Add(objectToAdd);
            var result = await DatabaseContext.SaveChangesAsync();
            return objectToAdd.PK;
        }

        public async Task<int> DeleteCandidateSkillSetsAsync(int candidateSkillSetId)
        {
            var candidate = DatabaseContext.candidateskills.Where(x => x.PK == candidateSkillSetId).SingleOrDefault();
            if (candidate != null)
            {
                candidate.IsActive = false;
                return await DatabaseContext.SaveChangesAsync();
            }
            return 0;
        }
    }
}
