using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student_Answer
    {
        public int Id { get; set; }

        public string Answer { get; set; }
        
        public int QuestionId { get; set; }
        public Exam_Question Question { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
