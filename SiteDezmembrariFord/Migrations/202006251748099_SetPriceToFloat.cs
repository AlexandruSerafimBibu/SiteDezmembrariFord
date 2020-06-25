namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetPriceToFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Pret", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Pret", c => c.Int());
        }
    }
}
