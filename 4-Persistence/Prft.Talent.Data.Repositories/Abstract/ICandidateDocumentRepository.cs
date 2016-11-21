using Prft.Talent.Domain.Talent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface ICandidateDocumentRepository : IRepository
    {
        Task<IEnumerable<CandiateDocument>> GetCandidateDocumentsAsync();
        Task<int> AddCandidateDocumentsAsync(CandiateDocument candiateDocument);
    }
}
