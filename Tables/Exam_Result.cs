using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class Exam_Result
    {
        [Key]
        public int id { get; set; }
        public int Student_id { get; set; }
        public int Exam_id { get; set; }
        public int Score { get; set; }

        //navigation
        public Exam_Info_ Exam_Info_ { get; set; }
        

    }
}
