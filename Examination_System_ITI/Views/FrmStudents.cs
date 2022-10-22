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
        Track track;
        Context context;

        public DataGridView Students_Dgv
        {
            get { return dgvStudents; }
            set { dgvStudents = value; }

        }
        public FrmStudents()
        {
            InitializeComponent();
            Students = new List<Student>();
            track = new Track();
            context = new Context();
            student = new Student();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grBoxStudentsInfo.Visible = false;
            dgvStudents.Location = new Point(0, 140);
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            comBox_Track.DataSource = context.Tracks.ToList();
            comBox_Track.DisplayMember = "Name";
            comBox_Track.ValueMember = "Id";
            grBoxStudentsInfo.Visible = false;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            grBoxStudentsInfo.Visible = true;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            student.F_Name = txt_Fname.Text;
            student.L_Name = txt_LName.Text;
            student.User_Name = txt_UserName.Text;
            student.Password = txt_Password.Text;
            student.N_ID = txt_NID.Text;
            student.DOB = DateTimePick_BD.Value;
            student.Track = (Track)comBox_Track.SelectedItem;
            student.Phone = txt_Phone.Text;
            student.Email = txt_Email.Text;
            MessageBox.Show(student.Track.Name);
            student.Role = new Role { UserRole = "Student" };
            if (student.F_Name == String.Empty)
                MessageBox.Show("First Name Can't Be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (student.L_Name == String.Empty)
                MessageBox.Show("Last Name Can't Be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (student.User_Name == String.Empty)
                MessageBox.Show("Username Can't Be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (student.Password == String.Empty)
                MessageBox.Show("Password Can't Be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (student.Email == String.Empty)
                MessageBox.Show("Email Can't Be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (student.N_ID == String.Empty)
                MessageBox.Show("NID Can't Be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (student.Track == null)
                MessageBox.Show("Track Can't Be Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    FillDataGridView();
                    MessageBox.Show("Student Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
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
            FillDataGridView();
        }

        private void FillDataGridView()
        {
            dgvStudents.DataSource =
                context.Students.Select(S => new
                {
                    Id = S.Id,
                    Name = S.F_Name + " " + S.L_Name,
                    Username = S.User_Name,
                    NID = S.N_ID,
                    Phone = S.Phone,
                    Email = S.Email,
                    Track = S.Track.Name,
                }).ToList();

            dgvStudents.Refresh();
        }
        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Search.Text != String.Empty)
            {
                FillDataGridView(Txt_Search.Text);
            }
            else
            {
                FillDataGridView();
            }
        }

        private void FillDataGridView(string text)
        {
            dgvStudents.DataSource =
                context.Students.Where(S => S.L_Name.Contains(text)
                                        || S.F_Name.Contains(text)
                                        || S.User_Name.Contains(text))
                .Select(S => new
                {
                    Id = S.Id,
                    Name = S.F_Name + " " + S.L_Name,
                    Username = S.User_Name,
                    NID = S.N_ID,
                    Phone = S.Phone,
                    Email = S.Email,
                    Track = S.Track.Name,
                }).ToList();

            dgvStudents.Refresh();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
