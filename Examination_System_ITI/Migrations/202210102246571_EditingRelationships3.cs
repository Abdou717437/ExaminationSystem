namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditingRelationships3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Correct_Answer", "Question_Id", "dbo.Question_Bank");
            DropIndex("dbo.Correct_Answer", new[] { "Question_Id" });
            AddColumn("dbo.Question_Bank", "Correct_Answer", c => c.String());
            DropTable("dbo.Correct_Answer");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Correct_Answer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Question_Bank", "Correct_Answer");
            CreateIndex("dbo.Correct_Answer", "Question_Id");
            AddForeignKey("dbo.Correct_Answer", "Question_Id", "dbo.Question_Bank", "Id");
        }
    }
}
