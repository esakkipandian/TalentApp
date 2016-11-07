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

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class EmployeeRepository : Repository, IEmployeeRepository
    {
        public EmployeeRepository(PrftTalentDatabaseContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await DatabaseContext.employees.ProjectTo<Employee>(Mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
