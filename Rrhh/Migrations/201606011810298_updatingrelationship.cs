namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingrelationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ResumeLanguages", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.ResumeLanguages", "Language_Id", "dbo.Languages");
            DropIndex("dbo.ResumeLanguages", new[] { "Resume_Id" });
            DropIndex("dbo.ResumeLanguages", new[] { "Language_Id" });
            AddColumn("dbo.Languages", "Resume_Id", c => c.Guid());
            CreateIndex("dbo.Languages", "Resume_Id");
            AddForeignKey("dbo.Languages", "Resume_Id", "dbo.Resumes", "ResumeId");
            DropTable("dbo.ResumeLanguages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ResumeLanguages",
                c => new
                    {
                        Resume_Id = c.Guid(nullable: false),
                        Language_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Resume_Id, t.Language_Id });
            
            DropForeignKey("dbo.Languages", "Resume_Id", "dbo.Resumes");
            DropIndex("dbo.Languages", new[] { "Resume_Id" });
            DropColumn("dbo.Languages", "Resume_Id");
            CreateIndex("dbo.ResumeLanguages", "Language_Id");
            CreateIndex("dbo.ResumeLanguages", "Resume_Id");
            AddForeignKey("dbo.ResumeLanguages", "Language_Id", "dbo.Languages", "LanguageId", cascadeDelete: true);
            AddForeignKey("dbo.ResumeLanguages", "Resume_Id", "dbo.Resumes", "ResumeId", cascadeDelete: true);
        }
    }
}
