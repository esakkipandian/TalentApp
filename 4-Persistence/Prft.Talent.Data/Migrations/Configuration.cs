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

        }

        #region AddressType
        private static void SeedAddressType(TalentContext context)
        {
            //Address Type
            context.addresstypes.AddOrUpdate(
                a => a.Code,
                new addresstype
                {
                    PK= 1,
                    Code = "C",
                    Description = "Communication Address",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,

                },
                new addresstype
                {
                    PK=2,
                    Code = "P",
                    Description = "Permanent Address",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now,
                }
            );
        }
        #endregion

    }
}
