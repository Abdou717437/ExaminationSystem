using patr_of_tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    class Context :DbContext
    {
        public Context() : base(@"Data Source=.;Initial Catalog=ExamDB;Integrated Security=true;")
        { }

        public virtual DbSet<Answer_Info> Answer_Infos { get; set; }
        public virtual DbSet<Ques_Bank_Info> Ques_Bank_Infos { get; set; }

        public virtual DbSet<Ques_Option_Info> Ques_Option_Infos { get; set; }

        public virtual DbSet<Correct_Answer_Info> Correct_Answer_Infos { get; set; }


        // abo taleb classes
        public virtual DbSet<Exam_Result> Exam_Results { get; set; }
        public virtual DbSet<Exam_Info_> Exam_Infos_ { get; set; }
        public virtual DbSet<Student_Exam> Student_Exams { get; set; }
        public virtual DbSet<Instructor_Co> Instructor_Cos { get; set; }
        public virtual DbSet<Track_Structur> Track_Structurs { get; set; }


        // Hosam

        public virtual DbSet<Student_person> Students { get; set; }
        public virtual DbSet<Student_Contact_Person> Student_Contact_People { get; set; }
        public virtual DbSet<User_Person> User_People { get; set; }
        public virtual DbSet<Instructor_Person> Instructor_People { get; set; }
        public virtual DbSet<Intak_Structure> Intak_Structures { get; set; }
        public virtual DbSet<Branch_Structure> Branch_Structures { get; set; }

        public virtual DbSet<Manger_Bersone> Manger_Bersones { get; set; }


        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /// one to one relation between branch and manager
            /// 

            modelBuilder.Entity<Manger_Bersone>().HasKey(t => t.ID);

            modelBuilder.Entity<Manger_Bersone>().HasOptional(e => e.Branch_Structure).WithRequired(t => t.Bersone);

            //modelBuilder.Entity<Manger_Bersone>().HasRequired(t => t.Branch_Structure).WithOptional(t => t.ID);

            //modelBuilder.Entity<Branch_Structure>().HasRequired(t => t.ID).WithRequiredPrincipal(t => t.ID);

            //modelBuilder.Entity<Branch_Structure>()
            // .HasRequired(t => t.ID)
            //  .WithRequiredPrincipal(t => t.ID);


            // one to one relation between track and manager

            modelBuilder.Entity<Track_Structur>().HasKey(t => t.id);

            modelBuilder.Entity<Track_Structur>().HasOptional(t => t.Manager_Bersone1).WithRequired(t => t.Track_Structur1);

        }

    }
}
