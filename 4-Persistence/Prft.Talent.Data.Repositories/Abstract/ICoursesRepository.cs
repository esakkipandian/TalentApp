using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Data.Entities;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface ICoursesRepository :IRepository
    {
        Task<IEnumerable<Courses>> GetCoursesAsync(string qualificationId);
    }
}
