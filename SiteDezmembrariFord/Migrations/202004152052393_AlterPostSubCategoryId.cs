namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterPostSubCategoryId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "SubCategoryId", "dbo.SubCategories");
            DropIndex("dbo.Posts", new[] { "SubCategoryId" });
            AlterColumn("dbo.Posts", "SubCategoryId", c => c.Int());
            CreateIndex("dbo.Posts", "SubCategoryId");
            AddForeignKey("dbo.Posts", "SubCategoryId", "dbo.SubCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "SubCategoryId", "dbo.SubCategories");
            DropIndex("dbo.Posts", new[] { "SubCategoryId" });
            AlterColumn("dbo.Posts", "SubCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "SubCategoryId");
            AddForeignKey("dbo.Posts", "SubCategoryId", "dbo.SubCategories", "Id", cascadeDelete: true);
        }
    }
}
