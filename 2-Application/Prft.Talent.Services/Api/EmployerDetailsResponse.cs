using System.Collections.Generic;
using Prft.Talent.Domain.Talent;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
    public class EmployerDetailsResponse : ResponseBase
    {
       public IEnumerable<EmployerDetails> EmployerDetails { get; set; }
    }

    public class SetEmployerDetailsResponse:ResponseBase
    {
        public int Successflag { get; set; }
    }

    public class EmployerDetailsRequest : RequestBase
    {
        public EmployerDetails EmployerDetails { get; set; }
    }

    public class EmployerDetailsIdRequest : RequestBase
    {
        public int CandidateEmployerId { get; set; }
    }
}