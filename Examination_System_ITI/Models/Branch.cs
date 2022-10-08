using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Branch")]
    public class Branch
    {
        public Branch()
        {
            Tracks = new HashSet<Track>();
        }

        public int Id { get; set; }

        [Required, MaxLength(10)]
        public string Name { get; set; }
        public string Description { get; set; }   

        public virtual Manager Manager { get; set; } 

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
