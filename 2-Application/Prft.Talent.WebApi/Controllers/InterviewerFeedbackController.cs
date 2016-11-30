using Prft.Talent.Domain.Talent;
using Prft.Talent.Services;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using System.Threading.Tasks;
using System.Web.Http;

namespace Prft.Talent.WebApi.Controllers
{
    public class InterviewerFeedbackController : ApiController
    {
        private readonly IInterviewerFeedbackService _interviewerFeedbackService;

        public InterviewerFeedbackController(IInterviewerFeedbackService interviewerFeedbackService)
        {
            _interviewerFeedbackService = interviewerFeedbackService;
        }
        [HttpGet]
        [Route("api/InterviewerFeedback/GetInterviewerDesignation")]
        public  async Task<InterviwerFeedbackResponse> GetInterviewerDesignation()
        {
            var interviewerDesignation =await _interviewerFeedbackService.GetInterviewerDesignationAsync();
            return interviewerDesignation;
        }
       
    }
}