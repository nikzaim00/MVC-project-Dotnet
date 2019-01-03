namespace MVC_project_dotnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedtableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetRoles", newName: "TSNRoles");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "TSNUserRoles");
            RenameTable(name: "dbo.AspNetUsers", newName: "TSNUsers");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "TSNUserClaims");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "TSNUserLogins");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TSNUserLogins", newName: "AspNetUserLogins");
            RenameTable(name: "dbo.TSNUserClaims", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.TSNUsers", newName: "AspNetUsers");
            RenameTable(name: "dbo.TSNUserRoles", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.TSNRoles", newName: "AspNetRoles");
        }
    }
}
