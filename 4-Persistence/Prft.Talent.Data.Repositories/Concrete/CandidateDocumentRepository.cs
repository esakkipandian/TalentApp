﻿using Prft.Talent.Data.Repositories.Abstract;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Logger;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;
using Prft.Talent.Data.Entities;
using System;
using System.Linq;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class CandidateDocumentRepository : Repository, ICandidateDocumentRepository
    {
        public CandidateDocumentRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }

        public async Task<IEnumerable<CandidateDocument>> GetCandidateDocumentsAsync(int candidateId)
        {
            return await DatabaseContext.candidatedocuments
                       .Where(x => x.IsActive == true && x.CandidateId == candidateId)
                       .ProjectTo<CandidateDocument>(Mapper.ConfigurationProvider).ToListAsync();
            
        }

        public async Task<int> AddCandidateDocumentsAsync(CandidateDocument candiateDocument)
        {
            var objectToAdd = Mapper.Map<candidatedocument>(candiateDocument);
            objectToAdd.IsActive = true;
            DatabaseContext.candidatedocuments.Add(objectToAdd);
            var result = await DatabaseContext.SaveChangesAsync();
            return objectToAdd.PK;
        }
    }
}
