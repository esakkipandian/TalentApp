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
            profile.CreateMap<college, Colleges>()
                  .ForMember(x => x.CollegeCode, map => map.MapFrom(c => c.Code))
                  .ForMember(x => x.CollegeName, map => map.MapFrom(c => c.Description))
                  .ForMember(x => x.Id, map => map.MapFrom(c => c.PK))


                .ReverseMap();
            profile.CreateMap<university, University>()
                  .ForMember(x => x.UniversityCode, map => map.MapFrom(c => c.Code))
                  .ForMember(x => x.UniversityName, map => map.MapFrom(c => c.Description))
                  .ForMember(x => x.Id, map => map.MapFrom(c => c.PK))

                .ReverseMap();
            profile.CreateMap<candidateeducation, EducationalInformation>()
               .ForMember(x => x.Course, map => map.MapFrom(c => c.Specialization))
                  .ForMember(x => x.PassedOut, map => map.MapFrom(c => c.YearOfPassing))
                  .ForMember(x => x.DegreeName, map => map.MapFrom(c => c.DegreeName))
            .ForMember(x => x.Specialization, map => map.MapFrom(c => c.Specialization))
            .ForMember(x => x.University, map => map.MapFrom(c => c.University))
            .ForMember(x => x.College, map => map.MapFrom(c => c.College))
            .ForMember(x => x.Percentage, map => map.MapFrom(c => c.Percentage)).ReverseMap()
            .ForMember(x => x.CollegeId, map => map.MapFrom(c => c.CollegeId)).ReverseMap()
            .ForMember(x=>x.Qualification,map=>map.MapFrom(c=>c.Qualification)).ReverseMap()
            .ForMember(x=>x.CourseType,map=>map.MapFrom(c=>c.CourseType)).ReverseMap()
            .ForMember(x => x.UniversityId, map => map.MapFrom(c => c.UniversityId)).ReverseMap();

            profile.CreateMap<skill, SkillSet>().ReverseMap();

            profile.CreateMap<candidatedocument, CandidateDocument>()
                   .ForMember(x => x.CandidateId, map => map.MapFrom(c => c.CandidateId)).ReverseMap();

            profile.CreateMap<candidateskill, CandidateSkillSet>().ReverseMap();
                   // .ForMember(x => x.CandidateSkillSetId, map => map.MapFrom(c => c.PK)).ReverseMap();

        }
    }
}
