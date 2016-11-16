namespace Prft.Talent.Data.Migrations
{
    using MySql.Data.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Prft.Talent.Data.Entities;


    public sealed class Configuration : DbMigrationsConfiguration<Prft.Talent.Data.Entities.TalentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator());
        }

        protected override void Seed(TalentContext context)
        {
            //  This method will be called after migrating to the latest version.

            SeedAddressType(context);
            SeedCountries(context);
            SeedStates(context);
            SeedUniversities(context);            
            SeedSkills(context);
            SeedColleges(context);
            SeedCandidates(context);
            SeedCandidateAddress(context);
            SeedCandidateEducation(context);
            SeedCandidateExperience(context);
            SeedCandidateSkill(context);       

        }

        #region AddressType
        private static void SeedAddressType(TalentContext context)
        {
            //Address Type
            context.addresstypes.AddOrUpdate(
                a => a.Code,
                new addresstype
                {
                    PK = 1,
                    Code = "C",
                    Description = "Communication Address",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,

                },
                new addresstype
                {
                    PK = 2,
                    Code = "P",
                    Description = "Permanent Address",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                }
            );
        }
        #endregion
        #region Country
        private static void SeedCountries(TalentContext context)
        {
            context.countries.AddOrUpdate(a => a.Code,
                new country
                {
                    PK = 1,
                    Code = "IND",
                    Description = "India",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                },
                 new country
                 {
                     PK = 2,
                     Code = "US",
                     Description = "United States",
                     IsActive = true,
                     CreatedDate = DateTime.Now,
                     LastUpdatedDate = DateTime.Now,
                 }
                 );
        }
        #endregion
        #region States
        public static void SeedStates(TalentContext context)
        {
            context.states.AddOrUpdate(a => a.Code,
              new state
              {
                  PK = 1,
                  Code = "TN",
                  Description = "TamilNadu",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new state
               {
                   PK = 2,
                   Code = "K",
                   Description = "Kerala",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               },
                new state
                {
                    PK = 3,
                    Code = "M",
                    Description = "Maharashtra",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                });
        }
        #endregion
        #region University
        public static void SeedUniversities(TalentContext context)
        {
            context.universities.AddOrUpdate(a => a.Code,
              new university
              {
                  PK = 1,
                  Code = "AU",
                  Description = "Anna University",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new university
               {
                   PK = 2,
                   Code = "AMU",
                   Description = "Annamalai University",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               });
        }
        #endregion
        #region Skills
        public static void SeedSkills(TalentContext context)
        {
            context.skills.AddOrUpdate(a => a.Code,
              new skill
              {
                  PK = 1,
                  Code = "Java",
                  Description = "Core Java",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new skill
               {
                   PK = 2,
                   Code = ".Net",
                   Description = "C#",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               });

        }
        #endregion
        #region College
        public static void SeedColleges(TalentContext context)
        {
            context.colleges.AddOrUpdate(a => a.Code,
              new college
              {
                  PK = 1,
                  Code = "PSG",
                  Description = "PSG College of Technology-Coimbatore",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new college
               {
                   PK = 2,
                   Code = "BIT",
                   Description = "Bharathidasan Institute of Engineering and Technology – Tiruchirappalli",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               },
                new college
                {
                    PK = 3,
                    Code = "CSIR",
                    Description = "Central Electrochemical Research Institute-Karaikudi",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                });
        }
        #endregion
        #region Candidate
        public static void SeedCandidates(TalentContext context)
        {
            context.candidates.AddOrUpdate(a => a.Mobile,
                new candidate
                {
                    PK = 1,
                    FirstName = "Priyanka",
                    LastName = "Karthick",
                    DOB = DateTime.Parse("1991/07/22"),
                    FatherName = "Karthick",
                    MotherName = "Swathy",
                    Nationality = "Indian",
                    Email = "priyanka.karthick@hotmail.com",
                    Mobile = "9997865432",
                    AlternateContact = "9997866632",
                    IsExperienced = true,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                 new candidate
                 {
                     PK = 2,
                     FirstName = "Madhumitha",
                     LastName = "BalaKrishnan",
                     DOB = DateTime.Parse("1993/07/22"),
                     FatherName = "BalaKrishnan",
                     MotherName = "Radhika",
                     Nationality = "Indian",
                     Email = "madhumitha.radhika@gmail.com",
                     Mobile = "9894345672",
                     AlternateContact = "9089712437",
                     IsExperienced = true,
                     IsActive = true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now
                 }
                );
        }
        #endregion
        #region CandidateAddress
        public static void SeedCandidateAddress(TalentContext context)
        {
            context.candidateaddresses.AddOrUpdate(a => a.CandidateId,
                new candidateaddress
                {
                    PK = 1,
                    CandidateId = 1,
                    AddressTypeId = 2,
                    AddressLine1 = "#238/A, 4 Bangalows, Near St. Louis School",
                    AddressLine2 = "Andheri(W),Mumbai",
                    City = "Mumbai",
                    StateId = 3,
                    CountryId = 1,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                 new candidateaddress
                 {
                     PK = 2,
                     CandidateId = 2,
                     AddressTypeId = 1,
                     AddressLine1 = "#4,South Usman Road",
                     AddressLine2 = "T.Nagar,Chennai",
                     City = "Chennai",
                     StateId = 1,
                     CountryId = 1,
                     IsActive = true,
                     CreatedDate = DateTime.Now,
                     ModifiedDate = DateTime.Now
                 }

                );
        }
        #endregion
        #region CandidateEducation
        public static void SeedCandidateEducation(TalentContext context)
        {
            context.candidateeducations.AddOrUpdate(a => a.CandidateId,
                new candidateeducation
                {
                    PK = 1,
                    CandidateId = 1,
                    DegreeName = "B.Tech",
                    Specialization = "CSE",
                    CollegeId = 1,
                    UniversityId = 1,
                    YearOfPassing = DateTime.Parse("2012/01/01"),
                    Percentage = 88,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                  new candidateeducation
                  {
                      PK = 2,
                      CandidateId = 2,
                      DegreeName = "B.E",
                      Specialization = "ECE",
                      CollegeId = 2,
                      UniversityId = 1,
                      YearOfPassing = DateTime.Parse("2014/01/01"),
                      Percentage = 76,
                      IsActive = true,
                      CreatedDate = DateTime.Now,
                      ModifiedDate = DateTime.Now
                  }


                );
        }
        #endregion
        #region CandidateSkill
        public static void SeedCandidateSkill(TalentContext context)
        {
            context.candidateskills.AddOrUpdate(a => a.CandidateId,
                new candidateskill
                {
                    PK = 1,
                    CandidateId = 1,
                    SkillId=1,
                    Rating=4,
                    SinceLastUsed= DateTime.Parse("2016/01/01"),
                    IsPrimary=true,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                  new candidateskill
                  {
                      PK = 2,
                      CandidateId = 2,
                      SkillId = 2,
                      Rating = 5,
                      SinceLastUsed = DateTime.Parse("2016/01/01"),
                      IsPrimary = true,
                      IsActive = true,
                      CreatedDate = DateTime.Now,
                      ModifiedDate = DateTime.Now
                  },
                   new candidateskill
                   {
                       PK = 3,
                       CandidateId = 2,
                       SkillId = 1,
                       Rating = 3,
                       SinceLastUsed = DateTime.Parse("2013/01/01"),
                       IsPrimary = false,
                       IsActive = true,
                       CreatedDate = DateTime.Now,
                       ModifiedDate = DateTime.Now
                   }
                );
        }
        #endregion
        #region CandidateExperience
        public static void SeedCandidateExperience(TalentContext context)
        {
            context.candidateworkexperiences.AddOrUpdate(a => a.CandidateId,
                new candidateworkexperience
                {
                    PK = 1,
                    CandidateId = 1,
                    OrganizationName = "IBM",
                    Designation = "Technical Consultant",
                    Roles = "Jr.Developer",
                    StartDate = DateTime.Parse("2012/06/04"),
                    EndDate = DateTime.Now,
                    LeavingReason="Proffessional Growth",            
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                  new candidateworkexperience
                  {
                      PK = 2,
                      CandidateId = 2,
                      OrganizationName = "Zoho",
                      Designation = "Software Engineer",
                      Roles = "Application Developer",
                      StartDate = DateTime.Parse("2014/07/02"),
                      EndDate = DateTime.Now,
                      LeavingReason = "Need a change",
                      IsActive = true,
                      CreatedDate = DateTime.Now,
                      ModifiedDate = DateTime.Now
                  }
                );
        }
        #endregion

    }
}
