using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models

{
    [Table ("Intake")]
    public class Intake
    {
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public virtual Branch Branch { get; set; }
        
        public virtual ICollection<Track> Tracks { get; set; }

    }
}
