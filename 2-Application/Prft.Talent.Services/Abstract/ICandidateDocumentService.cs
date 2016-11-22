using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract
{
    public interface ICandidateDocumentService : IApi
    {
        Task<CandidateDocumentResponse> GetCandidateDocumentsAsync(int candidateId);
        Task<int> AddDocumentAsync(CandidateDocument candiateDocument);
    }
}
