using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patr_of_tables
{
    
    internal class Student_Contact_Person
    {
       [Key]
       public int Student_ID { get; set; }
        public virtual Student_person Student_Person { get; set; }  
    } 
}
