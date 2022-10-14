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
    public partial class Frm_Course : Form
    {
        IList<Course> Courses { get; set; }
        public Frm_Course()
        {
            InitializeComponent();
            Courses = new List<Course>();
        }

        private void Frm_Course_Load(object sender, EventArgs e)
        {
            grBoxCourseInfo.Visible = false;
            
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            grBoxCourseInfo.Visible = true;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #region Methods

        public void Clear()
        {
            Txt_Desc.Text = Txt_Id.Text = Txt_Maxdeg.Text = Txt_Mindeg.Text = Txt_Name.Text = null;
        }

        public void FillDataGridView()
        {
            dgvCourses.Rows.Clear();
            foreach (var Course in Courses)
            {
                dgvCourses.Rows.Add(
                                new object[]
                                {
                                    Course.Id,
                                    Course.Name,
                                    Course.Description,
                                    Course.MaxDegree,
                                    Course.MinDegree,
                                });
            }
        }

        #endregion

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Course.AddCourse(new Course
            {
                Name = Txt_Name.Text,
                Description = Txt_Desc.Text,
                MaxDegree = Convert.ToInt32(Txt_Maxdeg.Text),
                MinDegree = Convert.ToInt32(Txt_Mindeg.Text),
            }) ;
            Courses = Course.GetAllCourses();
            FillDataGridView();
            if (Course.IsSuccessful)
                MessageBox.Show(Course.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Course.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grBoxCourseInfo.Visible = false;
        }

        private void Frm_Course_Shown(object sender, EventArgs e)
        {
            Courses = Course.GetAllCourses();
            FillDataGridView();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            Courses = Course.GetAllByValue(Txt_Search.Text);
            dgvCourses.Rows.Clear();
            FillDataGridView();
            if(Txt_Search.Text == String.Empty)
            {
                Courses = Course.GetAllCourses();
                dgvCourses.Rows.Clear();
                FillDataGridView();
            }
        }
    }
}
