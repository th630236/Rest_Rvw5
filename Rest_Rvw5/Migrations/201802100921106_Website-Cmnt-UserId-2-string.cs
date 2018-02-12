namespace Rest_Rvw5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebsiteCmntUserId2string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WebSiteComments", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WebSiteComments", "UserId", c => c.Int(nullable: false));
        }
    }
}
