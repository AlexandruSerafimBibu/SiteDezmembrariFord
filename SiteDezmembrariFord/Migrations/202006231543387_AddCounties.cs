namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCounties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "CountiesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "CountiesId");
            AddForeignKey("dbo.Posts", "CountiesId", "dbo.Counties", "Id", cascadeDelete: true);
            DropColumn("dbo.Posts", "CityName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "CityName", c => c.String(nullable: false, maxLength: 30));
            DropForeignKey("dbo.Posts", "CountiesId", "dbo.Counties");
            DropIndex("dbo.Posts", new[] { "CountiesId" });
            DropColumn("dbo.Posts", "CountiesId");
        }
    }
}
