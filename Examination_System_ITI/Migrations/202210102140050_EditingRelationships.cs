namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditingRelationships : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Question_Option", new[] { "Question_Id" });
            RenameColumn(table: "dbo.Question_Option", name: "Question_Id", newName: "QuestionId");
            DropPrimaryKey("dbo.Question_Option");
            AlterColumn("dbo.Question_Option", "QuestionId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Question_Option", "QuestionId");
            CreateIndex("dbo.Question_Option", "QuestionId");
            DropColumn("dbo.Question_Option", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Question_Option", "Id", c => c.Int(nullable: false, identity: true));
            DropIndex("dbo.Question_Option", new[] { "QuestionId" });
            DropPrimaryKey("dbo.Question_Option");
            AlterColumn("dbo.Question_Option", "QuestionId", c => c.Int());
            AddPrimaryKey("dbo.Question_Option", "Id");
            RenameColumn(table: "dbo.Question_Option", name: "QuestionId", newName: "Question_Id");
            CreateIndex("dbo.Question_Option", "Question_Id");
        }
    }
}
