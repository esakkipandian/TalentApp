using Prft.Talent.Domain.Talent;
using Prft.Talent.Services.Api;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Prft.Talent.Services.Abstract
{
    public interface IEducationalIformationService : IApi
    {
        Task<EducationalInforamtionResponse> GetEducationalInformationAsync(EducationalInformationRequest EducationalInformationRequest);
        Task<SetEducationalInformationResponse> SaveEducationalInformationAsync(EducationalInformation EducationalInformation);
        Task<SetEducationalInformationResponse> UpdateEducationalInformationAsync(EducationalInformation EducationalInformation);
        Task<SetEducationalInformationResponse> DeleteEducationalInformationAsync(EducationalInformation EducationalInformation);
    }
}
