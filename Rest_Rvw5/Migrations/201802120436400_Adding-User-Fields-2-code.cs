namespace Rest_Rvw5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUserFields2code : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserSince", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserSince");
        }
    }
}
