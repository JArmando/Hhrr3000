namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        Competences_Id = c.Guid(),
                        Languages_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.ResumeId)
                .ForeignKey("dbo.BasicCompetences", t => t.Competences_Id)
                .ForeignKey("dbo.Languages", t => t.Languages_Id)
                .Index(t => t.Competences_Id)
                .Index(t => t.Languages_Id);
            
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
                "dbo.JobOffers",
                c => new
                    {
                        JobOfferId = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        RiskLevel = c.String(nullable: false),
                        MinSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaxSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.JobOfferId);
            
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateId = c.Guid(nullable: false),
                        Resume_Id = c.Guid(),
                        ResumeId = c.Int(),
                    })
                .PrimaryKey(t => t.CandidateId)
                .ForeignKey("dbo.People", t => t.CandidateId)
                .ForeignKey("dbo.Resumes", t => t.Resume_Id)
                .Index(t => t.CandidateId)
                .Index(t => t.Resume_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Guid(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.People", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "EmployeeId", "dbo.People");
            DropForeignKey("dbo.Candidates", "Resume_Id", "dbo.Resumes");
            DropForeignKey("dbo.Candidates", "CandidateId", "dbo.People");
            DropForeignKey("dbo.Resumes", "Languages_Id", "dbo.Languages");
            DropForeignKey("dbo.Resumes", "Competences_Id", "dbo.BasicCompetences");
            DropIndex("dbo.Employees", new[] { "EmployeeId" });
            DropIndex("dbo.Candidates", new[] { "Resume_Id" });
            DropIndex("dbo.Candidates", new[] { "CandidateId" });
            DropIndex("dbo.Resumes", new[] { "Languages_Id" });
            DropIndex("dbo.Resumes", new[] { "Competences_Id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Candidates");
            DropTable("dbo.JobOffers");
            DropTable("dbo.AcademicCompetences");
            DropTable("dbo.Languages");
            DropTable("dbo.BasicCompetences");
            DropTable("dbo.Resumes");
            DropTable("dbo.People");
        }
    }
}
