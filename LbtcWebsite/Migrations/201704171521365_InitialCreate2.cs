namespace LbtcWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Event", "EventName", c => c.String(nullable: false));
            AlterColumn("dbo.Event", "EventDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Event", "Image", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Event", "Image", c => c.Binary());
            AlterColumn("dbo.Event", "EventDescription", c => c.String());
            AlterColumn("dbo.Event", "EventName", c => c.String());
        }
    }
}
