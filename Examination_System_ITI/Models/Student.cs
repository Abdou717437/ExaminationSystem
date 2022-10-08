using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : User
    {
        public Student()
        {
            Student_Answers = new HashSet<Student_Answer>();
            Student_Contacts = new HashSet<Student_Contact>();
            Exams = new HashSet<Exam>();
            Results = new HashSet<Exam_Result>();
        }
        [Required, MaxLength(10)]
        public string F_Name { get; set; }

        [Required, MaxLength(10)]
        public string L_Name { get; set; }

        //[Required, MaxLength(14)]
        public string N_ID { get; set; }

        public DateTime DOB { get; set; }

        public virtual ICollection<Student_Contact> Student_Contacts  { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Student_Answer> Student_Answers { get; set; }

        public virtual ICollection<Exam_Result> Results { get; set; }

        public virtual Track Track { get; set; }
        
    }
}
