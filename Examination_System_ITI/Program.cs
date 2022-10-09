using Examination_System_ITI.Views;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examination_System_ITI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context ctx = new Context();
            ctx.Instructors.Add(new Instructor()
            {
                National_Id = "12564862574557",
                User_Name  = "Abdou",
                Password = "123456",
                F_Name = "Abdelrhman",
                M_Name = "Nazieh",
                L_Name = "Mohammed"
            }) ;
            ctx.SaveChanges();
            Application.Run(new ExamFrm());
        }
    }
}
