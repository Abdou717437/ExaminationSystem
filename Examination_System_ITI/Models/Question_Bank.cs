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
        public int Id { get; set; }
        public int Type { get; set; }
        public string Body { get; set; }

        public string Correct_Answer { get; set; }
       
        public virtual Course Course { get; set; }

        public virtual ICollection<Exam_Question> Exam_Questions { get; set; }

        public virtual Question_Option Question_Option { get; set; }


        
        
        
    }
}
