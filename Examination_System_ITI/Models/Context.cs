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
    public class Context :DbContext
    {
        public Context() : base("name=con")
        {

        }
        public virtual DbSet<Student_Answer> Student_Answers { get; set; }
        public virtual DbSet<Question_Bank> Questions { get; set; }
        public virtual DbSet<Question_Option> Question_Options { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Exam_Question> Exam_Questions { get; set; }

        // abo taleb classes
        public virtual DbSet<Exam_Result> Exam_Results { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        // Hosam
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Intake> Intakes { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }

        public virtual DbSet<Role> Users_Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Renaming Tables Names
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Student_Answer>().ToTable("Student_Answer");

            //Relation Between Tabel  Instructor & Table Branch One To Many Relationship
            modelBuilder.Entity<Instructor>()
                .HasOptional(I => I.Branch)
                .WithMany(B => B.Instructors)
                .HasForeignKey(I => I.BranchId);

            modelBuilder.Entity<Instructor>()
                .HasOptional(I => I.Supervisor)
                .WithMany(S => S.Instructors)
                .HasForeignKey(I => I.SupervisorId);

            modelBuilder.Entity<Student>()
                .HasRequired(S => S.Track)
                .WithMany(T => T.Students)
                .HasForeignKey(I => I.TrackId);

            //Relation Between Tabel  Question_Bank & Table Question_Option One To One Relationship
            modelBuilder.Entity<Question_Option>().HasKey(o => o.QuestionId);
            modelBuilder.Entity<Question_Bank>().HasOptional(o => o.Question_Option)
                .WithRequired(q => q.Question_Bank);

            //Relation Between Tabel  User & Table User_Role One To One Relationship
            modelBuilder.Entity<Role>().HasKey(ur => ur.UserId);
            modelBuilder.Entity<User>().HasOptional(u => u.Role).WithRequired(ur => ur.User);

        }
    }
}
