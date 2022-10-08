using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models

{
    [Table ("Instructor")]
    public class Instructor : User
    {
        public Instructor()
        {
            Exams = new HashSet<Exam>();
            Instructor_Contacts = new HashSet<Instructor_Contact>();
            Courses = new HashSet<Course>();
        }
        [Required, MaxLength(14)]
        public int N_ID { get; set; }
        [Required, MaxLength(10)]
        public string F_Name { get; set; }
        [Required, MaxLength(10)]
        public string M_Name { get; set; }

        [Required, MaxLength(10)]
        public string L_Name { get; set; }
        public virtual Instructor Supervisor { get; set; }
        //[Key]
        public virtual Branch Branch { get; set; }

        [Required, MaxLength(50)]
        public string Street { get; set; }
        
        [Required, MaxLength(50)]
        public string Zone { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Instructor_Contact> Instructor_Contacts { get; set; }

        public virtual ICollection<Course> Courses { get; set; }


    }
}
