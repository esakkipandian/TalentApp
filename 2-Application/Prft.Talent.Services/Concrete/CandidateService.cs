using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Concrete
{
    public class CandidateService
    {
        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<CandidateResponse> GetCandidatesAsync()
        {
            return new CandidateResponse
            { 
                Entity = await _candidateRepository.GetCandidateInformationAsync()
            };
        }

    }
}
