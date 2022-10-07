using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    class Multi_Answer_Info
    {
        public int ID { get; set; }
        public string Answer { get; set; }

        public virtual Answer_Info Answer_Info { get; set; }
    }
}
