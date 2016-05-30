namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelateCompetencesToResume : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Resumes", "Competences_Id", "dbo.BasicCompetences");
            DropForeignKey("dbo.Resumes", "Languages_Id", "dbo.Languages");
            DropForeignKey("dbo.Resumes", "WorkExperiences_Id", "dbo.WorkExperiences");
            DropIndex("dbo.Resumes", new[] { "Competences_Id" });
            DropIndex("dbo.Resumes", new[] { "Languages_Id" });
            DropIndex("dbo.Resumes", new[] { "WorkExperiences_Id" });
            CreateTable(
                "dbo.ResumeBasicCompetences",
                c => new
                    {
                        Resume_Id = c.Guid(nullable: false),
                        BasicCompetence_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Resume_Id, t.BasicCompetence_Id })
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .ForeignKey("dbo.BasicCompetences", t => t.BasicCompetence_Id, cascadeDelete: true)
                .Index(t => t.Resume_Id)
                .Index(t => t.BasicCompetence_Id);
            
            CreateTable(
                "dbo.ResumeLanguages",
                c => new
                    {
                        Resume_Id = c.Guid(nullable: false),
                        Language_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Resume_Id, t.Language_Id })
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .ForeignKey("dbo.Languages", t => t.Language_Id, cascadeDelete: true)
                .Index(t => t.Resume_Id)
                .Index(t => t.Language_Id);
            
            CreateTable(
                "dbo.ResumeWorkExperiences",
                c => new
                    {
                        Resume_Id = c.Guid(nullable: false),
                        WorkExperience_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Resume_Id, t.WorkExperience_Id })
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .ForeignKey("dbo.WorkExperiences", t => t.WorkExperience_Id, cascadeDelete: true)
                .Index(t => t.Resume_Id)
                .Index(t => t.WorkExperience_Id);
            
            DropColumn("dbo.Resumes", "Competences_Id");
            DropColumn("dbo.Resumes", "Languages_Id");
            DropColumn("dbo.Resumes", "WorkExperiences_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Resumes", "WorkExperiences_Id", c => c.Guid());
            AddColumn("dbo.Resumes", "Languages_Id", c => c.Guid());
            AddColumn("dbo.Resumes", "Competences_Id", c => c.Guid());
            DropForeignKey("dbo.ResumeWorkExperiences", "WorkExperience_Id", "dbo.WorkExperiences");
            DropForeignKey("dbo.ResumeWorkExperiences", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.ResumeLanguages", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.ResumeLanguages", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.ResumeBasicCompetences", "BasicCompetence_Id", "dbo.BasicCompetences");
            DropForeignKey("dbo.ResumeBasicCompetences", "Resume_Id", "dbo.Resumes");
            DropIndex("dbo.ResumeWorkExperiences", new[] { "WorkExperience_Id" });
            DropIndex("dbo.ResumeWorkExperiences", new[] { "Resume_Id" });
            DropIndex("dbo.ResumeLanguages", new[] { "Language_Id" });
            DropIndex("dbo.ResumeLanguages", new[] { "Resume_Id" });
            DropIndex("dbo.ResumeBasicCompetences", new[] { "BasicCompetence_Id" });
            DropIndex("dbo.ResumeBasicCompetences", new[] { "Resume_Id" });
            DropTable("dbo.ResumeWorkExperiences");
            DropTable("dbo.ResumeLanguages");
            DropTable("dbo.ResumeBasicCompetences");
            CreateIndex("dbo.Resumes", "WorkExperiences_Id");
            CreateIndex("dbo.Resumes", "Languages_Id");
            CreateIndex("dbo.Resumes", "Competences_Id");
            AddForeignKey("dbo.Resumes", "WorkExperiences_Id", "dbo.WorkExperiences", "Id");
            AddForeignKey("dbo.Resumes", "Languages_Id", "dbo.Languages", "LanguageId");
            AddForeignKey("dbo.Resumes", "Competences_Id", "dbo.BasicCompetences", "CompetenceId");
        }
    }
}
