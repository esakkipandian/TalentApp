﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prft.Talent.Domain.Talent;
namespace Prft.Talent.Services.Api
{
    public class QualificationResponse : ResponseBase
    {
        public IEnumerable<EducationQualification> Qualification { get; set; }
    }

}
