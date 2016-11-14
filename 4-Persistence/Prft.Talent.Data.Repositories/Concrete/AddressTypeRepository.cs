using Prft.Talent.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Data.Entities;
using AutoMapper;
using Prft.Talent.Domain.Talent;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class AddressTypeRepository : Repository, IAddressTypeRepository
    {
        public AddressTypeRepository(PrftDatabaseContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public async Task<int> AddAddressTypeAsync(AddressType addressType)
        {
            var objectToAdd = Mapper.Map<addresstype>(addressType);
            DatabaseContext.addresstypes.Add(objectToAdd);
            return await DatabaseContext.SaveChangesAsync();
        }

        public Task<bool> DeleteAddressTypeAsync(int pk)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AddressType>> GetAddressTypesAsync()
        {
            return await DatabaseContext.addresstypes.ProjectTo<AddressType>(Mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<int> UpdateAddressTypeAsync(AddressType addressType)
        {
            var objectToAdd = Mapper.Map<addresstype>(addressType);
            DatabaseContext.Entry(objectToAdd).State = EntityState.Modified;
            return await DatabaseContext.SaveChangesAsync();
        }
    }
}
