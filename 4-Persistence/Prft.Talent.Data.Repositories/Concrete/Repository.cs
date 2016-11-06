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

        //public Repository(RepositoryDependencies dependencies)
        //{
        //    DatabaseContext = dependencies.DatabaseContext;
        //}
        public Repository(PrftTalentDatabaseContext dbContext)
        {
            DatabaseContext = dbContext;
        }
    }
}
