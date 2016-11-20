using AutoMapper;
using Prft.Talent.Data.Entities;
using Prft.Talent.Domain.Talent;
using Prft.Talent.Domain.Talent.Candidate;


namespace Prft.Talent.Domain.Mapping
{
    public static class TalentMappings
    {
        public static void RegisterTalentMappings(IProfileExpression profile)
        {
            profile.CreateMap<addresstype, AddressType>().ReverseMap();
            profile.CreateMap<candidate, Candidates>()
                 .ForMember(x => x.FullName, map => map.MapFrom(c => c.FirstName + " " + c.LastName))
                .ReverseMap();
            profile.CreateMap<candidate, PersonalInformation>()
                .ForMember(x => x.CandidateId, map => map.MapFrom(c => c.PK)).ReverseMap();
            profile.CreateMap<college,Colleges>()
                  .ForMember(x => x.CollegeCode, map => map.MapFrom(c => c.Code))
                  .ForMember(x => x.CollegeName, map => map.MapFrom(c => c.Description))
                
                .ReverseMap();
            profile.CreateMap<university, University > ()
                  .ForMember(x => x.UniversityCode, map => map.MapFrom(c => c.Code))
                  .ForMember(x => x.UniversityName, map => map.MapFrom(c => c.Description))

                .ReverseMap();
        }
    }
}
