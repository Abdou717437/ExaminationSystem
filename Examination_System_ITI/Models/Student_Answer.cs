using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student_Answer
    {
        public Student_Answer()
        {
            Student_Answers = new HashSet<Multi_Answer>();
        }
        public int Id { get; set; }
        
        public virtual Exam_Question Question { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual Student Student { get; set; }

        public virtual ICollection<Multi_Answer> Student_Answers { get; set; }

    }
}
