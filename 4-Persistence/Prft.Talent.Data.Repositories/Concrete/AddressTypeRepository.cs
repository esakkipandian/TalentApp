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
using Prft.Talent.Logger;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class AddressTypeRepository : Repository, IAddressTypeRepository
    {
        public AddressTypeRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }

        public async Task<int> AddAddressTypeAsync(AddressType addressType)
        {
            var objectToAdd = Mapper.Map<addresstype>(addressType);
            objectToAdd.IsActive = true;
            DatabaseContext.addresstypes.Add(objectToAdd);
            return await DatabaseContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAddressTypeAsync(AddressType addressType)
        {
            var objectToDelete = Mapper.Map<addresstype>(addressType);
            objectToDelete.IsActive = false;
            DatabaseContext.Entry(objectToDelete).State = EntityState.Modified;
            return await DatabaseContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AddressType>> GetAddressTypesAsync()
        {
            return await DatabaseContext.addresstypes
                        .Where(x=>x.IsActive == true)
                        .ProjectTo<AddressType>(Mapper.ConfigurationProvider)
                        .ToListAsync();

        }

        public async Task<int> UpdateAddressTypeAsync(AddressType addressType)
        {
            var objectToUpdate = Mapper.Map<addresstype>(addressType);
            objectToUpdate.IsActive = true;
            DatabaseContext.Entry(objectToUpdate).State = EntityState.Modified;
            return await DatabaseContext.SaveChangesAsync();
        }
    }
}
