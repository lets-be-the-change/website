namespace LbtcWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Event", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Event", "Image", c => c.Binary(nullable: false));
        }
    }
}
