using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("User_Role")]
    public class Role
    {
        public int UserId { get; set; }

        [Required,MaxLength(20)]
        public string UserRole { get; set; }

        public virtual User User { get; set; }

    }
}
