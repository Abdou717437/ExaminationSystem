using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    class Tbl_Course_Info
    {
        [Key]
        public int C_ID { get; set; }
        public string C_Name { get; set; }
        public string C_Descrip { get; set; }
        public int MaxDegree { get; set; }
        public int MinDegree { get; set; }
        public int Ins_ID { get; set; }

        public virtual ICollection<Ques_Bank_Info> Ques_Bank_Infos { get; set; }
        public virtual ICollection<Track_Structur> Tracks_Structur { get; set; }

        public virtual ICollection<Exam_Info_> Exam_Info_s { get; set; }

        public virtual Instructor_Person Instructor_Person { get; set; }
    }
}
