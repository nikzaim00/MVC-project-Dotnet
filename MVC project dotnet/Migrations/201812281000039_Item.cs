namespace MVC_project_dotnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Item : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.String(nullable: false, maxLength: 128),
                        ItemName = c.String(maxLength: 100),
                        ItemDesc = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
