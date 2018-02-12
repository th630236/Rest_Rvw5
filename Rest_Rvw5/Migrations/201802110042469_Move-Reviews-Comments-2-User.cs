namespace Rest_Rvw5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoveReviewsComments2User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Pending = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Reviews");
            DropTable("dbo.WebSiteComments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WebSiteComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Date = c.DateTime(nullable: false),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RestaurantId = c.Int(nullable: false),
                        ReviewDate = c.DateTime(nullable: false),
                        ReviewTitle = c.String(),
                        OverallRating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Restaurants");
        }
    }
}
