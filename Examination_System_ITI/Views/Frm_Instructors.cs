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
        public DataGridView Instructors_Dgv
        {
            get { return this.dgvInstructors; }   
            set { dgvInstructors = value; }
        }

        public ComboBox comBox_Instructors
        {
            get { return comBox_Supervisor; }
            set { comBox_Supervisor = value; }
        }
        public Frm_Instructors()
        {
            InitializeComponent();   
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
                        Branch = (Branch)comBox_Branch.SelectedValue,
                        Role = new Role { UserRole = "Instructor" },
                        Supervisor = comBox_Supervisor.SelectedValue as Instructor
                    }
                ) ;
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
    }
}
