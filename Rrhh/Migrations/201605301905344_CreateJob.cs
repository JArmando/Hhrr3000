namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateJob : DbMigration
    {
        public override void Up()
        {
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
                        Department_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.JobId)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Candidates", "JobOfferAspiration_Id", c => c.Guid());
            AddColumn("dbo.Employees", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Employees", "JobId", c => c.Guid(nullable: false));
            AddColumn("dbo.WorkExperiences", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.JobOffers", "JobId", c => c.Guid(nullable: false));
            AddColumn("dbo.JobOffers", "Department_Id", c => c.Guid());
            CreateIndex("dbo.JobOffers", "JobId");
            CreateIndex("dbo.JobOffers", "Department_Id");
            CreateIndex("dbo.Candidates", "JobOfferAspiration_Id");
            CreateIndex("dbo.Employees", "JobId");
            AddForeignKey("dbo.JobOffers", "Department_Id", "dbo.Departments", "Id");
            AddForeignKey("dbo.JobOffers", "JobId", "dbo.Jobs", "JobId", cascadeDelete: true);
            AddForeignKey("dbo.Candidates", "JobOfferAspiration_Id", "dbo.JobOffers", "JobOfferId");
            AddForeignKey("dbo.Employees", "JobId", "dbo.Jobs", "JobId", cascadeDelete: true);
            DropColumn("dbo.JobOffers", "Name");
            DropColumn("dbo.JobOffers", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.JobOffers", "Description", c => c.String(nullable: false));
            AddColumn("dbo.JobOffers", "Name", c => c.String(nullable: false));
            DropForeignKey("dbo.Employees", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.Candidates", "JobOfferAspiration_Id", "dbo.JobOffers");
            DropForeignKey("dbo.JobOffers", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.Jobs", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.JobOffers", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "JobId" });
            DropIndex("dbo.Candidates", new[] { "JobOfferAspiration_Id" });
            DropIndex("dbo.Jobs", new[] { "Department_Id" });
            DropIndex("dbo.JobOffers", new[] { "Department_Id" });
            DropIndex("dbo.JobOffers", new[] { "JobId" });
            DropColumn("dbo.JobOffers", "Department_Id");
            DropColumn("dbo.JobOffers", "JobId");
            DropColumn("dbo.WorkExperiences", "Salary");
            DropColumn("dbo.Employees", "JobId");
            DropColumn("dbo.Employees", "Salary");
            DropColumn("dbo.Candidates", "JobOfferAspiration_Id");
            DropTable("dbo.Departments");
            DropTable("dbo.Jobs");
        }
    }
}
