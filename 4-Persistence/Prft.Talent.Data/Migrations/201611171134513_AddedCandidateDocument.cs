namespace Prft.Talent.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCandidateDocument : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.candidatedocument", "CandidateId", "dbo.candidate");
            DropIndex("dbo.candidatedocument", new[] { "CandidateId" });
            DropTable("dbo.candidatedocument");
        }
    }
}
