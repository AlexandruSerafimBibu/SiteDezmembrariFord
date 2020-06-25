namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostCityNameObligatoriu : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "CityName", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "CityName", c => c.String(maxLength: 30));
        }
    }
}
