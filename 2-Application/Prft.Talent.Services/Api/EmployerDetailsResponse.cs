using System.Collections.Generic;
using Prft.Talent.Domain.Talent;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
    public class EmployerDetailsResponse : ResponseBase
    {
        [JsonProperty("entity")]
        public IEnumerable<EmployerDetails> Entity { get; set; }
    }
}