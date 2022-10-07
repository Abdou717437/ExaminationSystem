using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables

{
    internal class Intak_Structure
    {
        [Key]
        public int ID { get; set; }
        [Required, MaxLength(10)]
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime Start_Date { get; set; }
        public int End_Date { get; set; }
        //
        //[Key]
        [ForeignKey("Branch_Structure")]
        public int Branch_ID { get; set; }

        public virtual Branch_Structure Branch_Structure { get; set; } 
        
        public virtual ICollection<Track_Structur> Track_Structurs { get; set; }

    }
}
