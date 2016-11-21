﻿using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract
{
    public interface IEducationalInformationRepository : IRepository
    {
        Task<EducationalInformation> GetEducationalInformationAsync(int CandidateId);
        //Task<EducationalInformation> SaveEducationalInformationAsync(EducationalInformation EducationalInformation);
    }
}
