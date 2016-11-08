using System.Collections.Generic;
using Prft.Talent.Domain.Talent;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
    public class EmployeeResponse : ResponseBase
    {
        [JsonProperty("entity")]
        public IEnumerable<Employee> Entity { get; set; }
    }
}