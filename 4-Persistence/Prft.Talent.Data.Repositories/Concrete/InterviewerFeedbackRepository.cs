using AutoMapper;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Prft.Talent.Data.Repositories.Abstract;

namespace Prft.Talent.Data.Repositories.Concrete
{
    public class InterviewerFeedbackRepository:Repository, IInterviewerFeedbackRepository
    {
        public InterviewerFeedbackRepository(PrftDatabaseContext dbContext, IMapper mapper, IPrftLogger logger) : base(dbContext, mapper, logger) { }

        public async Task<IEnumerable<InterviewerDesignation>> GetInterviewerDesignationAsync()
        {
            var result = new List<InterviewerDesignation>() { new InterviewerDesignation() { id = 1, Designation = "Technical Consulatant" },
            new InterviewerDesignation() { id = 2, Designation = "Associate Technical Consultant" },
            new InterviewerDesignation() { id = 3, Designation = "Lead Technical Consultant" } };

            return await Task.FromResult(result);

             
        }
    
    }
}
