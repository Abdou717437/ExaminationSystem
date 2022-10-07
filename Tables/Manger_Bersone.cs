using patr_of_tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class Manger_Bersone //:Instructor_Person
    {
        //[Key]
        public int ID { get; set; }
        public int Instructor_ID { get; set; }

        //public virtual ICollection<Track_Structur> Track_Structurs { get; set; }

        public virtual ICollection<Instructor_Person> Instructor_People { get; set; }
        //public virtual ICollection<Track_Structur> Track_Structurs { get; set; }

        //public virtual ICollection<Branch_Structure> Branch_Structures { get; set; }

        public virtual Branch_Structure Branch_Structure { get; set; }

        public virtual Track_Structur Track_Structur1 { get; set; }


    }
}
