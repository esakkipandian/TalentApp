using Prft.Talent.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;

namespace Prft.Talent.Services.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResponse> GetEmployeesAsync()
        {
            return new EmployeeResponse
            {
                Entity = await _employeeRepository.GetEmployeesAsync()
            };
        }
    }
}
