using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Question_Bank")]
    public class Question_Bank
    {
        public Question_Bank()
        {
            Correct_Answers = new HashSet<Correct_Answer>();
            Options = new HashSet<Question_Option>();
        }
        public int Id { get; set; }
        public int Type { get; set; }
        public string Body { get; set; }

        public virtual Course Course { get; set; }

        public virtual Exam_Question Exam_Question { get; set; }

        public virtual ICollection<Correct_Answer> Correct_Answers { get; set; }

        public virtual ICollection<Question_Option> Options { get; set; }
        
        
    }
}
