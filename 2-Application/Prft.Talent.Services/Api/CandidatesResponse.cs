using Prft.Talent.Domain.Talent;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
   public class CandidatesResponse:ResponseBase
    {
        [JsonProperty("entity")]
        public IEnumerable<Candidates> Entity { get; set; }
    }
}
