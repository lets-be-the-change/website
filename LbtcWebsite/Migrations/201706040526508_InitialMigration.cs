namespace LbtcWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        EventName = c.String(nullable: false, unicode: false),
                        EventDescription = c.String(nullable: false, unicode: false),
                        Image = c.Binary(),
                        EventDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Event");
        }
    }
}
