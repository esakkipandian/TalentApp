using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Logger;
using Prft.Talent.Domain.Talent;

namespace Prft.Talent.Services.Concrete
{
  public  class UniversityServices:IUniversityServices
    {
        private readonly IUniversityRepository _UniversityRepository;
        private readonly IPrftLogger _logger;
        public UniversityServices(IUniversityRepository courseRepository, IPrftLogger logger)
        {

            _UniversityRepository = courseRepository;
            _logger = logger;
        }


        public async Task<UniversityResponse> GetUniversityAsync(int qId)
        {

            return new UniversityResponse
            {
                Universities = await _UniversityRepository.GetUniversityAsync(qId)
            };

        }

     
    }
}
