using Prft.Talent.Domain.Talent.Candidate;
using Prft.Talent.Services.Api.Candidate;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Abstract.Candidate
{
    public interface IPersonalInformationService : IApi
    {
        Task<PersonalInformation> GetCandidatePersonalInformationAsync(GetPersonalInformationRequest PersonalInformationRequest);

        Task<SetPersonalInformationResponse> SetCandidatePersonalInformationAsync(PersonalInformationRequest PersonalInformationRequest);

        Task<SetPersonalInformationResponse> UpdateCandidatePersonalInformationAsync(PersonalInformationRequest PersonalInformationRequest);

        Task<SetPersonalInformationResponse> DeleteCandidatePersonalInformationAsync(GetPersonalInformationRequest PersonalInformationRequest);

    }
}
