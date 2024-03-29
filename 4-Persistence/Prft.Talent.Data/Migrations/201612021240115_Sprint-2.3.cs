namespace Prft.Talent.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sprint23 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.backofficeinformation",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        CurrentCTC = c.Decimal(precision: 18, scale: 2),
                        VariablePay = c.Decimal(precision: 18, scale: 2),
                        LastIncrementedDate = c.DateTime(precision: 0),
                        Form16Verified = c.Boolean(),
                        ProjectDetails = c.String(maxLength: 255, unicode: false),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.candidate",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 100, unicode: false),
                        DOB = c.DateTime(nullable: false, precision: 0),
                        FatherName = c.String(maxLength: 100, unicode: false),
                        PermanentAddress = c.String(maxLength: 3000, unicode: false),
                        CommunicationAddress = c.String(maxLength: 3000, unicode: false),
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
                "dbo.candidatedocument",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        DocumentName = c.String(nullable: false, maxLength: 100, unicode: false),
                        DocumentType = c.String(nullable: false, maxLength: 45, unicode: false),
                        DocumentContent = c.Binary(nullable: false, storeType: "blob"),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.candidateeducation",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
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
                        Qualification = c.Int(),
                        CourseType = c.Int(),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.college", t => t.CollegeId)
                .ForeignKey("dbo.university", t => t.UniversityId)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId)
                .Index(t => t.CollegeId)
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
                "dbo.candidatefeedback",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        InterviewDate = c.DateTime(precision: 0),
                        InterviewerId = c.Int(),
                        DateOfInterview = c.DateTime(nullable: false, precision: 0),
                        ApppliedPosition = c.String(maxLength: 100, unicode: false),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.evaluation",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        CandidateFeedbackId = c.Int(nullable: false),
                        EvaluationSkillId = c.Int(nullable: false),
                        Rating = c.Int(),
                        EvaluationComments = c.String(maxLength: 500, unicode: false),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.skillevaluation", t => t.EvaluationSkillId)
                .ForeignKey("dbo.candidatefeedback", t => t.CandidateFeedbackId)
                .Index(t => t.CandidateFeedbackId)
                .Index(t => t.EvaluationSkillId);
            
            CreateTable(
                "dbo.skillevaluation",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        EvaluationSkillName = c.String(maxLength: 200, unicode: false),
                        EvaluationSkillDescription = c.String(maxLength: 500, unicode: false),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK);
            
            CreateTable(
                "dbo.candidateskill",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
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
                "dbo.interviewer",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        InterviewerName = c.String(maxLength: 100, unicode: false),
                        InterviewerEmail = c.String(maxLength: 100, unicode: false),
                        InterviewerPhone = c.String(maxLength: 45, unicode: false),
                        SkillId = c.Int(),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.skill", t => t.SkillId)
                .Index(t => t.SkillId);
            
            CreateTable(
                "dbo.interviewschedule",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        ScheduleDate = c.DateTime(storeType: "date"),
                        ScheduleTime = c.Time(precision: 0),
                        InterviewerId = c.Int(nullable: false),
                        LevelId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK)
                .ForeignKey("dbo.interviewlevel", t => t.LevelId)
                .ForeignKey("dbo.interviewer", t => t.InterviewerId)
                .ForeignKey("dbo.candidate", t => t.CandidateId)
                .Index(t => t.CandidateId)
                .Index(t => t.InterviewerId)
                .Index(t => t.LevelId);
            
            CreateTable(
                "dbo.interviewlevel",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        InterviewLevelName = c.String(maxLength: 100, unicode: false),
                        IsActive = c.Boolean(nullable: false, storeType: "bit"),
                        CreatedDate = c.DateTime(precision: 0),
                        CreatedBy = c.String(maxLength: 100, unicode: false),
                        ModifiedDate = c.DateTime(precision: 0),
                        ModifiedBy = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PK);
            
            CreateTable(
                "dbo.candidateworkexperience",
                c => new
                    {
                        PK = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        OrganizationName = c.String(maxLength: 300, unicode: false),
                        OrganizationAddress = c.String(maxLength: 250, unicode: false),
                        Designation = c.String(maxLength: 200, unicode: false),
                        StartDate = c.DateTime(precision: 0),
                        EndDate = c.DateTime(precision: 0),
                        LeavingReason = c.String(maxLength: 200, unicode: false),
                        ContactPerson = c.String(maxLength: 200, unicode: false),
                        ContactNumber = c.String(maxLength: 45, unicode: false),
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
            DropForeignKey("dbo.interviewschedule", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.candidateworkexperience", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.candidateskill", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.interviewer", "SkillId", "dbo.skill");
            DropForeignKey("dbo.interviewschedule", "InterviewerId", "dbo.interviewer");
            DropForeignKey("dbo.interviewschedule", "LevelId", "dbo.interviewlevel");
            DropForeignKey("dbo.candidateskill", "SkillId", "dbo.skill");
            DropForeignKey("dbo.candidatefeedback", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.evaluation", "CandidateFeedbackId", "dbo.candidatefeedback");
            DropForeignKey("dbo.evaluation", "EvaluationSkillId", "dbo.skillevaluation");
            DropForeignKey("dbo.candidateeducation", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.candidateeducation", "UniversityId", "dbo.university");
            DropForeignKey("dbo.candidateeducation", "CollegeId", "dbo.college");
            DropForeignKey("dbo.candidatedocument", "CandidateId", "dbo.candidate");
            DropForeignKey("dbo.backofficeinformation", "CandidateId", "dbo.candidate");
            DropIndex("dbo.candidateworkexperience", new[] { "CandidateId" });
            DropIndex("dbo.interviewschedule", new[] { "LevelId" });
            DropIndex("dbo.interviewschedule", new[] { "InterviewerId" });
            DropIndex("dbo.interviewschedule", new[] { "CandidateId" });
            DropIndex("dbo.interviewer", new[] { "SkillId" });
            DropIndex("dbo.candidateskill", new[] { "SkillId" });
            DropIndex("dbo.candidateskill", new[] { "CandidateId" });
            DropIndex("dbo.evaluation", new[] { "EvaluationSkillId" });
            DropIndex("dbo.evaluation", new[] { "CandidateFeedbackId" });
            DropIndex("dbo.candidatefeedback", new[] { "CandidateId" });
            DropIndex("dbo.candidateeducation", new[] { "UniversityId" });
            DropIndex("dbo.candidateeducation", new[] { "CollegeId" });
            DropIndex("dbo.candidateeducation", new[] { "CandidateId" });
            DropIndex("dbo.candidatedocument", new[] { "CandidateId" });
            DropIndex("dbo.backofficeinformation", new[] { "CandidateId" });
            DropTable("dbo.state");
            DropTable("dbo.country");
            DropTable("dbo.candidateworkexperience");
            DropTable("dbo.interviewlevel");
            DropTable("dbo.interviewschedule");
            DropTable("dbo.interviewer");
            DropTable("dbo.skill");
            DropTable("dbo.candidateskill");
            DropTable("dbo.skillevaluation");
            DropTable("dbo.evaluation");
            DropTable("dbo.candidatefeedback");
            DropTable("dbo.university");
            DropTable("dbo.college");
            DropTable("dbo.candidateeducation");
            DropTable("dbo.candidatedocument");
            DropTable("dbo.candidate");
            DropTable("dbo.backofficeinformation");
        }
    }
}
