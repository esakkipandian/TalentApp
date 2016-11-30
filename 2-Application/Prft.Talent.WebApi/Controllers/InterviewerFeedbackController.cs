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
        [Route("api/InterviewerFeedback/GetInterviewerName")]
        public  async Task<InterviwerFeedbackResponse> GetInterviewerName()
        {
            var interviewerName =await _interviewerFeedbackService.GetInterviewerNameAsync();
            return interviewerName;
        }
       
    }
}