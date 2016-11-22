using Prft.Talent.Data.Repositories.Abstract;
using Prft.Talent.Services.Abstract;
using Prft.Talent.Services.Api;
using Prft.Talent.Domain.Talent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prft.Talent.Services.Concrete
{
    public class EducationalInformationService : IEducationalIformationService
    {
        private readonly IEducationalInformationRepository _educationalInformationRepository;
        public EducationalInformationService(IEducationalInformationRepository educationalInformationRepository)
        {
            _educationalInformationRepository = educationalInformationRepository;
        }
        public async Task<EducationalInforamtionResponse> GetEducationalInformationAsync(EducationalInformationRequest educationalInformationRequest)
        {
            return new EducationalInforamtionResponse
            {
                EducationalInformation = await _educationalInformationRepository.GetEducationalInformationAsync(educationalInformationRequest.CandidateId)
            };
        }
        public async Task<SetEducationalInformationResponse> SaveEducationalInformationAsync(EducationalInformation EducationInformation)
        {
            return new SetEducationalInformationResponse { 
              SuccessFlag=await _educationalInformationRepository.SaveEducationalInformationAsync(EducationInformation)
        };
    }
        public async Task<SetEducationalInformationResponse> UpdateEducationalInformationAsync(EducationalInformation EducationInformation)
        {
            return new SetEducationalInformationResponse
            {
                SuccessFlag = await _educationalInformationRepository.UpdateEducationalInformationAsync(EducationInformation)
            };
        }
        public async Task<SetEducationalInformationResponse> DeleteEducationalInformationAsync(EducationalInformation EducationalInformation)
        {
            return new SetEducationalInformationResponse
            {
                SuccessFlag = await _educationalInformationRepository.DeleteEducationalInformationAsync(EducationalInformation.CandidateId)
            };
        }
    }
}
