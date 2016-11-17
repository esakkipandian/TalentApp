using AutoMapper;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public abstract class Repository : IRepository
    {
        protected readonly PrftDatabaseContext DatabaseContext;
        protected readonly IMapper Mapper;
        protected readonly IPrftLogger Logger;

        public Repository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger)
        {
            DatabaseContext = dbContext;
            Mapper = mapper;
            Logger = logger;
            DatabaseContext.Database.Log = logger.Log;
        }
    }
}
