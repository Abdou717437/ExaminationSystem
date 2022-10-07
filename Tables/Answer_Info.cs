using patr_of_tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    class Answer_Info
    {
        public int ID { get; set; }
        public int Exam_ID { get; set; }
        public int Student_ID { get; set; }
        public int Ques_Exam_ID { get; set; }

        public virtual ICollection<Multi_Answer_Info> Multi_Answer_Infos { get; set; }

        public virtual Question_Exam_Info Question_Exam_Info { get; set; }

        public virtual Exam_Info_ Exam_Info_ { get; set; }

        public virtual Student_person Student_Person { get; set; }

    }
}
