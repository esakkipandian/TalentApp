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
    public class SourceService : ISourceService
    {
        private readonly ISourceRepository _sourceRepository;
        private readonly IPrftLogger _logger;
        public SourceService(ISourceRepository sourceRepository, IPrftLogger logger)
        {

            _sourceRepository = sourceRepository;
            _logger = logger;
        }


        public async Task<SourceResponse> GetSourceAsync()
        {

            return new SourceResponse
            {
                Source = await _sourceRepository.GetSourceAsync()
            };

        }
    }
}
