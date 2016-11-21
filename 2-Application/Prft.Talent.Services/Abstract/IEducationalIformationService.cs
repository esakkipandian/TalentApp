﻿using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract
{
    public interface IEducationalIformationService : IApi
    {
        Task<EducationalInforamtionResponse> GetEducationalInformationAsync(EducationalInformationRequest EducationalInformationRequest);
        Task<int> SaveEducationalInformationAsync(EducationalInformation EducationalInformation);
        Task<int> UpdateEducationalInformationAsync(EducationalInformation EducationalInformation);
    }
}
