using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System_ITI.Views
{
    public partial class ExamFrm : Form
    {
        Context ctx;
        public ExamFrm()
        {
            InitializeComponent();
            ctx = new Context();
            ctx.Students.Add(new Student { F_Name = "Abdelrhman", L_Name = "Nazieh", User_Name = "Abdou", N_ID = "1455254456624" });
            ctx.SaveChanges();
        }
    }
}
