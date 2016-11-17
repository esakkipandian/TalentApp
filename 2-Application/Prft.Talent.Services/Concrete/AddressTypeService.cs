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
using Prft.Talent.Logger;

namespace Prft.Talent.Services.Concrete
{
    public class AddressTypeService : IAddressTypeService
    {
        private readonly IAddressTypeRepository _addressTypeRepository;
        private readonly IPrftLogger _logger;

        public AddressTypeService(IAddressTypeRepository addressTypeRepository, IPrftLogger logger)
        {
            _addressTypeRepository = addressTypeRepository;
            _logger = logger;
        }

        public async Task<int> AddAddressTypeAsync(AddressType addressType)
        {
            return await _addressTypeRepository.AddAddressTypeAsync(addressType);
        }

        public async Task<int> DeleteAddressTypeAsync(AddressType addressType)
        {
            return await _addressTypeRepository.DeleteAddressTypeAsync(addressType);
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
