using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    class Ques_Bank_Info
    {
        [Key]
        public int Q_ID { get; set; }
        public int C_ID { get; set; }
        public string Q_Type { get; set; }
        public string Q_Body { get; set; }

        //public virtual ICollection<Question_Exam_Info> Question_Exam_Infos { get; set; }

        public virtual ICollection<Ques_Option_Info> Ques_Option_Infos { get; set; }
        public virtual ICollection<Correct_Answer_Info> Correct_Answer_Infos { get; set; }
        public virtual ICollection<Question_Exam_Info> Question_Exam_Infos { get; set; }

        public virtual Tbl_Course_Info Tbl_Course_Info { get; set; }    
    }
}
