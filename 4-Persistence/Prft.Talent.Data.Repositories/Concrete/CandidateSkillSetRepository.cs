using AutoMapper;
using Prft.Talent.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prft.Talent.Domain.Talent;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class CandidateSkillSetRepository : Repository, ICandidateSkillSetRepository
    {
        public CandidateSkillSetRepository(PrftDatabaseContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public Task<IEnumerable<CandidateSkillSet>> GetCandidateSkillSetsAsync()
        {
            return Task.FromResult(GetCandidateSkillSets());
        }

        public Task<IEnumerable<CandidateSkillSet>> GetCandidateSkillSetAsync(int CandidateSkillSetId)
        {
            return Task.FromResult(GetCandidateSkillSets().Where(x => x.CandidateSkillSetId == CandidateSkillSetId));
        }

        public IEnumerable<CandidateSkillSet> GetCandidateSkillSets()
        {
            return new List<CandidateSkillSet>
            {
                new CandidateSkillSet { CandidateSkillSetId = 1, CandidateSkillSetName = "C"},
                new CandidateSkillSet { CandidateSkillSetId = 2, CandidateSkillSetName = "C++"},
                new CandidateSkillSet { CandidateSkillSetId = 3, CandidateSkillSetName = "C#"},
                new CandidateSkillSet { CandidateSkillSetId = 4, CandidateSkillSetName = "ASP .NET"},
                new CandidateSkillSet { CandidateSkillSetId = 5, CandidateSkillSetName = "ASP .NET MVC"},
                new CandidateSkillSet { CandidateSkillSetId = 6, CandidateSkillSetName = "WCF"},
                new CandidateSkillSet { CandidateSkillSetId = 7, CandidateSkillSetName = "WEB API"},
                new CandidateSkillSet { CandidateSkillSetId = 8, CandidateSkillSetName = "ANGULARJS"},
                new CandidateSkillSet { CandidateSkillSetId = 9, CandidateSkillSetName = "ANGULAR2"},
                new CandidateSkillSet { CandidateSkillSetId = 10, CandidateSkillSetName = "TESTING"}
            };
        }
    }
}