using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;


namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface IUniversityRepository:IRepository
    {
        Task<IEnumerable<University>> GetUniversityAsync();
    }
}
