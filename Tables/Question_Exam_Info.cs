using patr_of_tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    class Question_Exam_Info
    {
        public int ID { get; set; }
        public int Exam_ID {get;set;}
        public int Question_ID { get; set; }

        public virtual ICollection<Answer_Info> Answer_Infos { get; set; }

        public virtual Exam_Info_ Exam_Info_ { get; set; }

        public virtual Ques_Bank_Info Ques_Bank_Info { get; set; }
    }
}
