namespace GatepassMonitoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfiguredDBCheckerBodegero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CheckerBodegeroes", "EmpID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CheckerBodegeroes", "EmpID");
        }
    }
}
