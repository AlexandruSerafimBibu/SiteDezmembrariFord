namespace SiteDezmembrariFord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShowHideUserPhoneNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ShowPhoneNumber", c => c.Byte());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ShowPhoneNumber");
        }
    }
}
