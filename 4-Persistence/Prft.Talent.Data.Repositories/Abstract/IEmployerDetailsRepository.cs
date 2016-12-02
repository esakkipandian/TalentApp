using Prft.Talent.Data.Entities;
using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface IEmployerDetailsRepository : IRepository
    {
        Task<IEnumerable<EmployerDetails>> GetEmployersAsync();
    }
}
