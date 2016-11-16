using Prft.Talent.Domain.Talent;
using Prft.Talent.Logger;
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
        private readonly IPrftLogger _logger;

        public AddressTypeController(IAddressTypeService addressTypeService, IPrftLogger logger)
        {
            _addressTypeService = addressTypeService;
            _logger = logger;
        }

        // GET api/<controller>
        public async Task<AddressTypeResponse> Get()
        {
            var addressTypes = await _addressTypeService.GetAddressTypesAsync();
            //LogException();
            return addressTypes;
        }

        private void LogException()
        {
            try
            {
                var x = 0;
                var y = 10 / x;
            }
            catch (Exception ex)
            {
                _logger.Log(ex, "Application Internal Exception");
            }
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