using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Services.Api;
using Prft.Talent.Logger;
using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Abstract;

namespace Prft.Talent.Services.Concrete
{
   public  class CoursesServices :ICoursesService
    {
        private readonly ICoursesRepository _courseRepository;
        private readonly IPrftLogger _logger;
        public CoursesServices(ICoursesRepository courseRepository, IPrftLogger logger)
        {

            _courseRepository = courseRepository;
            _logger = logger;
        }


        public async Task<CoursesResponse> GetCoursesAsync(string qualificationId)
        {

            return new CoursesResponse
            {
                Courses = await _courseRepository.GetCoursesAsync(qualificationId)
            };

        }
    }
}
