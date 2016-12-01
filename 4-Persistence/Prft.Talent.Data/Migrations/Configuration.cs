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
            SeedCountries(context);
            SeedStates(context);
            SeedUniversities(context);
            SeedSkills(context);
            SeedColleges(context);
            SeedCandidates(context);
        }


        #region Country
        private static void SeedCountries(TalentContext context)
        {
            context.countries.AddOrUpdate(a => a.Code,
                new country
                {
                    Code = "IND",
                    Description = "India",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                },
                 new country
                 {
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
                  Code = "TN",
                  Description = "TamilNadu",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new state
               {
                   Code = "KL",
                   Description = "Kerala",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               },
                new state
                {
                    Code = "MH",
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
                  Code = "AU",
                  Description = "Anna University",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new university
               {
                   Code = "AMU",
                   Description = "Annamalai University",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               },
               new university
               {
                   Code = "MKU",
                   Description = "Madurai Kamarajar University",
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
                  Code = "Java",
                  Description = "Core Java",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new skill
               {
                   Code = ".Net",
                   Description = "C#",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               },
               new skill
               {
                   Code = "PHP",
                   Description = "PHP",
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
                  Code = "PSG",
                  Description = "PSG College of Technology-Coimbatore",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new college
               {
                   Code = "BIT",
                   Description = "Bharathidasan Institute of Engineering and Technology – Tiruchirappalli",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               },
                new college
                {
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
                    FirstName = "Priyanka",
                    LastName = "Karthick",
                    DOB = DateTime.Parse("1991/07/22"),
                    FatherName = "Karthick",
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
                     FirstName = "Madhumitha",
                     LastName = "BalaKrishnan",
                     DOB = DateTime.Parse("1993/07/22"),
                     FatherName = "BalaKrishnan",
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

    }
}
