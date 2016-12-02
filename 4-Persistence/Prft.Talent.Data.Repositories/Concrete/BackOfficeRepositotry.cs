using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Prft.Talent.Logger;
using AutoMapper;
using Prft.Talent.Domain.Talent;
using AutoMapper.QueryableExtensions;
using Prft.Talent.Data.Repositories.Abstract;



namespace Prft.Talent.Data.Repositories.Concrete
{
   public  class BackOfficeRepositotry:Repository,IBackOfficeRepository
    {
        public BackOfficeRepositotry(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }

        public async Task<BackOfficeInformation> GetBackOfficeInformation(int Id)
        {

            return await Task.Run(() => GetBackOfficeInformation(Id));
                
                   }

        public BackOfficeInformation GetBackOfficeInformationRepository(int id)
        {
            return new BackOfficeInformation { CandidateId = 1, CTC = 100000, VaraiblePay = 7500, LastIncrementedDate = new DateTime(), IsForm16Verified = true };
            
        }
    }
}
