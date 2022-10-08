using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Context :DbContext
    {

        public virtual DbSet<Student_Answer> Student_Answers { get; set; }
        public virtual DbSet<Question_Bank> Questions { get; set; }
        public virtual DbSet<Question_Option> Question_Options { get; set; }

        public virtual DbSet<Correct_Answer> Correct_Answers { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Exam_Question> Exam_Questions { get; set; }

        // abo taleb classes
        public virtual DbSet<Exam_Result> Exam_Results { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Multi_Answer> Multi_Answers { get; set; }

        // Hosam

        public virtual DbSet<Student_Contact> Student_Contacts { get; set; }
        public virtual DbSet<Instructor_Contact> Instructor_Contacts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Intake> Intakes { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }


    }
}
