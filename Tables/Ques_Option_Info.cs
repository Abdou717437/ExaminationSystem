using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    class Ques_Option_Info
    {
        [Key]
        public int Option_ID { get; set; }
        public string Op_1 { get; set; }
        public string Op_2 { get; set; }
        public string Op_3 { get; set; }
        public string Op_4 { get; set; }


        public int Q_ID { get; set; }

        [ForeignKey("Q_ID")]
        public virtual Ques_Bank_Info Ques_Bank_Info { get; set; }
    }
}
