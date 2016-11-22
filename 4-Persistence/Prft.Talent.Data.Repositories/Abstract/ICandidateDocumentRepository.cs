using Prft.Talent.Domain.Talent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface ICandidateDocumentRepository : IRepository
    {
        Task<IEnumerable<CandidateDocument>> GetCandidateDocumentsAsync(int candidateId);
        Task<int> AddCandidateDocumentsAsync(CandidateDocument candiateDocument);
    }
}
