using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Instructor_Contact
    {
        public int Id { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public virtual  Instructor Instructor { get; set; }

    }
}
