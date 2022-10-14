namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Instructor", "F_Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Instructor", "L_Name", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Instructor", "M_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instructor", "M_Name", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Instructor", "L_Name", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Instructor", "F_Name", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
