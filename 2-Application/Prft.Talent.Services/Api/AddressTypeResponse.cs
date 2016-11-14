using System.Collections.Generic;
using Prft.Talent.Domain.Talent;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
    public class AddressTypeResponse : ResponseBase
    {
        [JsonProperty("entity")]
        public IEnumerable<AddressType> Entity { get; set; }
    }
}