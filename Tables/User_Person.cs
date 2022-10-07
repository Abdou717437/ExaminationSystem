using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class User_Person 
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string User_Name { get; set; }
        public object Password { get; set; }
        [Required, MaxLength(10)]
        public string Status { get; set; }
        public string User_Type { get; set; }
        public object Profile_Image { get; set; } 

        //public virtual ICollection<Student_person>Student_People { get; set; }
        //public virtual ICollection<Instructor_Person> Instructor_People { get; set; }


    }
}
