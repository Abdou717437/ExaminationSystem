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
    public partial class MainFrm : Form
    {
        private Button currentBtn;
        private Form activeForm;

        public MainFrm()
        {
            InitializeComponent();
            ActivateButton(dashboardBtn);
            this.MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            if (User.CurrentUser.Role.UserRole == "Student")
            {
                lbl_Branches.Visible = false;       label5.Visible = false;
                Lbl_Tracks.Visible = false;         label3.Visible = false;
                Lbl_Instructors.Visible = false;    label4.Visible = false;
                Lbl_Exams.Visible = false;          label2.Visible = false;
                Lbl_Courses.Visible = false;        label1.Visible = false;
                Lbl_Students.Visible = false;       label10.Visible = false;
                label12.Visible = true; label8.Visible = true;
                LblStudentName.Visible = true; LblStudentTrack.Visible = true;
                OpenChildForm(new Views.StudentDashboard(), this.dashboardBtn);
            }
            else
            {
                lbl_Branches.Visible = true; label5.Visible = true;
                Lbl_Tracks.Visible = true; label3.Visible = true;
                Lbl_Instructors.Visible = true; label4.Visible = true;
                Lbl_Exams.Visible = true; label2.Visible = true;
                Lbl_Courses.Visible = true; label1.Visible = true;
                Lbl_Students.Visible = true; label10.Visible = true;
                label12.Visible = false; label8.Visible = false;
                LblStudentName.Visible = false; LblStudentTrack.Visible = false;
                OpenChildForm(new Views.InstructorDashboard(), this.dashboardBtn);

            }
        }

        #region Methods For Manipulating Navigation Buttons

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableButton();
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = Color.FromArgb(169, 39, 45);
                    currentBtn.ForeColor = Color.FromArgb(255,255,255);
                    currentBtn.Font = new Font("Verdana", 11.8F, System.Drawing.FontStyle.Regular);
                    translatePanel.Height = currentBtn.Height;
                    translatePanel.Top = currentBtn.Top;
                    translatePanel.Left = currentBtn.Left;
                    pageTitleLbl.Text = currentBtn.Text;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control prevButton in navigationPanel.Controls)
            {
                if (prevButton.GetType() == typeof(Button))
                {
                    prevButton.BackColor = Color.Transparent;
                    prevButton.ForeColor = Color.White;
                    prevButton.Font = new Font("Verdana", 11.8F, System.Drawing.FontStyle.Bold);
                }
            }
        }
        #endregion

        #region Methods For Manipulating Forms


        private void OpenChildForm(Form childFrm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childFrm;
            childFrm.TopLevel = false;
            childFrm.FormBorderStyle = FormBorderStyle.None;
            childFrm.Dock = DockStyle.Fill;
            this.ContainerPanel.Controls.Add(childFrm);
            this.ContainerPanel.Tag = childFrm;
            childFrm.BringToFront();
            childFrm.Show();
        }
        #endregion
        private void MainFrm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = User.CurrentUser.User_Name;
            lblUserTitle.Text = User.CurrentUser.Role.UserRole;
            switch (User.CurrentUser.Role.UserRole)
            {
                case "Admin":
                    lbl_Branches.Text = Branch.BranchesCount().ToString();
                    Lbl_Courses.Text = Course.CoursesCount().ToString();
                    Lbl_Instructors.Text = Instructor.InstructorsCount().ToString();
                    Lbl_Exams.Text = Exam.ExamsCount().ToString();
                    Lbl_Tracks.Text = Track.TracksCount().ToString();
                    Lbl_Students.Text = Student.StudentsCount().ToString();
                    break;
                case "Branch Manager":

                    break;
                case "Track Manager":

                    break;
                case "Supervisor":

                    break;
                case "Student":
                    btnHandleExams.Visible = false;
                    btnHandleStds.Visible = false;
                    btnInstructors.Visible = false;
                    btnBranches.Text = "My Results";
                    btnReports.Visible = false;
                    btnMngIntakes.Visible = false;
                    break;
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (User.CurrentUser.Role.UserRole == "Student")
                OpenChildForm(new Views.StudentDashboard(), this.dashboardBtn);
            else
                OpenChildForm(new Views.InstructorDashboard(), this.dashboardBtn);
        }

        private void btnHandleStds_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FrmStudents(), this.btnHandleStds);
        }

        private void btnHandleExams_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (User.CurrentUser.Role.UserRole != "Student")
                OpenChildForm(new Views.ExamListFrm(), this.btnHandleExams);
        }

        private void btnBranches_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Frm_Branches(), sender);
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Frm_Instructors(), sender);
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Views.Frm_Course(), sender);
        }

        private void btnMngIntakes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Frm_Intakes(), sender);
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Frm_Results(), sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Frm_Tracks(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Logout Completed Successfully","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Login_Frm frm = new Login_Frm();
                frm.Show();
            }
            
        }

    }
}
