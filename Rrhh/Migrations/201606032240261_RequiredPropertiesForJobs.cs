namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredPropertiesForJobs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jobs", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Jobs", new[] { "Department_Id" });
            AlterColumn("dbo.Jobs", "Department_Id", c => c.Guid(nullable: false));
            CreateIndex("dbo.Jobs", "Department_Id");
            AddForeignKey("dbo.Jobs", "Department_Id", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Jobs", new[] { "Department_Id" });
            AlterColumn("dbo.Jobs", "Department_Id", c => c.Guid());
            CreateIndex("dbo.Jobs", "Department_Id");
            AddForeignKey("dbo.Jobs", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
