﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent.Candidate;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api.Candidate
{
    public class PersonalInformationResponse : ResponseBase
    {
        public PersonalInformation PersonalInformation { get; set; }
    }

    public class SetPersonalInformationResponse : ResponseBase
    {
        public int SuccessFlag { get; set; }
    }

    public class PersonalInformationRequest : RequestBase
    {
        public PersonalInformation CandidatePersonalInformation { get; set; }
    }

    public class GetPersonalInformationRequest : RequestBase
    {
        public int CandidateId { get; set; }
    }
}
