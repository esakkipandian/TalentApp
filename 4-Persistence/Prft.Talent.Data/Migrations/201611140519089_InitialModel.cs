namespace Prft.Talent.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.addresstype",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        CreatedDate = c.DateTime(precision: 0),
                        LastUpdatedBy = c.String(maxLength: 100, unicode: false),
                        LastUpdatedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.PK);
            
            CreateTable(
                "dbo.candidateaddress",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        AddressTypeId = c.Int(nullable: false),
                        AddressLine1 = c.String(maxLength: 150, unicode: false),
                        AddressLine2 = c.String(maxLength: 150, unicode: false),
                        City = c.String(maxLength: 150, unicode: false),
                        StateId = c.Int(),
                        CountryId = c.Int(),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .ForeignKey("dbo.country", t => t.CountryId)
                .ForeignKey("dbo.state", t => t.StateId)
                .ForeignKey("dbo.addresstype", t => t.AddressTypeId)
                .Index(t => t.CandidateId)
                .Index(t => t.AddressTypeId)
                .Index(t => t.StateId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.candidate",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 100, unicode: false),
                        DOB = c.DateTime(nullable: false, precision: 0),
                        FatherName = c.String(maxLength: 100, unicode: false),
                        MotherName = c.String(maxLength: 100, unicode: false),
                        Nationality = c.String(maxLength: 45, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Mobile = c.String(maxLength: 15, unicode: false),
                        AlternateContact = c.String(maxLength: 15, unicode: false),
                        IsExperienced = c.Boolean(storeType: "bit"),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK);
            
            CreateTable(
                "dbo.candidateeducation",
                c => new
                    {
                        PK = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        DegreeName = c.String(maxLength: 100, unicode: false),
                        Specialization = c.String(maxLength: 200, unicode: false),
                        CollegeId = c.Int(),
                        College = c.String(maxLength: 200, unicode: false),
                        UniversityId = c.Int(),
                        University = c.String(maxLength: 200, unicode: false),
                        YearOfPassing = c.DateTime(storeType: "date"),
                        Percentage = c.Decimal(precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.college", t => t.PK)
                .ForeignKey("dbo.university", t => t.UniversityId)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .Index(t => t.PK)
                .Index(t => t.CandidateId)
                .Index(t => t.UniversityId);
            
            CreateTable(
                "dbo.college",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 5, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsActive = c.Boolean(storeType: "bit"),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        CreatedDate = c.DateTime(precision: 0),
                        LastUpdatedBy = c.String(maxLength: 100, unicode: false),
                        LastUpdatedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.PK);
            
            CreateTable(
                "dbo.university",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 5, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsActive = c.Boolean(storeType: "bit"),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        CreatedDate = c.DateTime(precision: 0),
                        LastUpdatedBy = c.String(maxLength: 100, unicode: false),
                        LastUpdatedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.PK);
            
            CreateTable(
                "dbo.candidateskill",
                c => new
                    {
                        PK = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        SkillId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        SinceLastUsed = c.DateTime(storeType: "date"),
                        IsPrimary = c.Boolean(storeType: "bit"),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.skill", t => t.SkillId)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId)
                .Index(t => t.SkillId);
            
            CreateTable(
                "dbo.skill",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 5, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsActive = c.Boolean(storeType: "bit"),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        CreatedDate = c.DateTime(precision: 0),
                        LastUpdatedBy = c.String(maxLength: 100, unicode: false),
                        LastUpdatedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.PK);
            
            CreateTable(
                "dbo.candidateworkexperience",
                c => new
                    {
                        PK = c.Int(nullable: false),
                        CandidateId = c.Int(nullable: false),
                        OrganizationName = c.String(maxLength: 300, unicode: false),
                        Designation = c.String(maxLength: 200, unicode: false),
                        Roles = c.String(maxLength: 1000, unicode: false),
                        StartDate = c.DateTime(precision: 0),
                        EndDate = c.DateTime(precision: 0),
                        LeavingReason = c.String(maxLength: 200, unicode: false),
                        IsActive = c.Boolean(storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.country",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 5, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsActive = c.Boolean(storeType: "bit"),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        CreatedDate = c.DateTime(precision: 0),
                        LastUpdatedBy = c.String(maxLength: 100, unicode: false),
                        LastUpdatedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.PK);
            
            CreateTable(
                "dbo.state",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 5, unicode: false),
                        Description = c.String(maxLength: 250, unicode: false),
                        IsActive = c.Boolean(storeType: "bit"),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        CreatedDate = c.DateTime(precision: 0),
                        LastUpdatedBy = c.String(maxLength: 100, unicode: false),
                        LastUpdatedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.PK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.candidateaddress", "AddressTypeId", "dbo.addresstype");
            DropForeignKey("dbo.candidateaddress", "StateId", "dbo.state");
            DropForeignKey("dbo.candidateaddress", "CountryId", "dbo.country");
            DropForeignKey("dbo.candidateworkexperience", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.candidateskill", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.candidateskill", "SkillId", "dbo.skill");
            DropForeignKey("dbo.candidateeducation", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.candidateeducation", "UniversityId", "dbo.university");
            DropForeignKey("dbo.candidateeducation", "PK", "dbo.college");
            DropForeignKey("dbo.candidateaddress", "CandidateId", "dbo.candidate");
            DropIndex("dbo.candidateworkexperience", new[] { "CandidateId" });
            DropIndex("dbo.candidateskill", new[] { "SkillId" });
            DropIndex("dbo.candidateskill", new[] { "CandidateId" });
            DropIndex("dbo.candidateeducation", new[] { "UniversityId" });
            DropIndex("dbo.candidateeducation", new[] { "CandidateId" });
            DropIndex("dbo.candidateeducation", new[] { "PK" });
            DropIndex("dbo.candidateaddress", new[] { "CountryId" });
            DropIndex("dbo.candidateaddress", new[] { "StateId" });
            DropIndex("dbo.candidateaddress", new[] { "AddressTypeId" });
            DropIndex("dbo.candidateaddress", new[] { "CandidateId" });
            DropTable("dbo.state");
            DropTable("dbo.country");
            DropTable("dbo.candidateworkexperience");
            DropTable("dbo.skill");
            DropTable("dbo.candidateskill");
            DropTable("dbo.university");
            DropTable("dbo.college");
            DropTable("dbo.candidateeducation");
            DropTable("dbo.candidate");
            DropTable("dbo.candidateaddress");
            DropTable("dbo.addresstype");
        }
    }
}