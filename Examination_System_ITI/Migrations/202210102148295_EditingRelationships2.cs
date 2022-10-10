namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditingRelationships2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Question_Bank", "Exam_Question_Id", "dbo.Exam_Question");
            DropIndex("dbo.Question_Bank", new[] { "Exam_Question_Id" });
            AddColumn("dbo.Exam_Question", "Question_Bank_Id", c => c.Int());
            CreateIndex("dbo.Exam_Question", "Question_Bank_Id");
            AddForeignKey("dbo.Exam_Question", "Question_Bank_Id", "dbo.Question_Bank", "Id");
            DropColumn("dbo.Question_Bank", "Exam_Question_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Question_Bank", "Exam_Question_Id", c => c.Int());
            DropForeignKey("dbo.Exam_Question", "Question_Bank_Id", "dbo.Question_Bank");
            DropIndex("dbo.Exam_Question", new[] { "Question_Bank_Id" });
            DropColumn("dbo.Exam_Question", "Question_Bank_Id");
            CreateIndex("dbo.Question_Bank", "Exam_Question_Id");
            AddForeignKey("dbo.Question_Bank", "Exam_Question_Id", "dbo.Exam_Question", "Id");
        }
    }
}
