namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TrackBranches", "Track_Id", "dbo.Track");
            DropForeignKey("dbo.TrackBranches", "Branch_Id", "dbo.Branch");
            DropIndex("dbo.TrackBranches", new[] { "Track_Id" });
            DropIndex("dbo.TrackBranches", new[] { "Branch_Id" });
            AddColumn("dbo.Track", "Branch_Id", c => c.Int());
            CreateIndex("dbo.Track", "Branch_Id");
            AddForeignKey("dbo.Track", "Branch_Id", "dbo.Branch", "Id");
            DropTable("dbo.TrackBranches");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TrackBranches",
                c => new
                    {
                        Track_Id = c.Int(nullable: false),
                        Branch_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Track_Id, t.Branch_Id });
            
            DropForeignKey("dbo.Track", "Branch_Id", "dbo.Branch");
            DropIndex("dbo.Track", new[] { "Branch_Id" });
            DropColumn("dbo.Track", "Branch_Id");
            CreateIndex("dbo.TrackBranches", "Branch_Id");
            CreateIndex("dbo.TrackBranches", "Track_Id");
            AddForeignKey("dbo.TrackBranches", "Branch_Id", "dbo.Branch", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TrackBranches", "Track_Id", "dbo.Track", "Id", cascadeDelete: true);
        }
    }
}
