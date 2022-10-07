using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    class Correct_Answer_Info
    {
        public int ID { get; set; }
        public string C_Answer { get; set; }
        public int Ques_ID { get; set; }

        public virtual Ques_Bank_Info Ques_Bank_Info { get; set; }

    }
}
