namespace CalendarApp.DbModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relations_init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        PlaceId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PlaceId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Phonenumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserEvents",
                c => new
                    {
                        User_UserId = c.Int(nullable: false),
                        Event_EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserId, t.Event_EventId })
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_EventId, cascadeDelete: true)
                .Index(t => t.User_UserId)
                .Index(t => t.Event_EventId);
            
            AddColumn("dbo.Events", "Client_ClientId", c => c.Int());
            AddColumn("dbo.Events", "Place_PlaceId", c => c.Int());
            CreateIndex("dbo.Events", "Client_ClientId");
            CreateIndex("dbo.Events", "Place_PlaceId");
            AddForeignKey("dbo.Events", "Client_ClientId", "dbo.Clients", "ClientId");
            AddForeignKey("dbo.Events", "Place_PlaceId", "dbo.Places", "PlaceId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserEvents", "Event_EventId", "dbo.Events");
            DropForeignKey("dbo.UserEvents", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Events", "Place_PlaceId", "dbo.Places");
            DropForeignKey("dbo.Events", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.UserEvents", new[] { "Event_EventId" });
            DropIndex("dbo.UserEvents", new[] { "User_UserId" });
            DropIndex("dbo.Events", new[] { "Place_PlaceId" });
            DropIndex("dbo.Events", new[] { "Client_ClientId" });
            DropColumn("dbo.Events", "Place_PlaceId");
            DropColumn("dbo.Events", "Client_ClientId");
            DropTable("dbo.UserEvents");
            DropTable("dbo.Users");
            DropTable("dbo.Places");
            DropTable("dbo.Clients");
        }
    }
}
