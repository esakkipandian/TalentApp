using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Services.Api;
using Prft.Talent.Logger;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Abstract;

namespace Prft.Talent.Services.Concrete
{
    public class QualificationService : IQualificationService
    {
        private readonly IQualificationRepository _qualificationRepository;
        private readonly IPrftLogger _logger;
        public QualificationService(IQualificationRepository qualificationRepository, IPrftLogger logger)
        {

            _qualificationRepository = qualificationRepository;
            _logger = logger;
        }


        public async Task<QualificationResponse> GetQualificationAsync()
        {

            return new QualificationResponse
            {
                Qualification = await _qualificationRepository.GetQualificationAsync()
            };

        }
    }
}
