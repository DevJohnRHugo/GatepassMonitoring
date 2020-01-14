namespace GatepassMonitoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfiguredDBGatepass2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gatepasses", "QuantityLong", c => c.Int());
            AlterColumn("dbo.Gatepasses", "QuantityShort", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gatepasses", "QuantityShort", c => c.Int(nullable: false));
            AlterColumn("dbo.Gatepasses", "QuantityLong", c => c.Int(nullable: false));
        }
    }
}
