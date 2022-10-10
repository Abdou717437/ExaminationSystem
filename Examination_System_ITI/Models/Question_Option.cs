using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Question_Option")]
    public class Question_Option
    {
        public int QuestionId { get; set; }
        public string Op_1 { get; set; }
        public string Op_2 { get; set; }
        public string Op_3 { get; set; }
        public string Op_4 { get; set; }
        public Question_Bank Question_Bank { get; set; }

    }
}
