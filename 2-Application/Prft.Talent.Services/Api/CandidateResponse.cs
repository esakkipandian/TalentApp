using System.Collections.Generic;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
   public class CandidateResponse:ResponseBase
    {
        [JsonProperty("entity")]
        public IEnumerable<Prft.Talent.Domain.Talent.Candidate> Entity { get; set; }
    }
}
