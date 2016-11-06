using Prft.Talent.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data.Entities;
using Prft.Talent.Data;
using Prft.Talent.Data.Repositories.Abstract;

namespace Prft.Talent.Services.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<employee> GetEmployees()
        {
            //PrftTalentDatabaseContext context = new PrftTalentDatabaseContext();

            return _employeeRepository.GetEmployees().ToList();
        }
    }
}
