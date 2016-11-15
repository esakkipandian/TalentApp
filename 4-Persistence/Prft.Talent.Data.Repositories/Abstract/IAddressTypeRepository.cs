using Prft.Talent.Data.Entities;
using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface IAddressTypeRepository : IRepository
    {
        Task<IEnumerable<AddressType>> GetAddressTypesAsync();

        Task<int> AddAddressTypeAsync(AddressType addressType);

        Task<int> UpdateAddressTypeAsync(AddressType addressType);

        Task<int> DeleteAddressTypeAsync(AddressType addressType);
    }
}