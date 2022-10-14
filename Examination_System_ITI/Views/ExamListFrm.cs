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
    public partial class ExamListFrm : Form
    {
        IList<Exam> Exams { get; set; }
        public ExamListFrm()
        {
            InitializeComponent();
            Exams = new List<Exam>();
        }

        #region Methods

        public void FillDataGridView()
        {
            dgvExams.Rows.Clear();
            foreach (var exam in Exams)
            {
                string TrackName = "";
                TrackName = (from e in exam.Students select e.Track.Name).ToString(); 
                dgvExams.Rows.Add(
                                new object[]
                                {
                                    exam.Id,
                                    exam.Name,
                                    exam.Code,
                                    exam.En_Time - exam.St_Time,
                                    TrackName,
                                    exam.Instructor.F_Name + " " +exam.Instructor.L_Name,
                                }) ;
            }
        }

        #endregion

        private void ExamListFrm_Shown(object sender, EventArgs e)
        {
            Exams = Exam.GetAllExams();
            FillDataGridView();
        }
    }
}
