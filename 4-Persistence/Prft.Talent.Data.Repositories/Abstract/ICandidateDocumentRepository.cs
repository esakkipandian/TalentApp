using Prft.Talent.Domain.Talent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface ICandidateDocumentRepository : IRepository
    {
        Task<IEnumerable<CandidateDocument>> GetCandidateDocumentsAsync();
        Task<int> AddCandidateDocumentsAsync(CandidateDocument candiateDocument);
    }
}
