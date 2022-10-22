using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System_ITI.Views
{
    enum TimeAlloed { Half = 0,Hour = 1, TowHours = 2,ThreeHours = 3}
    public partial class CreateExam_Frm : Form
    {
        Context _context;
        IList<Student> ExamedStudents { get; set; }
        IList<Exam_Question> ExamQuestions { get; set; }

        Exam exam;
        int QuestionPoints  { get; set; }
        public ListBox Questions_ListBox
        {
            get { return ListBox_CourseQuestions; }
            set { ListBox_CourseQuestions = value; }
        }

        public ListBox ExamQuestions_ListBox
        {
            get { return listBox_ExamQuestions; }
            set { ListBox_CourseQuestions = value; }
        }
        public CreateExam_Frm()
        {
            InitializeComponent();
            _context = new Context();
            ExamedStudents = new List<Student>();
            ExamQuestions = new List<Exam_Question>();
            exam = new Exam();
        }


        private void CreateExam_Frm_Load(object sender, EventArgs e)
        {
            combBox_Tracks.DataSource = _context.Tracks.ToList();
            comboBox_Courses.DataSource = _context.Courses.ToList();//Where(C => C.Instructor.Id == User.CurrentUser.Id);
            combBox_Tracks.ValueMember = "Id";
            comboBox_Courses.ValueMember = "Id";
            comboBox_Courses.DisplayMember = "Name";
            combBox_Tracks.DisplayMember = "Name";
            txt_Code.Text = RandomString(6, false);

            comBox_TimeAllowed.DataSource = Enum.GetValues(typeof(TimeAlloed));
            dateTimePicker1.Format = DateTimePickerFormat.Time;
        }

        private void comboBox_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = (int)comboBox_Courses.SelectedValue;
               
            var query = _context.Questions.Where(Q => Q.CourseId == Id).ToList();
            Questions_ListBox.Items.Clear();
            foreach (var question in query)
                Questions_ListBox.Items.Add(question);
            Questions_ListBox.Refresh();
            Questions_ListBox.DisplayMember = "Body";
            Questions_ListBox.ValueMember = "Id";
            ExamQuestions_ListBox.ValueMember = "Id";
            ExamQuestions_ListBox.DisplayMember = "Body";
        }

        private void combBox_Tracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)combBox_Tracks.SelectedValue;
            ExamedStudents = _context.Students.Where(s => s.TrackId == id).ToList();

            var query = _context.Courses
                .Where(C => C.Tracks
                .Any(T => T.Id == id))
                .ToList();
            if (query.Count > 0)
            {
                comboBox_Courses.DataSource = query;
                comboBox_Courses.DisplayMember = "Name";
                comboBox_Courses.ValueMember = "Id";
            }
            else
            {
                comboBox_Courses.DataSource = null;
                comboBox_Courses.SelectedText = "Have No Courses";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Type = comboBox1.SelectedIndex;
            int Id = (int)comboBox_Courses.SelectedValue;
            if (Type < 3)
            {
                var questions = _context.Questions.Where(Q => Q.CourseId == Id && Q.Type == Type).ToList();
                Questions_ListBox.Items.Clear();
                foreach (var q in questions)
                    Questions_ListBox.Items.Add(q);
                Questions_ListBox.Refresh();
            }
            else
            {
                var questions = _context.Questions.Where(Q => Q.CourseId == Id).ToList();

                foreach (var q in questions)
                    Questions_ListBox.Items.Add(q);
            }

        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            AddRemoveQuestions(ListBox_CourseQuestions, listBox_ExamQuestions);
        }

        private void btn_RemoveQuestion_Click(object sender, EventArgs e)
        {
            AddRemoveQuestions(listBox_ExamQuestions, ListBox_CourseQuestions);
        }

        public void AddRemoveQuestions(ListBox from, ListBox to)
        {
            var selectedQuestion = from.SelectedItem;
            if (selectedQuestion is null)
                return;

            int index = from.SelectedIndex;
            from.Items.RemoveAt(index);
            to.Items.Add(selectedQuestion);
            if (index >= from.Items.Count) index--;
            from.SelectedIndex = index;
        }

        public string RandomString(int size, bool lowerCase = false)
        {
            Random random = new Random();
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26;
            for (var i = 0; i < size; i++)
            {
                var @char = random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }
            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }



        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(txt_Code.Text is null)
            {
                MessageBox.Show("Code Can Not Be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else if(txt_Name.Text is null)
            {
                MessageBox.Show("Exam Name Is Required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else if(listBox_ExamQuestions.Items.Count < 1)
            {
                MessageBox.Show("Insert Some Questions!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else if(combBox_Tracks.SelectedItem is null)
            {
                MessageBox.Show("Please Select The Track Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }else
            {
                int Id = (int)comboBox_Courses.SelectedValue;

                QuestionPoints = _context.Courses.Find(Id).MaxDegree / listBox_ExamQuestions.Items.Count;
              
                exam.Code = RandomString(6, false);
                exam.St_Time = dateTimePicker1.Value;
                exam.InstructorId = User.CurrentUser.Id;
                exam.Course = (Course)comboBox_Courses.SelectedItem;
                exam.Exam_Type = false;
                _context.Exams.Add(exam);
                try
                {
                    _context.SaveChanges();
                }
                catch (DbEntityValidationException ev)
                {
                    foreach (var eve in ev.EntityValidationErrors)
                    {
                        MessageBox.Show("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name + eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            MessageBox.Show("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName + ve.ErrorMessage);
                        }
                    }
                }
                using (var context = new Context())
                {
                    try
                    { 
                    var Exam = _context.Exams.Where(E => E.Code == exam.Code).FirstOrDefault();
                    var Track = (Track)combBox_Tracks.SelectedItem;
                    var StudentsForExam = _context.Students.Where(S => S.TrackId == Track.Id).ToList();
                    Exam.Students = StudentsForExam;
                    foreach (Question_Bank q in listBox_ExamQuestions.Items)
                    {

                        Exam.Exam_Questions.Add(
                        new Exam_Question
                        {
                            Question_Bank = q,
                            Points = QuestionPoints
                        });
                    }
                    context.SaveChanges();
                        MessageBox.Show("Exam Added Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show(ex.Message);
                    }
                }

            }
    }

        private void comBox_TimeAllowed_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeAlloed time = (TimeAlloed) comBox_TimeAllowed.SelectedItem;
            if (time == TimeAlloed.Half)
                exam.En_Time = dateTimePicker1.Value.AddMinutes(30);
            else if(time == TimeAlloed.Hour)
                exam.En_Time = dateTimePicker1.Value.AddHours(1);
            else if(time == TimeAlloed.TowHours)
                exam.En_Time = dateTimePicker1.Value.AddHours(2);
            else
                exam.En_Time = dateTimePicker1.Value.AddHours(3);
            MessageBox.Show(exam.En_Time.ToString());
        }

        private void Txt_Id_TextChanged(object sender, EventArgs e)
        {
            exam.Id = int.Parse(Txt_Id.Text);
        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            exam.Name = txt_Name.Text;
        }
        private void Clear()
        {
            txt_Name.Text = Txt_Id.Text =String.Empty;
            combBox_Tracks.SelectedIndex = -1;
            comboBox_Courses.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            listBox_ExamQuestions.Items.Clear();
            ListBox_CourseQuestions.Items.Clear();
        }
    }
}
