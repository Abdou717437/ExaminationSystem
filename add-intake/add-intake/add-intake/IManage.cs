using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_intake
{
    internal interface IManage
    {
         int Id { get; set; }

         string Name { get; set; }

         string Start_Date { get; set; }
         string End_Date { get; set; }
         string Message { get; set; }
    }
}
