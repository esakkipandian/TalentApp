using Prft.Talent.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface IEmployeeRepository : IRepository
    {
        IQueryable<employee> GetEmployees();
    }
}
