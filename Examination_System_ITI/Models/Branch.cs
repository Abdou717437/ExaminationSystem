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
        public int Id { get; set; }

        [Required, MinLength(5), MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
