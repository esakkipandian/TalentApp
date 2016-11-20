using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;

namespace Prft.Talent.Services.Abstract
{
    public interface ICoursesService:IApi
    {
        Task<CoursesResponse> GetCoursesAsync();
    }
}
