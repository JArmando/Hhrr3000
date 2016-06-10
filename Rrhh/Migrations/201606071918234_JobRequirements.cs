namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobRequirements : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Candidates", "JobOfferAspirationId", "dbo.JobOffers");
            DropIndex("dbo.Candidates", new[] { "JobOfferAspirationId" });
            AlterColumn("dbo.Candidates", "JobOfferAspirationId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Candidates", "JobOfferAspirationId");
            AddForeignKey("dbo.Candidates", "JobOfferAspirationId", "dbo.JobOffers", "JobOfferId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidates", "JobOfferAspirationId", "dbo.JobOffers");
            DropIndex("dbo.Candidates", new[] { "JobOfferAspirationId" });
            AlterColumn("dbo.Candidates", "JobOfferAspirationId", c => c.Guid());
            CreateIndex("dbo.Candidates", "JobOfferAspirationId");
            AddForeignKey("dbo.Candidates", "JobOfferAspirationId", "dbo.JobOffers", "JobOfferId");
        }
    }
}
