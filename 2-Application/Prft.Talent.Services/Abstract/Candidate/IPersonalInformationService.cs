﻿using Prft.Talent.Services.Api.Candidate;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract.Candidate
{
    public interface IPersonalInformationService : IApi
    {
        Task<PersonalInformationResponse> GetCandidatePersonalInformationAsync(GetPersonalInformationRequest PersonalInformationRequest);

        Task<SetPersonalInformationResponse> SetCandidatePersonalInformationAsync(PersonalInformationRequest PersonalInformationRequest);

    }
}