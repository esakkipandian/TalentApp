using AutoMapper;
using Prft.Talent.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public abstract class Repository : IRepository
    {
        protected readonly PrftTalentDatabaseContext DatabaseContext;
        protected readonly IMapper Mapper;

        public Repository(PrftTalentDatabaseContext dbContext, IMapper mapper)
        {
            DatabaseContext = dbContext;
            Mapper = mapper;
        }
    }
}
