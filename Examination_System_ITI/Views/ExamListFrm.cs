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
        Context context;
        public ExamListFrm()
        {
            InitializeComponent();
            Exams = new List<Exam>();
            context = new Context();
        }

        #region Methods

        private void FillDataGridView(string text)
        {
            dgvExams.DataSource =
                context.Exams.Where(E => E.Name.Contains(text)
                                        || E.Code.Contains(text)
                                        || E.Instructor.User_Name.Contains(text))
                .Select(E => new
                {
                    Id = E.Id,
                    Name = E.Name,
                    Code = E.Code,
                    Date = E.St_Time,
                    EndDate = E.En_Time,
                    Course = E.Course.Name,
                    Instructor = E.Instructor.User_Name,
                }).ToList();

            dgvExams.Refresh();
        }
        public void FillDataGridView()
        {

            dgvExams.DataSource =
                context.Exams.Select(E => new
                {
                    Id = E.Id,
                    Name = E.Name,
                    Code = E.Code,
                    Date = E.St_Time,
                    EndTime = E.En_Time,
                    Course = E.Course.Name,
                    Instructor = E.Instructor.User_Name,
                }).ToList();

            dgvExams.Refresh();
        }

        #endregion

        private void ExamListFrm_Shown(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            if (MainFrm.mainFrm.activeForm != null)
            {
                MainFrm.mainFrm.activeForm.Close();
            }
            CreateExam_Frm frm = new CreateExam_Frm();
            frm.ShowDialog();
            MainFrm.mainFrm.activeForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            MainFrm.mainFrm.Controls.Add(frm);
            MainFrm.mainFrm.Main_Panel.Tag = frm;
            frm.BringToFront();
            frm.Show();
          
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Search.Text != String.Empty)
                FillDataGridView(Txt_Search.Text);
            else
                FillDataGridView();
        }
    }
}
