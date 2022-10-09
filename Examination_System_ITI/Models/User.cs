using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string User_Name { get; set; }

        public string Password { get; set; }

        public bool Status { get; set; }

        public string Profile_Image_Src { get; set; } 

    }
}
