using Prft.Talent.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;


namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface ICandidatesRepository:IRepository
    {
        Task<IEnumerable<Candidates>> GetCandidateInformationAsync();
    }
}
