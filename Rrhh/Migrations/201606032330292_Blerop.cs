namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Blerop : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Candidates", "Resume_Id", "dbo.Resumes");
            DropIndex("dbo.Candidates", new[] { "Resume_Id" });
            AlterColumn("dbo.Candidates", "Resume_Id", c => c.Guid(nullable: false));
            CreateIndex("dbo.Candidates", "Resume_Id");
            AddForeignKey("dbo.Candidates", "Resume_Id", "dbo.Resumes", "ResumeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidates", "Resume_Id", "dbo.Resumes");
            DropIndex("dbo.Candidates", new[] { "Resume_Id" });
            AlterColumn("dbo.Candidates", "Resume_Id", c => c.Guid());
            CreateIndex("dbo.Candidates", "Resume_Id");
            AddForeignKey("dbo.Candidates", "Resume_Id", "dbo.Resumes", "ResumeId");
        }
    }
}
