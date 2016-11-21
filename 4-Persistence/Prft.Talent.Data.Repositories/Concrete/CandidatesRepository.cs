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
using Prft.Talent.Data.Entities;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class CandidatesRepository : Repository, ICandidatesRepository
    {
        public CandidatesRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }

        public async Task<IEnumerable<Candidates>> GetCandidateInformationAsync()
        {
            return await DatabaseContext.candidates
                .Where(x => x.IsActive == true)
                .ProjectTo<Candidates>(Mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<int> AddCandidateDocumentAsync(CandiateDocument candiateDocument)
        {
            var objectToAdd = Mapper.Map<candidatedocument>(candiateDocument);
            objectToAdd.IsActive = true;
            DatabaseContext.candidatedocuments.Add(objectToAdd);
            return await DatabaseContext.SaveChangesAsync();
        }
        
    }
}
