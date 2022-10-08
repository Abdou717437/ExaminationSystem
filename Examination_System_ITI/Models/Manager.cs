using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Manager : Instructor
    {
        public virtual Track Track { get; set; }

        public virtual Branch ManagedBranch { get; set; }
    }
}
