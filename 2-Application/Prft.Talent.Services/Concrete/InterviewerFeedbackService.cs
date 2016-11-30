using Prft.Talent.Services.Abstract;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Concrete
{
    public class InterviewerFeedbackService: IInterviewerFeedbackService
    {
        private readonly IInterviewerFeedbackRepository _interviewerFeedbackRepository;
        public InterviewerFeedbackService( IInterviewerFeedbackRepository interviewerFeedbackRepository)
        {
            _interviewerFeedbackRepository = interviewerFeedbackRepository;

        }
        
        public async Task<InterviwerFeedbackResponse> GetInterviewerNameAsync()
        {
            return new InterviwerFeedbackResponse
            {
                InterviewerName =await  _interviewerFeedbackRepository.GetInterviewerNameAsync()
            };
        }
    }
}
