using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Prft.Talent.Data.Repositories.Abstract;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Prft.Talent.Logger;
using Prft.Talent.Domain.Talent;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class CoursesRepository : Repository, ICoursesRepository
    {


        public CoursesRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }
        public async Task<IEnumerable<Courses>> GetCoursesAsync(string qualificationId)
        {


            return await Task.Run(() => GetCourseDetails(qualificationId));
        }

        public IEnumerable<Courses> GetCourseDetails(string qualificationId)
        {
            if (qualificationId == "4")
            {
                return new List<Courses>
            {
                new Courses { CourseCode="SSLC" ,CourseName="SSLC"},
                new Courses { CourseCode="HSC" ,CourseName="HSC"}
            };
            }
            else
            {
                return new List<Courses>
            {
                new Courses { CourseCode="B.E" ,CourseName="B.E"},
                new Courses { CourseCode="B.Tech" ,CourseName="B.Tech"},
                new Courses { CourseCode="MBA" ,CourseName="MBA"}
            };
            }
        }


    }
}




