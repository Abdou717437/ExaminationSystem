namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUserRoleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User_Role",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        UserRole = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            AlterColumn("dbo.User", "Password", c => c.String(nullable: false, maxLength: 16));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User_Role", "UserId", "dbo.User");
            DropIndex("dbo.User_Role", new[] { "UserId" });
            AlterColumn("dbo.User", "Password", c => c.String());
            DropTable("dbo.User_Role");
        }
    }
}
