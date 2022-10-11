using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ExaminationSystemDB;Integrated Security=true;");
        SqlCommand cmd;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ID(object sender, EventArgs e)
        {

        }

        private void Name_of_Exam(object sender, EventArgs e)
        {

        }

        private void Code(object sender, EventArgs e)
        {

        }

        private void Exam_type(object sender, EventArgs e)
        {

        }

        private void Create(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand("insert into Exams(Code,Name,St_Time,En_Time,Exam_Type,Course_Id,Instructor_Id) values (@code,@name,@start_time,@end_time,@exam_type,@course_id,@inst_id)", conn);
                conn.Open();

                
                cmd.Parameters.AddWithValue("@code", Code_txt.Text);
                cmd.Parameters.AddWithValue("@name", NameExam.Text);
                cmd.Parameters.AddWithValue("@start_time", start.Text);
                cmd.Parameters.AddWithValue("@end_time", end.Text);
                cmd.Parameters.AddWithValue("@exam_type", ExamType.Text);
                cmd.Parameters.AddWithValue("@course_id", Course.Text);
                cmd.Parameters.AddWithValue("@inst_id", Inst.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error , please try again later." + ex.Message);

            }
        }

        private void update(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("update Exams set Code=@code,Name=@name,St_Time=@start_time,En_Time=@end_time where ID=@id", conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@id", ID_txt.Text);
                cmd.Parameters.AddWithValue("@code", Code_txt.Text);
                cmd.Parameters.AddWithValue("@name", NameExam.Text);
                cmd.Parameters.AddWithValue("@start_time", start.Text);
                cmd.Parameters.AddWithValue("@end_time", end.Text);
                cmd.Parameters.AddWithValue("@exam_type", ExamType.Text);
                cmd.Parameters.AddWithValue("@course_id", Course.Text);
                cmd.Parameters.AddWithValue("@inst_id", Inst.Text);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error , please try again later." + ex.Message);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseID(object sender, EventArgs e)
        {

        }

        private void InstructorID(object sender, EventArgs e)
        {

        }

        private void start_time(object sender, EventArgs e)
        {

        }

        private void end_time(object sender, EventArgs e)
        {

        }

       
    }
}
//try { 
//    //SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=OnlineExamination_DB;Integrated Security=true;");
//    conn.Open();
//    SqlCommand cmd = new SqlCommand("insert into Exams values( '" + Code_txt.Text + "', '" + NameExam.Text + "', '" + start.Text + "', ' " + end.Text + "','" + ExamType.Text + "', ' " + Course.Text + "', ' " + Inst.Text +"')", conn);
//    cmd.ExecuteNonQuery();
//    MessageBox.Show("Data Inserted Successfully.");
//    conn.Close();
//}

//catch(Exception ex)
//{
//    MessageBox.Show(ex.Message);    
//}