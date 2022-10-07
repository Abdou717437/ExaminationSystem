using patr_of_tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class Branch_Structure
    {

        [Key]
        public int ID { get; set; }
        [Required, MaxLength(10)]
        public string Name { get; set; }
        public string Description { get; set; }
        // [Key]
       
        //public int ID { get; set; }

        //public virtual ICollection<Instructor_Person> Instructor_People { get; set; }   

        public virtual Manger_Bersone Bersone { get; set; } 

        public virtual ICollection<Track_Structur> Track_Structurs { get; set; }
    }
}
