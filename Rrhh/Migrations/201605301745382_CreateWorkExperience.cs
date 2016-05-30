namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateWorkExperience : DbMigration
    {
        public override void Up()
        {
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
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Candidates", "AspiringSalary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.People", "GovernmentIssuedId", c => c.String());
            AddColumn("dbo.Resumes", "RecommendedById", c => c.Guid());
            AddColumn("dbo.Resumes", "WorkExperiences_Id", c => c.Guid());
            CreateIndex("dbo.Resumes", "RecommendedById");
            CreateIndex("dbo.Resumes", "WorkExperiences_Id");
            AddForeignKey("dbo.Resumes", "RecommendedById", "dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.Resumes", "WorkExperiences_Id", "dbo.WorkExperiences", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resumes", "WorkExperiences_Id", "dbo.WorkExperiences");
            DropForeignKey("dbo.Resumes", "RecommendedById", "dbo.Employees");
            DropIndex("dbo.Resumes", new[] { "WorkExperiences_Id" });
            DropIndex("dbo.Resumes", new[] { "RecommendedById" });
            DropColumn("dbo.Resumes", "WorkExperiences_Id");
            DropColumn("dbo.Resumes", "RecommendedById");
            DropColumn("dbo.People", "GovernmentIssuedId");
            DropColumn("dbo.Candidates", "AspiringSalary");
            DropTable("dbo.WorkExperiences");
        }
    }
}
