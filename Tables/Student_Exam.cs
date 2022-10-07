using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class Student_Exam
    {
        [Key]
        public int id { get; set; }
        public int Exam_id { get; set; }
        public int Student_id { get; set; }

        //
        public virtual Exam_Info_ Exam_Info_ { get; set; }

        public virtual Student_person Student_Person { get; set; }  

    }
}
