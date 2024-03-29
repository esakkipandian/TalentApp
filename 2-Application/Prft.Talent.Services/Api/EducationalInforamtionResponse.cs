﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;
using Newtonsoft.Json;

namespace Prft.Talent.Services.Api
{
    public class EducationalInforamtionResponse : ResponseBase
    {
        public IEnumerable<EducationalInformation> EducationalInformation { get; set; }
    }
    public class EducationalInformationRequest : RequestBase
    {
        public int CandidateId { get; set; }      
    }
    public class SetEducationalInformationResponse : ResponseBase
    {
        public int SuccessFlag { get; set; }
    }
}
