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
    public partial class Frm_Instructors : Form
    {
        Branch branch;
        Instructor supervisor;
        public DataGridView Instructors_Dgv
        {
            get { return this.dgvInstructors; }   
            set { dgvInstructors = value; }
        }

        public ComboBox Instructor_ComBox
        {
            get { return comBox_Supervisor; }
            set { comBox_Supervisor = value; }  
        }

        public ComboBox Branch_ComBox
        {
            get { return comBox_Branch; }
            set { comBox_Branch = value; }
        }
        public Frm_Instructors()
        {
            InitializeComponent();   
            branch = new Branch();
            supervisor = new Instructor();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            grBoxInstructorsInfo.Visible = true;
        }

        private void Frm_Instructors_Load(object sender, EventArgs e)
        {
            grBoxInstructorsInfo.Visible = false;
        }


        #region Methods

        public void Clear()
        {
            txt_Email.Text = txt_Fname.Text = txt_LName.Text = txt_UserName.Text =
            txt_Password.Text = txt_Phone.Text = txt_NID.Text = String.Empty;
            comBox_Branch.SelectedIndex = -1;
            comBox_Supervisor.SelectedIndex = -1;
        }
        #endregion

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            int Branch_id = 0;
            int InstructorId = 0;
            if(comBox_Branch.SelectedValue != null)
                Branch_id = (int)comBox_Branch.SelectedValue;
            if(comBox_Supervisor.SelectedValue != null)
                InstructorId = (int)comBox_Supervisor.SelectedValue;
            
            supervisor = Instructor.GetInstructor(InstructorId);
            branch = Branch.GetBranch(Branch_id);
            Instructor.AddInstructor(
                    new Instructor()
                    {
                        F_Name = txt_Fname.Text,
                        L_Name = txt_LName.Text,
                        User_Name = txt_UserName.Text,
                        Password = txt_Password.Text,
                        National_Id = txt_NID.Text,
                        Phone = txt_Phone.Text,
                        Email = txt_Email.Text,
                        Role = new Role { UserRole = "Instructor" },
                        Branch = branch,
                        Supervisor = supervisor,
                    }
                , this) ;
            Instructor.GetAllInstructors(this);
            if (Instructor.IsSuccessful)
                MessageBox.Show(Instructor.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(Instructor.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grBoxInstructorsInfo.Visible = false;
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            if(Txt_Search.Text != String.Empty)
            {
                Instructor.GetAllByValue(Txt_Search.Text,this);
            }
            else
            {
                Instructor.GetAllInstructors(this);
            }
        }

        private void Frm_Instructors_Shown(object sender, EventArgs e)
        {
            Instructor.GetAllInstructors(this);
        }

        private void comBox_Supervisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor_ComBox = comBox_Supervisor;
        }

        private void comBox_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch_ComBox = comBox_Branch;
        }
    }
}
