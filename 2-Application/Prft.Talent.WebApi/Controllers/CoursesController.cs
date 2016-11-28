using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Logger;
using Prft.Talent.Services;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Services.Concrete;
using System.Threading.Tasks;

namespace Prft.Talent.WebApi.Controllers
{
    public class CoursesController : ApiController
    {
        private readonly ICoursesService _courseService;
        private readonly IPrftLogger _logger;
        public CoursesController(ICoursesService courseservices, IPrftLogger logger)
        {

            _courseService = courseservices;
            _logger = logger;
        }
        public async Task<CoursesResponse> Get(int id)
        {
            var Courses = await _courseService.GetCoursesAsync(id.ToString());
            //LogException();
            return Courses;
        }
    }
}
