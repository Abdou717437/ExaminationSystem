namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        InstructorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructor", t => t.InstructorId)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Name = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false, maxLength: 16),
                        Status = c.Boolean(nullable: false),
                        Profile_Image_Src = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        MaxDegree = c.Int(nullable: false),
                        MinDegree = c.Int(nullable: false),
                        Instructor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructor", t => t.Instructor_Id)
                .Index(t => t.Instructor_Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Name = c.String(),
                        St_Time = c.DateTime(nullable: false),
                        En_Time = c.DateTime(nullable: false),
                        Exam_Type = c.String(),
                        Course_Id = c.Int(),
                        Instructor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Course", t => t.Course_Id)
                .ForeignKey("dbo.Instructor", t => t.Instructor_Id)
                .Index(t => t.Course_Id)
                .Index(t => t.Instructor_Id);
            
            CreateTable(
                "dbo.Exam_Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Points = c.Int(nullable: false),
                        Exam_Id = c.Int(),
                        Question_Bank_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.Exam_Id)
                .ForeignKey("dbo.Question_Bank", t => t.Question_Bank_Id)
                .Index(t => t.Exam_Id)
                .Index(t => t.Question_Bank_Id);
            
            CreateTable(
                "dbo.Question_Bank",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Body = c.String(),
                        Correct_Answer = c.String(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Course", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Question_Option",
                c => new
                    {
                        QuestionId = c.Int(nullable: false),
                        Op_1 = c.String(),
                        Op_2 = c.String(),
                        Op_3 = c.String(),
                        Op_4 = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Question_Bank", t => t.QuestionId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Exam_Result",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Exam_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.Exam_Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Exam_Id)
                .Index(t => t.Student_Id);
            
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
            
            CreateTable(
                "dbo.Student_Answer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        Exam_Id = c.Int(),
                        Question_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.Exam_Id)
                .ForeignKey("dbo.Exam_Question", t => t.Question_Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Exam_Id)
                .Index(t => t.Question_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Track",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        InstructorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructor", t => t.InstructorId)
                .Index(t => t.InstructorId);
            
            CreateTable(
                "dbo.Intake",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10),
                        Start_Date = c.DateTime(nullable: false, storeType: "date"),
                        End_Date = c.DateTime(nullable: false),
                        Branch_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .Index(t => t.Branch_Id);
            
            CreateTable(
                "dbo.StudentExams",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Exam_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Exam_Id })
                .ForeignKey("dbo.Student", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Exams", t => t.Exam_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Exam_Id);
            
            CreateTable(
                "dbo.TrackBranches",
                c => new
                    {
                        Track_Id = c.Int(nullable: false),
                        Branch_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Track_Id, t.Branch_Id })
                .ForeignKey("dbo.Track", t => t.Track_Id, cascadeDelete: true)
                .ForeignKey("dbo.Branch", t => t.Branch_Id, cascadeDelete: true)
                .Index(t => t.Track_Id)
                .Index(t => t.Branch_Id);
            
            CreateTable(
                "dbo.TrackCourses",
                c => new
                    {
                        Track_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Track_Id, t.Course_Id })
                .ForeignKey("dbo.Track", t => t.Track_Id, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Track_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.IntakeTracks",
                c => new
                    {
                        Intake_Id = c.Int(nullable: false),
                        Track_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Intake_Id, t.Track_Id })
                .ForeignKey("dbo.Intake", t => t.Intake_Id, cascadeDelete: true)
                .ForeignKey("dbo.Track", t => t.Track_Id, cascadeDelete: true)
                .Index(t => t.Intake_Id)
                .Index(t => t.Track_Id);
            
            CreateTable(
                "dbo.Instructor",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        National_Id = c.String(nullable: false, maxLength: 14),
                        F_Name = c.String(nullable: false, maxLength: 10),
                        M_Name = c.String(nullable: false, maxLength: 10),
                        L_Name = c.String(nullable: false, maxLength: 10),
                        Phone = c.String(maxLength: 14),
                        Email = c.String(),
                        BranchId = c.Int(),
                        SupervisorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Id)
                .ForeignKey("dbo.Branch", t => t.BranchId)
                .ForeignKey("dbo.Instructor", t => t.SupervisorId)
                .Index(t => t.Id)
                .Index(t => t.BranchId)
                .Index(t => t.SupervisorId);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        F_Name = c.String(nullable: false, maxLength: 10),
                        L_Name = c.String(nullable: false, maxLength: 10),
                        N_ID = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        TrackId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Id)
                .ForeignKey("dbo.Track", t => t.TrackId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.TrackId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "TrackId", "dbo.Track");
            DropForeignKey("dbo.Student", "Id", "dbo.User");
            DropForeignKey("dbo.Instructor", "SupervisorId", "dbo.Instructor");
            DropForeignKey("dbo.Instructor", "BranchId", "dbo.Branch");
            DropForeignKey("dbo.Instructor", "Id", "dbo.User");
            DropForeignKey("dbo.Branch", "InstructorId", "dbo.Instructor");
            DropForeignKey("dbo.Course", "Instructor_Id", "dbo.Instructor");
            DropForeignKey("dbo.Exams", "Instructor_Id", "dbo.Instructor");
            DropForeignKey("dbo.IntakeTracks", "Track_Id", "dbo.Track");
            DropForeignKey("dbo.IntakeTracks", "Intake_Id", "dbo.Intake");
            DropForeignKey("dbo.Intake", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Track", "InstructorId", "dbo.Instructor");
            DropForeignKey("dbo.TrackCourses", "Course_Id", "dbo.Course");
            DropForeignKey("dbo.TrackCourses", "Track_Id", "dbo.Track");
            DropForeignKey("dbo.TrackBranches", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.TrackBranches", "Track_Id", "dbo.Track");
            DropForeignKey("dbo.Student_Answer", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.Student_Answer", "Question_Id", "dbo.Exam_Question");
            DropForeignKey("dbo.Student_Answer", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.User_Role", "UserId", "dbo.User");
            DropForeignKey("dbo.Exam_Result", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.StudentExams", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.StudentExams", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.Exam_Result", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.Question_Option", "QuestionId", "dbo.Question_Bank");
            DropForeignKey("dbo.Exam_Question", "Question_Bank_Id", "dbo.Question_Bank");
            DropForeignKey("dbo.Question_Bank", "Course_Id", "dbo.Course");
            DropForeignKey("dbo.Exam_Question", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.Exams", "Course_Id", "dbo.Course");
            DropIndex("dbo.Student", new[] { "TrackId" });
            DropIndex("dbo.Student", new[] { "Id" });
            DropIndex("dbo.Instructor", new[] { "SupervisorId" });
            DropIndex("dbo.Instructor", new[] { "BranchId" });
            DropIndex("dbo.Instructor", new[] { "Id" });
            DropIndex("dbo.IntakeTracks", new[] { "Track_Id" });
            DropIndex("dbo.IntakeTracks", new[] { "Intake_Id" });
            DropIndex("dbo.TrackCourses", new[] { "Course_Id" });
            DropIndex("dbo.TrackCourses", new[] { "Track_Id" });
            DropIndex("dbo.TrackBranches", new[] { "Branch_Id" });
            DropIndex("dbo.TrackBranches", new[] { "Track_Id" });
            DropIndex("dbo.StudentExams", new[] { "Exam_Id" });
            DropIndex("dbo.StudentExams", new[] { "Student_Id" });
            DropIndex("dbo.Intake", new[] { "Branch_Id" });
            DropIndex("dbo.Track", new[] { "InstructorId" });
            DropIndex("dbo.Student_Answer", new[] { "Student_Id" });
            DropIndex("dbo.Student_Answer", new[] { "Question_Id" });
            DropIndex("dbo.Student_Answer", new[] { "Exam_Id" });
            DropIndex("dbo.User_Role", new[] { "UserId" });
            DropIndex("dbo.Exam_Result", new[] { "Student_Id" });
            DropIndex("dbo.Exam_Result", new[] { "Exam_Id" });
            DropIndex("dbo.Question_Option", new[] { "QuestionId" });
            DropIndex("dbo.Question_Bank", new[] { "Course_Id" });
            DropIndex("dbo.Exam_Question", new[] { "Question_Bank_Id" });
            DropIndex("dbo.Exam_Question", new[] { "Exam_Id" });
            DropIndex("dbo.Exams", new[] { "Instructor_Id" });
            DropIndex("dbo.Exams", new[] { "Course_Id" });
            DropIndex("dbo.Course", new[] { "Instructor_Id" });
            DropIndex("dbo.Branch", new[] { "InstructorId" });
            DropTable("dbo.Student");
            DropTable("dbo.Instructor");
            DropTable("dbo.IntakeTracks");
            DropTable("dbo.TrackCourses");
            DropTable("dbo.TrackBranches");
            DropTable("dbo.StudentExams");
            DropTable("dbo.Intake");
            DropTable("dbo.Track");
            DropTable("dbo.Student_Answer");
            DropTable("dbo.User_Role");
            DropTable("dbo.Exam_Result");
            DropTable("dbo.Question_Option");
            DropTable("dbo.Question_Bank");
            DropTable("dbo.Exam_Question");
            DropTable("dbo.Exams");
            DropTable("dbo.Course");
            DropTable("dbo.User");
            DropTable("dbo.Branch");
        }
    }
}
