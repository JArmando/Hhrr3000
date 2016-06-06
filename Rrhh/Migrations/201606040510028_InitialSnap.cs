namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSnap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        GovernmentIssuedId = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobOffers",
                c => new
                    {
                        JobOfferId = c.Guid(nullable: false, identity: true),
                        RiskLevel = c.String(nullable: false),
                        MinSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        JobId = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        Department_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.JobOfferId)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        JobId = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        Department_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.JobId)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        ResumeId = c.Guid(nullable: false, identity: true),
                        RecommendedById = c.Guid(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ResumeId)
                .ForeignKey("dbo.Employees", t => t.RecommendedById)
                .Index(t => t.RecommendedById);
            
            CreateTable(
                "dbo.BasicCompetences",
                c => new
                    {
                        CompetenceId = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CompetenceId);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        LanguageId = c.Guid(nullable: false, identity: true),
                        Level = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.LanguageId);
            
            CreateTable(
                "dbo.WorkExperiences",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        InstitutionName = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        JobPosition = c.String(),
                        Description = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AcademicCompetences",
                c => new
                    {
                        AcademicCompetenceId = c.Guid(nullable: false, identity: true),
                        Level = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(),
                        AcademicInstitution = c.String(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AcademicCompetenceId);
            
            CreateTable(
                "dbo.BasicCompetenceResumes",
                c => new
                    {
                        BasicCompetence_Id = c.Guid(nullable: false),
                        Resume_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.BasicCompetence_Id, t.Resume_Id })
                .ForeignKey("dbo.BasicCompetences", t => t.BasicCompetence_Id, cascadeDelete: true)
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .Index(t => t.BasicCompetence_Id)
                .Index(t => t.Resume_Id);
            
            CreateTable(
                "dbo.LanguageResumes",
                c => new
                    {
                        Language_Id = c.Guid(nullable: false),
                        Resume_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Language_Id, t.Resume_Id })
                .ForeignKey("dbo.Languages", t => t.Language_Id, cascadeDelete: true)
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .Index(t => t.Language_Id)
                .Index(t => t.Resume_Id);
            
            CreateTable(
                "dbo.WorkExperienceResumes",
                c => new
                    {
                        WorkExperience_Id = c.Guid(nullable: false),
                        Resume_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.WorkExperience_Id, t.Resume_Id })
                .ForeignKey("dbo.WorkExperiences", t => t.WorkExperience_Id, cascadeDelete: true)
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .Index(t => t.WorkExperience_Id)
                .Index(t => t.Resume_Id);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateId = c.Guid(nullable: false),
                        JobOfferAspiration_Id = c.Guid(),
                        Resume_Id = c.Guid(nullable: false),
                        ResumeId = c.Int(),
                        AspiringSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CandidateId)
                .ForeignKey("dbo.People", t => t.CandidateId)
                .ForeignKey("dbo.JobOffers", t => t.JobOfferAspiration_Id)
                .ForeignKey("dbo.Resumes", t => t.Resume_Id, cascadeDelete: true)
                .Index(t => t.CandidateId)
                .Index(t => t.JobOfferAspiration_Id)
                .Index(t => t.Resume_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Guid(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        JobId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.People", t => t.EmployeeId)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.JobId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.Employees", "EmployeeId", "dbo.People");
            DropForeignKey("dbo.Candidates", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.Candidates", "JobOfferAspiration_Id", "dbo.JobOffers");
            DropForeignKey("dbo.Candidates", "CandidateId", "dbo.People");
            DropForeignKey("dbo.WorkExperienceResumes", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.WorkExperienceResumes", "WorkExperience_Id", "dbo.WorkExperiences");
            DropForeignKey("dbo.Resumes", "RecommendedById", "dbo.Employees");
            DropForeignKey("dbo.LanguageResumes", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.LanguageResumes", "Language_Id", "dbo.Languages");
            DropForeignKey("dbo.BasicCompetenceResumes", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.BasicCompetenceResumes", "BasicCompetence_Id", "dbo.BasicCompetences");
            DropForeignKey("dbo.JobOffers", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.Jobs", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.JobOffers", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "JobId" });
            DropIndex("dbo.Employees", new[] { "EmployeeId" });
            DropIndex("dbo.Candidates", new[] { "Resume_Id" });
            DropIndex("dbo.Candidates", new[] { "JobOfferAspiration_Id" });
            DropIndex("dbo.Candidates", new[] { "CandidateId" });
            DropIndex("dbo.WorkExperienceResumes", new[] { "Resume_Id" });
            DropIndex("dbo.WorkExperienceResumes", new[] { "WorkExperience_Id" });
            DropIndex("dbo.LanguageResumes", new[] { "Resume_Id" });
            DropIndex("dbo.LanguageResumes", new[] { "Language_Id" });
            DropIndex("dbo.BasicCompetenceResumes", new[] { "Resume_Id" });
            DropIndex("dbo.BasicCompetenceResumes", new[] { "BasicCompetence_Id" });
            DropIndex("dbo.Resumes", new[] { "RecommendedById" });
            DropIndex("dbo.Jobs", new[] { "Department_Id" });
            DropIndex("dbo.JobOffers", new[] { "Department_Id" });
            DropIndex("dbo.JobOffers", new[] { "JobId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Candidates");
            DropTable("dbo.WorkExperienceResumes");
            DropTable("dbo.LanguageResumes");
            DropTable("dbo.BasicCompetenceResumes");
            DropTable("dbo.AcademicCompetences");
            DropTable("dbo.WorkExperiences");
            DropTable("dbo.Languages");
            DropTable("dbo.BasicCompetences");
            DropTable("dbo.Resumes");
            DropTable("dbo.Departments");
            DropTable("dbo.Jobs");
            DropTable("dbo.JobOffers");
            DropTable("dbo.People");
        }
    }
}
