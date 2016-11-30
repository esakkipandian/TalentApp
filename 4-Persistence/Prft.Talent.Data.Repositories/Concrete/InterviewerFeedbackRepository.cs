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

        public async Task<IEnumerable<InterviewerName>> GetInterviewerNameAsync()
        {
            var result = new List<InterviewerName>() { new InterviewerName() { id = 1, Name = "sunil" },
            new InterviewerName() { id = 2, Name = "Dhilip" },
            new InterviewerName() { id = 3, Name = "sunil" } };

            return await Task.FromResult(result);

             
        }
    }
}
