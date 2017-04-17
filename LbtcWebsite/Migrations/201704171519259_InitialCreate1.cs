namespace LbtcWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Event", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Event", "Image");
        }
    }
}
