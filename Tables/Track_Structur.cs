using patr_of_tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class Track_Structur
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Ins_id { get; set; }
        public int Dept_id { get; set; }
        public bool IsActive { get; set; }

        //

        public virtual ICollection<Student_person> Student_s { get; set; }

        public virtual ICollection<Tbl_Course_Info> Tbl_Course_Infos { get; set; }

        public virtual Manger_Bersone Manager_Bersone1 { get; set; }

        public virtual ICollection<Intak_Structure> Intak_Structures { get; set; }

        public virtual ICollection<Branch_Structure> Branch_Structures { get; set; }




    }
}
