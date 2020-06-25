namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyNameLengthSubCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SubCategories", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubCategories", "Name", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
