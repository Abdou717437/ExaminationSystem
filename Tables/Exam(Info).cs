using patr_of_tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class Exam_Info_
    {
        [Key]
        public int id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime St_Time { get; set; }
        public DateTime En_Time { get; set; }
        public int Instructor_id { get; set; }
        public string Exam_Type { get; set; }

        //
        public virtual ICollection<Exam_Result> Exam_Results { get; set; }
        public virtual ICollection<Student_Exam> Student_Exams { get; set; }

        public virtual ICollection<Answer_Info> answer_Infos { get; set; }

        public virtual ICollection<Question_Exam_Info> question_Exam_Infos { get; set; }

        public virtual ICollection<Tbl_Course_Info> tbl_Course_Infos { get; set; }

        public virtual Instructor_Person Instructor_Person { get; set; }
       





    }
}
