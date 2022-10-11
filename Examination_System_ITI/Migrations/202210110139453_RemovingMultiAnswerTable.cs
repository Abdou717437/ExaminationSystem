namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingMultiAnswerTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Multi_Answer", "Student_Answer_Id", "dbo.Student_Answer");
            DropIndex("dbo.Multi_Answer", new[] { "Student_Answer_Id" });
            AddColumn("dbo.Student_Answer", "Answer", c => c.String());
            DropTable("dbo.Multi_Answer");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Multi_Answer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        Student_Answer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Student_Answer", "Answer");
            CreateIndex("dbo.Multi_Answer", "Student_Answer_Id");
            AddForeignKey("dbo.Multi_Answer", "Student_Answer_Id", "dbo.Student_Answer", "Id");
        }
    }
}
