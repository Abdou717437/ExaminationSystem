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

        [Required, MaxLength(14)]
        public string National_Id { get; set; }

        [Required, MaxLength(10)]
        public string F_Name { get; set; }
        [Required, MaxLength(10)]
        public string M_Name { get; set; }

        [Required, MaxLength(10)]
        public string L_Name { get; set; }

        public string Street { get; set; }

        public virtual Instructor Supervisor { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Instructor_Contact> Instructor_Contacts { get; set; }

        public virtual ICollection<Course> Courses { get; set; }


    }
}
