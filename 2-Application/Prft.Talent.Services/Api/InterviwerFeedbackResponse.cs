using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Api
{
    public class InterviwerFeedbackResponse:ResponseBase
    {
        public IEnumerable<InterviewerName> InterviewerName { get; set; }
    }
}
