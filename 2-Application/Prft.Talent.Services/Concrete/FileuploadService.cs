using Prft.Talent.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;

namespace Prft.Talent.Services.Concrete
{
    public class FileuploadService : IFileuploadService
    {
        private readonly ICandidateDocumentRepository _documentFileRepository;

        public FileuploadService(ICandidateDocumentRepository fileDocumentRepository)
        {
            _documentFileRepository = fileDocumentRepository;
        }

        public Task<FileuploadResponse> GetDocumentAsync()
        {
            throw new NotImplementedException();
        }

        //public async Task<int> AddDocumentFileAsync(FileDocument documentFile)
        //{
        //    return await _documentFileRepository.AddDocumentFileAsync(documentFile);
        //}

        //public async Task<bool> DeleteAddressTypeAsync(int pk)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<AddressTypeResponse> GetAddressTypesAsync()
        //{
        //    return new AddressTypeResponse
        //    {
        //        Entity = await _documentFileRepository.GetAddressTypesAsync()
        //    };
        //}

        //public async Task<int> UpdateAddressTypeAsync(AddressType addressType)
        //{
        //    return await _documentFileRepository.UpdateAddressTypeAsync(addressType);
        //}
    }
}
