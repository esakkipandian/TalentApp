using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Services.Abstract;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Concrete
{
    public class CandidatesService: ICandidatesService
    {
        private readonly ICandidatesRepository _candidateRepository;

        public CandidatesService(ICandidatesRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        public async Task<CandidatesResponse> GetCandidatesAsync()
        {
            return new CandidatesResponse
            { 
                Entity = await _candidateRepository.GetCandidateInformationAsync()
            };
        }

    }
}
