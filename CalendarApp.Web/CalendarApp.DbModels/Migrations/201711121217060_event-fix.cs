namespace CalendarApp.DbModels.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class eventfix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "End", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "End", c => c.DateTime(nullable: false));
        }
    }
}
