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
    public partial class FrmStudents : Form
    {
        IList<Student> Students;
        Student student;

        public DataGridView Students_Dgv
        {
            get { return dgvStudents; }
            set { dgvStudents = value; }

        }

        public ComboBox Tracks_ComBox
        {
            get { return comBox_Track; }
            set { comBox_Track = value; }
        }
        public FrmStudents()
        {
            InitializeComponent();
            Students = new List<Student>();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grBoxStudentsInfo.Visible = false;
            dgvStudents.Location = new Point(0, 140);
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {

            grBoxStudentsInfo.Visible = false;
            dgvStudents.Location = new Point(0, 140);
            comBox_Track.DataSource = Models.Track.GetAllTracks();
            comBox_Track.ValueMember = "Id";
            comBox_Track.DisplayMember = "Name";
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            grBoxStudentsInfo.Visible = true;
            dgvStudents.Location = new Point(0, 408);
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Student.AddStudent(new Student
            {
                F_Name = txt_Fname.Text,
                L_Name = txt_Fname.Text,
                User_Name = txt_UserName.Text,
                Password = txt_Password.Text,
                N_ID = txt_NID.Text,
                DOB = DateTimePick_BD.Value,
                Track = (Track)comBox_Track.SelectedValue,
                Phone = txt_Phone.Text,
                Email = txt_Email.Text,
                Role = new Role { UserRole = "Student" }
        });
            Student.GetAllStudents(this);
            if (Course.IsSuccessful)
                MessageBox.Show(Student.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Student.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        
        public void Clear()
        {
            txt_Email.Text = txt_Fname.Text = txt_LName.Text = txt_UserName.Text =
            txt_Password.Text = txt_Phone.Text = txt_NID.Text = String.Empty;
            DateTimePick_BD.ResetText();
            comBox_Track.SelectedIndex = -1;
        }
        private void FrmStudents_Shown(object sender, EventArgs e)
        {
            Student.GetAllStudents(this);
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            Student.GetAllByValue(Txt_Search.Text);

            if (Txt_Search.Text == String.Empty)
            {
                Student.GetAllStudents(this);
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
