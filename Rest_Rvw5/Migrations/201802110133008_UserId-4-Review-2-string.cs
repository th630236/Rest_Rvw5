namespace Rest_Rvw5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserId4Review2string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "UserId", c => c.Int(nullable: false));
        }
    }
}
