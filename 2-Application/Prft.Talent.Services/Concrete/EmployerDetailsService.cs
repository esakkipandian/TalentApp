using Prft.Talent.Services.Abstract;
using System.Threading.Tasks;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Api;

namespace Prft.Talent.Services.Concrete
{
    public class EmployerDetailsService : IEmployerDetailsService
    {
        private readonly IEmployerDetailsRepository _employeeRepository;

        public EmployerDetailsService(IEmployerDetailsRepository employerRepository)
        {
            _employeeRepository = employerRepository;
        }

        public async Task<EmployerDetailsResponse> GetEmployersAsync()
        {
            return new EmployerDetailsResponse
            {
                EmployerDetails = await _employeeRepository.GetEmployersAsync()
            };
        }
    }
}
