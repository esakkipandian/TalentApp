using Prft.Talent.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data.Entities;
using AutoMapper;
using Prft.Talent.Domain.Talent;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;
using Prft.Talent.Logger;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class EmployerDetailsRepository : Repository, IEmployerDetailsRepository
    {
        public EmployerDetailsRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }

        public async Task<IEnumerable<EmployerDetails>> GetEmployeesAsync()
        {
            return new List<EmployerDetails>();
            //return await DatabaseContext.employees.ProjectTo<Employee>(Mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
