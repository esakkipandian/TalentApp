using Prft.Talent.Services.Abstract;
using System.Threading.Tasks;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Api;
using System;

namespace Prft.Talent.Services.Concrete
{
    public class EmployerDetailsService : IEmployerDetailsService
    {
        private readonly IEmployerDetailsRepository _employeeRepository;

        public EmployerDetailsService(IEmployerDetailsRepository employerRepository)
        {
            _employeeRepository = employerRepository;
        }

        public Task<SetEmployerDetailsResponse> AddEmployerInfoAsync(EmployerDetailsRequest employerDetailRequest)
        {
            throw new NotImplementedException();
        }

        public Task<SetEmployerDetailsResponse> DeleteEmployerInfoAsync(EmployerDetailsIdRequest employerDetailByIdRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployerDetailsResponse> GetEmployersAsync()
        {
            return new EmployerDetailsResponse
            {
                EmployerDetails = await _employeeRepository.GetEmployersAsync()
            };
        }

        public Task<EmployerDetailsResponse> GetEmployersAsync(EmployerDetailsIdRequest employerDetailByIdRequest)
        {
            throw new NotImplementedException();
        }

        public Task<SetEmployerDetailsResponse> UpdateEmployerInfoAsync(EmployerDetailsRequest employerDetailRequest)
        {
            throw new NotImplementedException();
        }
    }
}
