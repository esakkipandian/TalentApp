using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface ICandidateSkillSetRepository : IRepository
    {
        Task<IEnumerable<CandidateSkillSet>> GetCandidateSkillSetsAsync();

        Task<IEnumerable<CandidateSkillSet>> GetCandidateSkillSetAsync(int CandidateSkillSetId);
    }
}
