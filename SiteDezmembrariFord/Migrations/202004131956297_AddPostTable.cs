namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 255),
                        Date = c.DateTime(nullable: false),
                        CityName = c.String(maxLength: 30),
                        PostType = c.Boolean(nullable: false),
                        Pret = c.Int(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.SubCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Posts", "SubCategoryId", "dbo.SubCategories");
            DropIndex("dbo.Posts", new[] { "SubCategoryId" });
            DropIndex("dbo.Posts", new[] { "UserId" });
            DropTable("dbo.Posts");
        }
    }
}
