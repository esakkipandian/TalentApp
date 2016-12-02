using Prft.Talent.Domain.Talent;
using Prft.Talent.Logger;
using Prft.Talent.Services;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class EmployerDetailsController : ApiController
    {
        private readonly IPrftLogger _logger;        
        private readonly IEmployerDetailsService _employerService;

        public EmployerDetailsController(IPrftLogger logger, IEmployerDetailsService employeeService)
        {
            _logger = logger;
            _employerService = employeeService;
        }

        public async Task<IEnumerable<EmployerDetails>> GetEmployerDetails(int id)
        {
            var employerDetails = await _employerService.GetEmployersAsync(
                new EmployerDetailsIdRequest
                {
                    CandidateEmployerId = id
                });
            return employerDetails.EmployerDetails;
        }

        [HttpPost]
        [Route("api/EmployerDetails/AddEmployerDetails")]
        public async Task<int> AddEmployerDetails(EmployerDetails employerDetail)
        {
            var successFlag = await _employerService.AddEmployerInfoAsync(
                new EmployerDetailsRequest
                {
                    EmployerDetails = employerDetail
                });
            return successFlag.Successflag;
        }

        [HttpPut]
        [Route("api/EmployerDetails/DeleteEmployerDetail")]
        public async Task<int> DeleteEmployerDetail(EmployerDetails employerDetail)
        {
            var successFlag = await _employerService.DeleteEmployerInfoAsync(
                new EmployerDetailsIdRequest
                {
                    CandidateEmployerId = employerDetail.PK
                });
            return successFlag.Successflag;
        }

        [HttpPut]
        [Route("api/EmployerDetails/UpdateEmployerDetails")]
        public async Task<int> UpdateEmployerDetails(EmployerDetails employerDetail)
        {
            var successFlag = await _employerService.UpdateEmployerInfoAsync(
                new EmployerDetailsRequest
                {
                    EmployerDetails = employerDetail
                });
            return successFlag.Successflag;
        }
    }
}