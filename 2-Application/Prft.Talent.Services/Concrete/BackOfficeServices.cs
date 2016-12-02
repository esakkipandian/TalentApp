using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Logger;
using Prft.Talent.Services.Abstract;

namespace Prft.Talent.Services.Concrete
{
   public class BackOfficeServices:IBackOfficeService
    {
        private readonly IBackOfficeRepository _backOfficeRepository;
        private readonly IPrftLogger _logger;
        public BackOfficeServices(IBackOfficeRepository backOfficeRepository, IPrftLogger logger)
        {

            _backOfficeRepository = backOfficeRepository;
            _logger = logger;
        }
        public async Task<BackOfficeInformationResponse> GetBackOfficeAsync(int id)
        {
            return new BackOfficeInformationResponse
            {
                BackOfficeInformation=await _backOfficeRepository.GetBackOfficeInformation(id)
            };
        }
    }
  
}
