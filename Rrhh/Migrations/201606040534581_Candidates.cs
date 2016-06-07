namespace Rrhh.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Candidates : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Candidates", name: "JobOfferAspiration_Id", newName: "JobOfferAspirationId");
            RenameIndex(table: "dbo.Candidates", name: "IX_JobOfferAspiration_Id", newName: "IX_JobOfferAspirationId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Candidates", name: "IX_JobOfferAspirationId", newName: "IX_JobOfferAspiration_Id");
            RenameColumn(table: "dbo.Candidates", name: "JobOfferAspirationId", newName: "JobOfferAspiration_Id");
        }
    }
}
