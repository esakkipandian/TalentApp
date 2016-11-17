using Prft.Talent.Domain.Talent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface IDocumentRepository : IRepository
    {
        Task<IEnumerable<Document>> GetDocumentsAsync();

        Task<int> DocumentAsync(Document document);

        Task<int> UpdateDocumentAsync(Document document);

        Task<int> DeleteDocumentAsync(Document document);
    }
}