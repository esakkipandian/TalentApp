using Prft.Talent.Data.Repositories.Abstract.Candidate;
using Prft.Talent.Domain.Talent.Candidate;
using Prft.Talent.Services.Abstract.Candidate;
using Prft.Talent.Services.Api.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Concrete.Candidate
{
    public class PersonalInformationService : IPersonalInformationService
    {
        private readonly IPersonalInformationRepository _personalInformationRepository;

        public PersonalInformationService(IPersonalInformationRepository personalInformationRepository)
        {
            _personalInformationRepository = personalInformationRepository;
        }

        public async Task<SetPersonalInformationResponse> DeleteCandidatePersonalInformationAsync(GetPersonalInformationRequest personalInformationRequest)
        {
            return new SetPersonalInformationResponse
            {
                SuccessFlag = await _personalInformationRepository.DeleteCandidatePersonalInformationAsync(personalInformationRequest.CandidateId)
            };
        }

        public async Task<PersonalInformation> GetCandidatePersonalInformationAsync(GetPersonalInformationRequest personalInformationRequest)
        {
            return await _personalInformationRepository.GetCandidatePersonalInformationAsync(personalInformationRequest.CandidateId);
            //return new PersonalInformationResponse
            //{
            //    PersonalInformation = await _personalInformationRepository.GetCandidatePersonalInformationAsync(personalInformationRequest.CandidateId)
            //};
        }

        public async Task<SetPersonalInformationResponse> SetCandidatePersonalInformationAsync(PersonalInformationRequest personalInformationRequest)
        {
            return new SetPersonalInformationResponse
            {
                SuccessFlag = await _personalInformationRepository.SetCandidatePersonalInformationAsync(personalInformationRequest.CandidatePersonalInformation)
            };
        }
    }
}
