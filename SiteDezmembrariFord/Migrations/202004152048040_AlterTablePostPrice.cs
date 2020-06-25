namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTablePostPrice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Pret", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Pret", c => c.Int(nullable: false));
        }
    }
}
