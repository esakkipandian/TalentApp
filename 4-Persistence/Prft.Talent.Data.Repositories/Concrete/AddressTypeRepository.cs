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

        public async Task<IEnumerable<AddressType>> GetAddressTypesAsync()
        {
            return await DatabaseContext.addresstypes.ProjectTo<AddressType>(Mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
