namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ASPNETROLES VALUES (1, 'Admin')");
            Sql("INSERT INTO ASPNETROLES VALUES (2, 'User')");
        }
        
        public override void Down()
        {
        }
    }
}
