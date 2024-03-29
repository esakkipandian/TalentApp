﻿using Prft.Talent.Domain.Talent.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Data.Repositories.Abstract.Candidate
{
    public interface IPersonalInformationRepository : IRepository
    {
        Task<PersonalInformation> GetCandidatePersonalInformationAsync(int CandidateId);

        Task<int> SetCandidatePersonalInformationAsync(PersonalInformation PersonalInformation);

        Task<int> UpdateCandidatePersonalInformationAsync(PersonalInformation PersonalInformation);

        Task<int> DeleteCandidatePersonalInformationAsync(int CandidateId);
    }
}
