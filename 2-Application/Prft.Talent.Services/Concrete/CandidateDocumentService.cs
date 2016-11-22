using Prft.Talent.Services.Abstract;
using System.Threading.Tasks;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Domain.Talent;
using System.Collections.Generic;
using Prft.Talent.Services.Api;

namespace Prft.Talent.Services.Concrete
{
    public class CandidateDocumentService : ICandidateDocumentService
    {
        private readonly ICandidateDocumentRepository _candidateDocumentRepository;

        public CandidateDocumentService(ICandidateDocumentRepository candidateDocumentRepository)
        {
            _candidateDocumentRepository = candidateDocumentRepository;
        }

       
        public async Task<int> AddDocumentAsync(CandidateDocument candiateDocument)
        {
            return await _candidateDocumentRepository.AddCandidateDocumentsAsync(candiateDocument);
        }
        
        public async Task<CandidateDocumentResponse> GetCandidateDocumentsAsync(int candidateId)
        {
            return new CandidateDocumentResponse
            {
                Entity = await _candidateDocumentRepository.GetCandidateDocumentsAsync(candidateId)
            };
        }
    }
}
