using Prft.Talent.Domain.Talent.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract.Candidate
{
    public interface ICandidateSkillSetRepository : IRepository
    {
        Task<CandidateSkillSet> GetCandidateSkillSetsAsync(int candidateId);

        Task<int> AddCandidateSkillSetsAsync(CandidateSkillSet candidateSkillSet);

        Task<int> DeleteCandidateSkillSetsAsync(int candidateId);
    }
}
