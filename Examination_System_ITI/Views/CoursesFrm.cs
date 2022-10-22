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
        string Message { get; set; }
        bool IsSuccessful { get; set; }

        Context context;
        public Frm_Course()
        {
            InitializeComponent();
            context = new Context();
            Message = "";
            IsSuccessful = false;
        }

        private void Frm_Course_Load(object sender, EventArgs e)
        {
            grBoxCourseInfo.Visible = false;
            btn_DeleteCourse.Visible = false;
            btn_UpdateCourse.Visible = false;
            comBox_Instructors.DataSource = context.Instructors.Where(I => I.Role.UserRole == "Instructor").ToList();
            comBox_Instructors.ValueMember = "Id";
            comBox_Instructors.DisplayMember = "User_Name";
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            grBoxCourseInfo.Visible = true;
            Btn_Save.Visible = true;
            Btn_Refresh.Visible = true;
            btn_DeleteCourse.Visible = false;
            btn_UpdateCourse.Visible = false;
            Clear();
        }

       
        #region Methods

        public void Clear()
        {
            Txt_Desc.Text = Txt_Id.Text = Txt_Maxdeg.Text = txt_minDeg.Text = Txt_Name.Text = null;
            comBox_Instructors.SelectedItem = null;
        }

        private void FillDataGridView(string text)
        {
            dgvCourses.DataSource =
                context.Courses.Where(C => C.Name.Contains(text)
                                        || C.Instructor.User_Name.Contains(text))
                .Select(C => new
                {
                    Id = C.Id,
                    Name = C.Name,
                    Description = C.Description,
                    MinDegree = C.MinDegree,
                    MaxDegree = C.MaxDegree,
                    Instructor = C.Instructor.User_Name,
                }).ToList();

            dgvCourses.Refresh();
        }
        public void FillDataGridView()
        {

            dgvCourses.DataSource =
                context.Courses.Select(C => new
                {
                    Id = C.Id,
                    Name = C.Name,
                    Description = C.Description,
                    MinDegree = C.MinDegree,
                    MaxDegree = C.MaxDegree,
                    Instructor = C.Instructor.User_Name,
                }).ToList();

            dgvCourses.Refresh();
        }

        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grBoxCourseInfo.Visible = false;
        }

        private void Frm_Course_Shown(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Search.Text != String.Empty)
                FillDataGridView(Txt_Search.Text);
            else
                FillDataGridView();
        }

        private void btn_AddQuestions_Click(object sender, EventArgs e)
        {
            QuestionsFrmcs frm = new QuestionsFrmcs();
            frm.ShowDialog();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var instructor = (Instructor)comBox_Instructors.SelectedItem;
            var course = new Course()
            {
                Name = String.Format(Txt_Name.Text),
                Description = String.Format(Txt_Desc.Text),
                MaxDegree = int.Parse(Txt_Maxdeg.Text),
                MinDegree = int.Parse(txt_minDeg.Text),
                Instructor = instructor
            };
            if (course.Instructor is null)
            {
                this.Message = "Please Assign The Course To An Instructor!";
                this.IsSuccessful = false;
            }
            else if (course.Name == String.Empty)
            {
                this.Message = "Course Name Is Required!";
                this.IsSuccessful = false;
            }
            else if (course.MaxDegree == 0)
            {
                this.Message = "Max Degree Is Required!";
                this.IsSuccessful = false;
            }
            else if (course.MinDegree == 0)
            {
                this.Message = "Min Degree Is Required!";
                this.IsSuccessful = false;
            }
            else
            {
                try
                {
                    context.Courses.Add(course);


                    context.SaveChanges();

                    this.Message = "Course Added Successfully!";
                    this.IsSuccessful = true;
                    FillDataGridView();
                }
                catch (Exception ex)
                {
                    this.Message = ex.Message;
                    this.IsSuccessful = false;
                }
            }

            if (this.IsSuccessful)
                MessageBox.Show(this.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvCourses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grBoxCourseInfo.Visible = true;
            btn_UpdateCourse.Visible = true;
            btn_DeleteCourse.Visible = true;
            Btn_Refresh.Visible = false;
            Btn_Save.Visible = false;
            Clear();
            string username = dgvCourses.Rows[e.RowIndex].Cells["Instructor"].FormattedValue.ToString();
            Txt_Id.Text = dgvCourses.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            Txt_Name.Text = dgvCourses.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            Txt_Desc.Text = dgvCourses.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
            Txt_Maxdeg.Text = dgvCourses.Rows[e.RowIndex].Cells["MaxDegree"].FormattedValue.ToString();
            txt_minDeg.Text = dgvCourses.Rows[e.RowIndex].Cells["MinDegree"].FormattedValue.ToString();
            var instructor = context.Instructors.FirstOrDefault(I => I.User_Name == username);
            comBox_Instructors.SelectedItem = instructor;
        }

        private void btn_UpdateCourse_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txt_Id.Text);
            var course = context.Courses.SingleOrDefault(C => C.Id == id);
            course.Name = Txt_Name.Text;
            course.Description = Txt_Desc.Text;
            course.MaxDegree = int.Parse(Txt_Maxdeg.Text);
            course.MinDegree = int.Parse(txt_minDeg.Text);
            course.Instructor = (Instructor)comBox_Instructors.SelectedItem;
            try
            {
                course.Name = Txt_Name.Text;
                course.Description = Txt_Desc.Text;
                course.MaxDegree = int.Parse(Txt_Maxdeg.Text);
                course.MinDegree = int.Parse(txt_minDeg.Text);
                course.Instructor = (Instructor)comBox_Instructors.SelectedItem;
                context.SaveChanges();
                FillDataGridView();
                Clear();
                Message = "Course Updated Successfully!";
                IsSuccessful = true;
                grBoxCourseInfo.Visible = false;
            }
            catch(Exception ex)
            {
                Message = ex.Message;
                IsSuccessful = false;
            }
            if (this.IsSuccessful)
                MessageBox.Show(this.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_DeleteCourse_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txt_Id.Text);
            var course = context.Courses.Find(id);
            try
            {
                context.Courses.Remove(course);
                context.SaveChanges();
                Clear();
                FillDataGridView();
                IsSuccessful = true;
                Message = "Course Deleted Successfully!";
                grBoxCourseInfo.Visible = false;
            }
            catch(Exception ex)
            {
                Message = ex.Message;
                IsSuccessful = false;
            }

            if (this.IsSuccessful)
                MessageBox.Show(this.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
