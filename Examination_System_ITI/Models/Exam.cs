using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Exam
    {
        public Exam()
        {
            Exam_Results = new HashSet<Exam_Result>();
            Students = new HashSet<Student>();
            Students_Answers = new HashSet<Student_Answer>();
            Exam_Questions = new HashSet<Exam_Question>();
        }
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime St_Time { get; set; }
        public DateTime En_Time { get; set; }
        public string Exam_Type { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Course Course { get; set; }
        public virtual ICollection<Exam_Result> Exam_Results { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Student_Answer> Students_Answers { get; set; }

        public virtual ICollection<Exam_Question> Exam_Questions { get; set; }

    }
}
