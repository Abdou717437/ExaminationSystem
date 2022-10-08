using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Exam_Result")]
    public class Exam_Result
    {
        public int Id { get; set; }
        public int Score { get; set; }

        public bool Status { get; set; }

        public virtual Exam Exam { get; set; }
        
        public virtual Student Student { get; set; }
    }
}
