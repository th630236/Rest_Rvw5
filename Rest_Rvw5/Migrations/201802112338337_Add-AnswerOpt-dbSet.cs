namespace Rest_Rvw5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnswerOptdbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnswerOpts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        Seq = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                        OptText = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnswerOpts", "QuestionId", "dbo.Questions");
            DropIndex("dbo.AnswerOpts", new[] { "QuestionId" });
            DropTable("dbo.AnswerOpts");
        }
    }
}
