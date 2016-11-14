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
    public class AddressTypeService : IAddressTypeService
    {
        private readonly IAddressTypeRepository _addressTypeRepository;

        public AddressTypeService(IAddressTypeRepository addressTypeRepository)
        {
            _addressTypeRepository = addressTypeRepository;
        }

        public async Task<int> AddAddressTypeAsync(AddressType addressType)
        {
            return await _addressTypeRepository.AddAddressTypeAsync(addressType);
        }

        public async Task<bool> DeleteAddressTypeAsync(int pk)
        {
            throw new NotImplementedException();
        }

        public async Task<AddressTypeResponse> GetAddressTypesAsync()
        {
            return new AddressTypeResponse
            {
                Entity = await _addressTypeRepository.GetAddressTypesAsync()
            };
        }

        public async Task<int> UpdateAddressTypeAsync(AddressType addressType)
        {
            return await _addressTypeRepository.UpdateAddressTypeAsync(addressType);
        }
    }
}
