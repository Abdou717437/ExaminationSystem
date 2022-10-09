using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Course")] 
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxDegree { get; set; }
        public int MinDegree { get; set; }

        public virtual ICollection<Question_Bank> Questions { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual Instructor Instructor { get; set; }


    }
}
