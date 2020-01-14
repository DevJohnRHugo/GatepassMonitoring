namespace GatepassMonitoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfiguredDBGatepass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gatepasses", "GatePassHalf", c => c.String(maxLength: 255));
            AlterColumn("dbo.Gatepasses", "GatePassLong", c => c.String(maxLength: 255));
            AlterColumn("dbo.Gatepasses", "PickUp", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gatepasses", "PickUp", c => c.String());
            AlterColumn("dbo.Gatepasses", "GatePassLong", c => c.String());
            AlterColumn("dbo.Gatepasses", "GatePassHalf", c => c.String());
        }
    }
}
