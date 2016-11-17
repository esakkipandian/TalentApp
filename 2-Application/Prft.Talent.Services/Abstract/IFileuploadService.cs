using Prft.Talent.Services.Api;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract
{
    public interface IFileuploadService : IApi
    {
        Task<FileuploadResponse> GetDocumentAsync();
    }
}
