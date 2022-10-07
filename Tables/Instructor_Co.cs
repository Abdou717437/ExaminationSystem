using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    internal class Instructor_Co
    {
      [Key]
        public int Instructor_id { get; set; }
        public int Phone { get; set; }

        public virtual Instructor_Person Instructor_Person { get; set; }


    }
}
