using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Track")]
    public class Track
    {
        public Track()
        {
            Students = new HashSet<Student>();
            Courses = new HashSet<Course>();
            Intakes = new HashSet<Intake>();
            Branches = new HashSet<Branch>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Intake> Intakes { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }

    }
}
