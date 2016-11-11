namespace Prft.Talent.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "talent.addresstype",
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
                "talent.candidateaddress",
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
                .ForeignKey("talent.candidate", t => t.CandidateId)
                .ForeignKey("talent.country", t => t.CountryId)
                .ForeignKey("talent.state", t => t.StateId)
                .ForeignKey("talent.addresstype", t => t.AddressTypeId)
                .Index(t => t.CandidateId)
                .Index(t => t.AddressTypeId)
                .Index(t => t.StateId)
                .Index(t => t.CountryId);

            CreateTable(
                "talent.candidate",
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
                "talent.candidateeducation",
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
                .ForeignKey("talent.college", t => t.PK)
                .ForeignKey("talent.university", t => t.UniversityId)
                .ForeignKey("talent.candidate", t => t.CandidateId)
                .Index(t => t.PK)
                .Index(t => t.CandidateId)
                .Index(t => t.UniversityId);

            CreateTable(
                "talent.college",
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
                "talent.university",
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
                "talent.candidateskill",
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
                .ForeignKey("talent.skill", t => t.SkillId)
                .ForeignKey("talent.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId)
                .Index(t => t.SkillId);

            CreateTable(
                "talent.skill",
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
                "talent.candidateworkexperience",
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
                .ForeignKey("talent.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId);

            CreateTable(
                "talent.country",
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
                "talent.state",
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
            DropForeignKey("talent.candidateaddress", "AddressTypeId", "talent.addresstype");
            DropForeignKey("talent.candidateaddress", "StateId", "talent.state");
            DropForeignKey("talent.candidateaddress", "CountryId", "talent.country");
            DropForeignKey("talent.candidateworkexperience", "CandidateId", "talent.candidate");
            DropForeignKey("talent.candidateskill", "CandidateId", "talent.candidate");
            DropForeignKey("talent.candidateskill", "SkillId", "talent.skill");
            DropForeignKey("talent.candidateeducation", "CandidateId", "talent.candidate");
            DropForeignKey("talent.candidateeducation", "UniversityId", "talent.university");
            DropForeignKey("talent.candidateeducation", "PK", "talent.college");
            DropForeignKey("talent.candidateaddress", "CandidateId", "talent.candidate");
            DropIndex("talent.candidateworkexperience", new[] { "CandidateId" });
            DropIndex("talent.candidateskill", new[] { "SkillId" });
            DropIndex("talent.candidateskill", new[] { "CandidateId" });
            DropIndex("talent.candidateeducation", new[] { "UniversityId" });
            DropIndex("talent.candidateeducation", new[] { "CandidateId" });
            DropIndex("talent.candidateeducation", new[] { "PK" });
            DropIndex("talent.candidateaddress", new[] { "CountryId" });
            DropIndex("talent.candidateaddress", new[] { "StateId" });
            DropIndex("talent.candidateaddress", new[] { "AddressTypeId" });
            DropIndex("talent.candidateaddress", new[] { "CandidateId" });
            DropTable("talent.state");
            DropTable("talent.country");
            DropTable("talent.candidateworkexperience");
            DropTable("talent.skill");
            DropTable("talent.candidateskill");
            DropTable("talent.university");
            DropTable("talent.college");
            DropTable("talent.candidateeducation");
            DropTable("talent.candidate");
            DropTable("talent.candidateaddress");
            DropTable("talent.addresstype");
        }
    }
}
