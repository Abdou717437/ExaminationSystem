using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Student_Contact")]
    public class Student_Contact
    {
        public string Phone { get; set; }

        public string Website { get; set; }

        public Student Student { get; set; }
    } 
}
