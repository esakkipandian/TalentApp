using System.Collections.Generic;
using Prft.Talent.Domain.Talent;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
    public class CandidateDocumentResponse : ResponseBase
    {
        [JsonProperty("entity")]
        public IEnumerable<CandiateDocument> Entity { get; set; }
    }
}