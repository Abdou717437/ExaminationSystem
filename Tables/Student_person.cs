using patr_of_tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class Student_person :User_Person
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string F_Name { get; set; }
        [Required, MaxLength(10)]
        public string L_Name { get; set; }
       // [Key]
        public int N_ID { get; set; }
        public string DOB { get; set; }
       // [Key]
        public int Track_ID { get; set; }
       // [Key]
        public int User_ID { get; set; }
        public virtual ICollection<Student_Contact_Person>Student_Contact_People  { get; set; }
        //public virtual User_Person User_Person { get; set; }   
        
        public virtual ICollection<Answer_Info> Answer_Infos { get; set; }

        public virtual ICollection<Student_Exam> Student_Exams { get; set; }

        public virtual Track_Structur Track_Structur { get; set; }

    }
}
