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
using Prft.Talent.Domain.Talent;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class SourceRepository : Repository, ISourceRepository
    {


        public SourceRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }
        public async Task<IEnumerable<Source>> GetSourceAsync()
        {

            return await Task.Run(() => GetSourceDetails());
        }

        public IEnumerable<Source> GetSourceDetails()
        {

            return new List<Source>
            {
                new Source { SourceCode="Ref" ,SourceName="Referrence",Id=1},
                new Source { SourceCode="MST" ,SourceName="Monster",Id=2},
                new Source { SourceCode="NKR" ,SourceName="Naukri",Id=3},
                new Source { SourceCode="WLK" ,SourceName="Walkin",Id=4},
            };
        }


    }
}




