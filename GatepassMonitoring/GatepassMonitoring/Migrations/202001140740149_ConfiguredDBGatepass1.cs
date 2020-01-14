namespace GatepassMonitoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfiguredDBGatepass1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gatepasses", "DateIssued", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gatepasses", "DateIssued");
        }
    }
}
