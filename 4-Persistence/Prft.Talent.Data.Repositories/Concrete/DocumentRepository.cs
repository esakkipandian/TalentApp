using Prft.Talent.Data.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prft.Talent.Data.Entities;
using AutoMapper;
using Prft.Talent.Domain.Talent;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class DocumentRepository : Repository, IDocumentRepository
    {
        public DocumentRepository(PrftDatabaseContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public async Task<IEnumerable<Document>> GetDocumentsAsync()
        { }
        public async Task<int> DocumentAsync(Document document)
        {
            var objectToAdd = Mapper.Map<Document>(document);
            objectToAdd.IsActive = true;
            //DatabaseContext.documents.Add(objectToAdd);
            return await DatabaseContext.SaveChangesAsync();
        }

        public async Task<int> DeleteDocumentAsync(Document document)
        {
            var objectToDelete = Mapper.Map<Document>(document);
            objectToDelete.IsActive = false;
            //DatabaseContext.Entry(objectToDelete).State = EntityState.Modified;
            return await DatabaseContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Document>> GetDocumentsAsync()
        {
            return await DatabaseContext.documents
                        .Where(x=>x.IsActive == true)
                        .ProjectTo<Document>(Mapper.ConfigurationProvider)
                        .ToListAsync();
        }

        public async Task<int> UpdateDocumentAsync(Document document)
        {
            var objectToUpdate = Mapper.Map<Document>(document);
            objectToUpdate.IsActive = true;
            DatabaseContext.Entry(objectToUpdate).State = EntityState.Modified;
            return await DatabaseContext.SaveChangesAsync();
        }
    }
}
