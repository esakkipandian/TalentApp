using Prft.Talent.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data.Entities;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class EmployeeRepository : Repository, IEmployeeRepository
    {
        public EmployeeRepository(PrftTalentDatabaseContext dbContext) : base(dbContext) { }

        public IQueryable<employee> GetEmployees()
        {
            return DatabaseContext.employees;
        }
    }
}
