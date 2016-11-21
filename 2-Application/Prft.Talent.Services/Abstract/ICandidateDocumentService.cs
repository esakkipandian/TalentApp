using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract
{
    public interface ICandidateDocumentService : IApi
    {
        Task<CandidateDocumentResponse> GetDocumentAsync();
        Task<int> AddDocumentAsync(CandidateDocument candiateDocument);
    }
}
