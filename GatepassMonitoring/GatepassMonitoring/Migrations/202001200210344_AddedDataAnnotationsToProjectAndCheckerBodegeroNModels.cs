namespace GatepassMonitoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotationsToProjectAndCheckerBodegeroNModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckerBodegeroes", "Designation", c => c.String(nullable: false));
            AlterColumn("dbo.CheckerBodegeroes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "District", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "Locale", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Locale", c => c.String());
            AlterColumn("dbo.Projects", "District", c => c.String());
            AlterColumn("dbo.CheckerBodegeroes", "Name", c => c.String());
            AlterColumn("dbo.CheckerBodegeroes", "Designation", c => c.String());
        }
    }
}
