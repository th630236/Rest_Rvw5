namespace Rest_Rvw5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnswer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        ReviewId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        Response = c.Int(),
                        AnswerText = c.String(),
                    })
                .PrimaryKey(t => new { t.ReviewId, t.QuestionId });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Answers");
        }
    }
}
