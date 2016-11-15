using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract
{
    public interface IAddressTypeService : IApi
    {
        Task<AddressTypeResponse> GetAddressTypesAsync();

        Task<int> AddAddressTypeAsync(AddressType addressType);

        Task<int> UpdateAddressTypeAsync(AddressType addressType);

        Task<int> DeleteAddressTypeAsync(AddressType addressType);
    }
}
