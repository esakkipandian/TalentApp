using AutoMapper;
using Prft.Talent.Data.Entities;
using Prft.Talent.Domain.Talent;



namespace Prft.Talent.Domain.Mapping
{
    public static class TalentMappings
    {
        public static void RegisterTalentMappings(IProfileExpression profile)
        {
            profile.CreateMap<employee, Employee>();
            profile.CreateMap<addresstype, AddressType>().ReverseMap();
 	    profile.CreateMap<candidate, Candidate>().ReverseMap(); 
            profile.CreateMap<candidate, PersonalInformation>()
                .ForMember(x => x.CandidateId, map => map.MapFrom(c => c.PK)).ReverseMap();

        }
    }
}
