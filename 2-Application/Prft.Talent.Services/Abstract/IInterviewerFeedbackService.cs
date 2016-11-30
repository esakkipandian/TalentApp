using Prft.Talent.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;

namespace Prft.Talent.Services.Abstract
{
    public interface IInterviewerFeedbackService:IApi
    {
        Task<InterviwerFeedbackResponse> GetInterviewerDesignationAsync();
    }
}
