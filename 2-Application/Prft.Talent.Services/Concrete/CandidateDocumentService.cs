using Prft.Talent.Services.Abstract;
using System;
using System.Threading.Tasks;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Domain.Talent;
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

        public Task<CandidateDocumentResponse> GetDocumentAsync()
        {
            throw new NotImplementedException();
        }
    }
}
