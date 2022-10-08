using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Multi_Answer
    {
        public int Id { get; set; }
        public string Answer { get; set; }

        public virtual  Student_Answer Student_Answer { get; set; }
    }
}
