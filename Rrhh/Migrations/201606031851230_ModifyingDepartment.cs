namespace Rrhh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyingDepartment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Description", c => c.String());
            AlterColumn("dbo.Departments", "Name", c => c.String());
        }
    }
}
