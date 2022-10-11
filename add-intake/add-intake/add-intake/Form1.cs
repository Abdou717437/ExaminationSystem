using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using System.Data.Common;
using System.Runtime.Remoting.Messaging;
using add_intake;

namespace add_intake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=ExaminationSystemDB;Integrated Security=true;");
        SqlCommand cmd;
        //SqlDataReader dreader;

        private void Add_Id(object sender, EventArgs e)
        {

        }

        private void Add_Name(object sender, EventArgs e)
        {

        }

        private void Add_Start_Month(object sender, EventArgs e)
        {

        }

        private void Add_End_Month(object sender, EventArgs e)
        {

        }

        private void Create(object sender, EventArgs e)
        {
            #region try
            //try
            //{

            //    //SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=OnlineExamination_DB;Integrated Security=true;");
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("insert into Intake values('" + NameIntake.Text + "', '" + Start_Month.Text + "', '" + End_Month.Text + "', ' " + Branch_ID.Text + "')", conn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Data Inserted Successfully.");
            //    conn.Close();
            //}

            //catch(Exception ex)
            //{
            //    MessageBox.Show("An Error , please try again later." + ex.Message);

            //}
            //try
            //{
            //    cmd = new SqlCommand("insert into Intake(Name,Start_Date,End_Date,Branch_Id) values (@name,@start_time,@end_time,@branchId)", conn);
            //    conn.Open();
            //    cmd.Parameters.AddWithValue("@name", NameIntake.Text);
            //    cmd.Parameters.AddWithValue("@start_time", Start_Month.Text);
            //    cmd.Parameters.AddWithValue("@end_time", End_Month.Text);
            //    cmd.Parameters.AddWithValue("@branchId", Branch_ID.Text);
            //    cmd.ExecuteNonQuery();
            //    conn.Close();
            //    MessageBox.Show("Record Inserted Successfully");
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("An Error , please try again later." + ex.Message);

            //} 
            #endregion

           
            

        }

        private void update(object sender, EventArgs e)
        {
            #region update
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("update Intake set Name = '" + NameIntake.Text + "',Start_Date = '" + Start_Month.Text + "',End_Date = '" + End_Month.Text + "' where ID='" + ID.Text + "'", conn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Data Updated Successfully.");
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An Error , please try again later." + ex.Message);
            //}

            //try { 
            //cmd = new SqlCommand("update Intake set Name=@name,Start_Date=@start_time,End_Date=@end_time,Branch_Id=@branchId where ID=@id", conn);
            //conn.Open();
            //cmd.Parameters.AddWithValue("@id", ID.Text);
            //cmd.Parameters.AddWithValue("@name", NameIntake.Text);
            //cmd.Parameters.AddWithValue("@start_time", Start_Month.Text);
            //cmd.Parameters.AddWithValue("@end_time", End_Month.Text);
            //cmd.Parameters.AddWithValue("@branchId", Branch_ID.Text);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Record Updated Successfully");
            //conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An Error , please try again later." + ex.Message);
            //}

            #endregion

            Intake take = new Intake();
            take.Id = Convert.ToInt32(ID.Text);
            take.Name = NameIntake.Text;
            take.Start_Date = Start_Month.Text; 
            take.End_Date = End_Month.Text;

        }

        private void delete(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete Intake where ID=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
            }

            catch(Exception ex)
            {
                MessageBox.Show("An Error , please try again later." + ex.Message);

            }
        }

        private void BranchID(object sender, EventArgs e)
        {

        }
    }   }  

    



//try
//{
//    conn.Open();
//    SqlCommand cmd = new SqlCommand("delete Intake where ID='" + ID.Text + "'", conn);
//    cmd.ExecuteNonQuery();
//    MessageBox.Show("Data Deleted Successfully.");
//    conn.Close();
//}

//catch (Exception ex)
//{
//    MessageBox.Show("An error has occurred, please try again later." + ex.Message);
//}



//     //    cmd.ExecuteNonQuery();
//            //    MessageBox.Show("Data Deleted Successfully.");
//            //    conn.Close();
//            if(!(ID.Text == string.Empty))
//            {
//                conn.Open();
//                SqlCommand cmd = new SqlCommand("delete Intake where ID='" + ID.Text + "'", conn);
//    SqlDataReader reader;
//    conn.Close();
//                try
//                {
//                    conn.Open();
//                    reader = cmd.ExecuteReader();
//                    MessageBox.Show("successfully data Deleted", "user information");
//                    while (reader.Read())
//                    {
//                    }
//conn.Close();
//                }
//                catch (Exception ec)
//{
//    MessageBox.Show(ec.Message);
//}
//            }
//            else
//{
//    MessageBox.Show("enter ID which you want to delete", "User information");
//}
//        }