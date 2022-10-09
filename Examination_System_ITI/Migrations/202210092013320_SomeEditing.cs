namespace Examination_System_ITI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeEditing : DbMigration
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
                        Instructor_Id = c.Int(),
                        Instructor_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructor", t => t.Instructor_Id)
                .ForeignKey("dbo.Instructor", t => t.Instructor_Id1)
                .Index(t => t.Instructor_Id)
                .Index(t => t.Instructor_Id1);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Name = c.String(nullable: false, maxLength: 10),
                        Password = c.String(),
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.Exam_Id)
                .Index(t => t.Exam_Id);
            
            CreateTable(
                "dbo.Question_Bank",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Body = c.String(),
                        Course_Id = c.Int(),
                        Exam_Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Course", t => t.Course_Id)
                .ForeignKey("dbo.Exam_Question", t => t.Exam_Question_Id)
                .Index(t => t.Course_Id)
                .Index(t => t.Exam_Question_Id);
            
            CreateTable(
                "dbo.Correct_Answer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Question_Bank", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.Question_Option",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Op_1 = c.String(),
                        Op_2 = c.String(),
                        Op_3 = c.String(),
                        Op_4 = c.String(),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Question_Bank", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
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
                "dbo.Student_Answer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                "dbo.Multi_Answer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(),
                        Student_Answer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Student_Answer", t => t.Student_Answer_Id)
                .Index(t => t.Student_Answer_Id);
            
            CreateTable(
                "dbo.Student_Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Website = c.String(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Student", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Track",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Instructor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructor", t => t.Instructor_Id)
                .Index(t => t.Instructor_Id);
            
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
                "dbo.Instructor_Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.Int(nullable: false),
                        Email = c.String(),
                        Instructor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Instructor", t => t.Instructor_Id)
                .Index(t => t.Instructor_Id);
            
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
                        Branch_Id = c.Int(),
                        Supervisor_Id = c.Int(),
                        Branch_Id1 = c.Int(),
                        National_Id = c.String(nullable: false, maxLength: 14),
                        F_Name = c.String(nullable: false, maxLength: 10),
                        M_Name = c.String(nullable: false, maxLength: 10),
                        L_Name = c.String(nullable: false, maxLength: 10),
                        Street = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id)
                .ForeignKey("dbo.Instructor", t => t.Supervisor_Id)
                .ForeignKey("dbo.Branch", t => t.Branch_Id1)
                .Index(t => t.Id)
                .Index(t => t.Branch_Id)
                .Index(t => t.Supervisor_Id)
                .Index(t => t.Branch_Id1);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Track_Id = c.Int(),
                        F_Name = c.String(nullable: false, maxLength: 10),
                        L_Name = c.String(nullable: false, maxLength: 10),
                        N_ID = c.String(),
                        DOB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Id)
                .ForeignKey("dbo.Track", t => t.Track_Id)
                .Index(t => t.Id)
                .Index(t => t.Track_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "Track_Id", "dbo.Track");
            DropForeignKey("dbo.Student", "Id", "dbo.User");
            DropForeignKey("dbo.Instructor", "Branch_Id1", "dbo.Branch");
            DropForeignKey("dbo.Instructor", "Supervisor_Id", "dbo.Instructor");
            DropForeignKey("dbo.Instructor", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Instructor", "Id", "dbo.User");
            DropForeignKey("dbo.Branch", "Instructor_Id1", "dbo.Instructor");
            DropForeignKey("dbo.Instructor_Contact", "Instructor_Id", "dbo.Instructor");
            DropForeignKey("dbo.Course", "Instructor_Id", "dbo.Instructor");
            DropForeignKey("dbo.Exams", "Instructor_Id", "dbo.Instructor");
            DropForeignKey("dbo.IntakeTracks", "Track_Id", "dbo.Track");
            DropForeignKey("dbo.IntakeTracks", "Intake_Id", "dbo.Intake");
            DropForeignKey("dbo.Intake", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.Track", "Instructor_Id", "dbo.Instructor");
            DropForeignKey("dbo.TrackCourses", "Course_Id", "dbo.Course");
            DropForeignKey("dbo.TrackCourses", "Track_Id", "dbo.Track");
            DropForeignKey("dbo.TrackBranches", "Branch_Id", "dbo.Branch");
            DropForeignKey("dbo.TrackBranches", "Track_Id", "dbo.Track");
            DropForeignKey("dbo.Student_Contact", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.Multi_Answer", "Student_Answer_Id", "dbo.Student_Answer");
            DropForeignKey("dbo.Student_Answer", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.Student_Answer", "Question_Id", "dbo.Exam_Question");
            DropForeignKey("dbo.Student_Answer", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.Exam_Result", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.StudentExams", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.StudentExams", "Student_Id", "dbo.Student");
            DropForeignKey("dbo.Exam_Result", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.Question_Option", "Question_Id", "dbo.Question_Bank");
            DropForeignKey("dbo.Question_Bank", "Exam_Question_Id", "dbo.Exam_Question");
            DropForeignKey("dbo.Question_Bank", "Course_Id", "dbo.Course");
            DropForeignKey("dbo.Correct_Answer", "Question_Id", "dbo.Question_Bank");
            DropForeignKey("dbo.Exam_Question", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.Exams", "Course_Id", "dbo.Course");
            DropForeignKey("dbo.Branch", "Instructor_Id", "dbo.Instructor");
            DropIndex("dbo.Student", new[] { "Track_Id" });
            DropIndex("dbo.Student", new[] { "Id" });
            DropIndex("dbo.Instructor", new[] { "Branch_Id1" });
            DropIndex("dbo.Instructor", new[] { "Supervisor_Id" });
            DropIndex("dbo.Instructor", new[] { "Branch_Id" });
            DropIndex("dbo.Instructor", new[] { "Id" });
            DropIndex("dbo.IntakeTracks", new[] { "Track_Id" });
            DropIndex("dbo.IntakeTracks", new[] { "Intake_Id" });
            DropIndex("dbo.TrackCourses", new[] { "Course_Id" });
            DropIndex("dbo.TrackCourses", new[] { "Track_Id" });
            DropIndex("dbo.TrackBranches", new[] { "Branch_Id" });
            DropIndex("dbo.TrackBranches", new[] { "Track_Id" });
            DropIndex("dbo.StudentExams", new[] { "Exam_Id" });
            DropIndex("dbo.StudentExams", new[] { "Student_Id" });
            DropIndex("dbo.Instructor_Contact", new[] { "Instructor_Id" });
            DropIndex("dbo.Intake", new[] { "Branch_Id" });
            DropIndex("dbo.Track", new[] { "Instructor_Id" });
            DropIndex("dbo.Student_Contact", new[] { "Student_Id" });
            DropIndex("dbo.Multi_Answer", new[] { "Student_Answer_Id" });
            DropIndex("dbo.Student_Answer", new[] { "Student_Id" });
            DropIndex("dbo.Student_Answer", new[] { "Question_Id" });
            DropIndex("dbo.Student_Answer", new[] { "Exam_Id" });
            DropIndex("dbo.Exam_Result", new[] { "Student_Id" });
            DropIndex("dbo.Exam_Result", new[] { "Exam_Id" });
            DropIndex("dbo.Question_Option", new[] { "Question_Id" });
            DropIndex("dbo.Correct_Answer", new[] { "Question_Id" });
            DropIndex("dbo.Question_Bank", new[] { "Exam_Question_Id" });
            DropIndex("dbo.Question_Bank", new[] { "Course_Id" });
            DropIndex("dbo.Exam_Question", new[] { "Exam_Id" });
            DropIndex("dbo.Exams", new[] { "Instructor_Id" });
            DropIndex("dbo.Exams", new[] { "Course_Id" });
            DropIndex("dbo.Course", new[] { "Instructor_Id" });
            DropIndex("dbo.Branch", new[] { "Instructor_Id1" });
            DropIndex("dbo.Branch", new[] { "Instructor_Id" });
            DropTable("dbo.Student");
            DropTable("dbo.Instructor");
            DropTable("dbo.IntakeTracks");
            DropTable("dbo.TrackCourses");
            DropTable("dbo.TrackBranches");
            DropTable("dbo.StudentExams");
            DropTable("dbo.Instructor_Contact");
            DropTable("dbo.Intake");
            DropTable("dbo.Track");
            DropTable("dbo.Student_Contact");
            DropTable("dbo.Multi_Answer");
            DropTable("dbo.Student_Answer");
            DropTable("dbo.Exam_Result");
            DropTable("dbo.Question_Option");
            DropTable("dbo.Correct_Answer");
            DropTable("dbo.Question_Bank");
            DropTable("dbo.Exam_Question");
            DropTable("dbo.Exams");
            DropTable("dbo.Course");
            DropTable("dbo.User");
            DropTable("dbo.Branch");
        }
    }
}
