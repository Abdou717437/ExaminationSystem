using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Correct_Answer")]
    public class Correct_Answer
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public virtual Question_Bank Question { get; set; }

    }
}
