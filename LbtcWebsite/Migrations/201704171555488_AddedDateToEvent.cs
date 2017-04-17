namespace LbtcWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateToEvent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Event", "EventDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Event", "EventDate");
        }
    }
}
