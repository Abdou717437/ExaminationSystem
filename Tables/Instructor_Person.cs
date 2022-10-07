using patr_of_tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables

{
    internal class Instructor_Person : User_Person
    {
        [Key]
        public int ID { get; set; }
       // [Key]
        public int N_ID { get; set; }
        [Required, MaxLength(10)]
        public string F_Name { get; set; }
        [Required, MaxLength(10)]
        public string M_Name { get; set; }
        [Required, MaxLength(10)]
        public string L_Name { get; set; }
        public int Sup_ID { get; set; }
        //[Key]
        public int Branch_ID { get; set; }
        [Required, MaxLength(50)]
        public string Street { get; set; }
        [Required, MaxLength(50)]
        public string Zone { get; set; }
        //[Key]
        public int User_ID { get; set; }

        public virtual User_Person  User_Person { get; set; }   
        //public virtual Branch_Structure Branch_Structure { get; set; } 
        
        public virtual ICollection<Exam_Info_> Exam_Info_s { get; set; }

        public virtual ICollection<Instructor_Co> Instructor_Cos { get; set; }

        public virtual ICollection<Tbl_Course_Info> Tbl_Course_Infos { get; set; }

        public virtual Manger_Bersone Manger_Bersone { get; set; }


    }
}
