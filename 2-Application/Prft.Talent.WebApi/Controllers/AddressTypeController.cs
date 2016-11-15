using Prft.Talent.Domain.Talent;
using Prft.Talent.Services;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class AddressTypeController : ApiController
    {
        private readonly IAddressTypeService _addressTypeService;

        public AddressTypeController(IAddressTypeService addressTypeService)
        {
            _addressTypeService = addressTypeService;
        }

        // GET api/<controller>
        public async Task<AddressTypeResponse> Get()
        {
            var addressTypes = await _addressTypeService.GetAddressTypesAsync();
            return addressTypes;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post(AddressType addressType)
        {
            _addressTypeService.AddAddressTypeAsync(addressType);
        }

        [HttpPut]
        [Route("api/AddressType/UpdateAddressType")]
        public void UpdateAddressType(AddressType addressType)
        {
            _addressTypeService.UpdateAddressTypeAsync(addressType);
        }

        [HttpPut]
        [Route("api/AddressType/DeleteAddressType")]
        public void DeleteAddressType(AddressType addressType)
        {
            _addressTypeService.DeleteAddressTypeAsync(addressType);
        }
    }
}