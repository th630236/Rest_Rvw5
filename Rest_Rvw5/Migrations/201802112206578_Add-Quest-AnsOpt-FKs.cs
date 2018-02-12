namespace Rest_Rvw5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestAnsOptFKs : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.Reviews");
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        QuestionNum = c.Int(nullable: false),
                        QuestionType = c.Int(nullable: false),
                        QuestionText = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId);
            
            AddColumn("dbo.Reviews", "ReviewId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Reviews", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.WebSiteComments", "UserId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Reviews", "ReviewId");
            CreateIndex("dbo.Answers", "ReviewId");
            CreateIndex("dbo.Answers", "QuestionId");
            CreateIndex("dbo.Reviews", "UserId");
            CreateIndex("dbo.Reviews", "RestaurantId");
            CreateIndex("dbo.WebSiteComments", "UserId");
            AddForeignKey("dbo.Answers", "QuestionId", "dbo.Questions", "QuestionId", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Answers", "ReviewId", "dbo.Reviews", "ReviewId", cascadeDelete: true);
            AddForeignKey("dbo.WebSiteComments", "UserId", "dbo.AspNetUsers", "Id");
            //DropColumn("dbo.Reviews", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.WebSiteComments", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Answers", "ReviewId", "dbo.Reviews");
            DropForeignKey("dbo.Reviews", "RestaurantId", "dbo.Restaurants");
            DropForeignKey("dbo.Reviews", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.WebSiteComments", new[] { "UserId" });
            DropIndex("dbo.Reviews", new[] { "RestaurantId" });
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropIndex("dbo.Answers", new[] { "ReviewId" });
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.WebSiteComments", "UserId", c => c.String());
            AlterColumn("dbo.Reviews", "UserId", c => c.String());
            DropColumn("dbo.Reviews", "ReviewId");
            DropTable("dbo.Questions");
            AddPrimaryKey("dbo.Reviews", "Id");
        }
    }
}
