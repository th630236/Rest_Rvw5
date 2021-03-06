namespace Rest_Rvw5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRestaurant : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        RestaurantId = c.Int(nullable: false),
                        ReviewDate = c.DateTime(nullable: false),
                        ReviewTitle = c.String(),
                        OverallRating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
        }
    }
}
