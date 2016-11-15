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
            SeedCandidateInformation(context);

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
        private static void SeedCandidateInformation(TalentContext context)
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
                 } );
            context.colleges.AddOrUpdate(a => a.Code,
               new college
               {
                   PK = 1,
                   Code = "A",
                   Description = "Anna University",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               },
                new college
                {
                    PK = 2,
                    Code = "S",
                    Description = "SRM",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                });
            context.states.AddOrUpdate(a => a.Code,
              new state
              {
                  PK = 1,
                  Code = "T",
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
               });

            context.skills.AddOrUpdate(a => a.Code,
              new skill
              {
                  PK = 1,
                  Code = "Java",
                  Description = "Hibernet,core java",
                  IsActive = true,
                  CreatedDate = DateTime.Now,
                  LastUpdatedDate = DateTime.Now,
              },
               new skill
               {
                   PK = 2,
                   Code = ".Net",
                   Description = "C#,sql2008,vs2015,MVC",
                   IsActive = true,
                   CreatedDate = DateTime.Now,
                   LastUpdatedDate = DateTime.Now,
               });
           

        }
        #endregion

    }
}
