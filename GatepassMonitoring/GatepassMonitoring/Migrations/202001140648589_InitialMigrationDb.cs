namespace GatepassMonitoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrationDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gatepasses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CheckerBodegeroId = c.Byte(nullable: false),
                        ProjectId = c.Byte(nullable: false),
                        GatePassHalf = c.String(),
                        GatePassLong = c.String(),
                        PickUp = c.String(),
                        QuantityLong = c.Int(nullable: false),
                        QuantityShort = c.Int(nullable: false),
                        Remarks = c.String(),
                        CheckerBodegero_ID = c.Int(),
                        Project_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CheckerBodegeroes", t => t.CheckerBodegero_ID)
                .ForeignKey("dbo.Projects", t => t.Project_ID)
                .Index(t => t.CheckerBodegero_ID)
                .Index(t => t.Project_ID);
            
            CreateTable(
                "dbo.CheckerBodegeroes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        District = c.String(),
                        Locale = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Gatepasses", new[] { "Project_ID" });
            DropIndex("dbo.Gatepasses", new[] { "CheckerBodegero_ID" });
            DropForeignKey("dbo.Gatepasses", "Project_ID", "dbo.Projects");
            DropForeignKey("dbo.Gatepasses", "CheckerBodegero_ID", "dbo.CheckerBodegeroes");
            DropTable("dbo.Projects");
            DropTable("dbo.CheckerBodegeroes");
            DropTable("dbo.Gatepasses");
        }
    }
}
