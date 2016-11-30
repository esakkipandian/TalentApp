using Prft.Talent.Services.Abstract;
using System.Threading.Tasks;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Api;

namespace Prft.Talent.Services.Concrete
{
    public class EmployerDetailsService : IEmployerDetailsService
    {
        private readonly IEmployerDetailsRepository _employeeRepository;

        public EmployerDetailsService(IEmployerDetailsRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployerDetailsResponse> GetEmployeesAsync()
        {
            return new EmployerDetailsResponse
            {
                Entity = await _employeeRepository.GetEmployeesAsync()
            };
        }
    }
}
