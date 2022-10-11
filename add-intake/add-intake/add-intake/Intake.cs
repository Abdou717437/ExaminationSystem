using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Data;

namespace add_intake
{
    public class Intake
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
       
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string Message { get; set; }

        public event EventHandler uupdate;

        public void Update()
        {

            using (var connection = new SqlConnection(@"Data Source=.;Initial Catalog=ExaminationSystemDB;Integrated Security=true;"))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Intake set Name=@name,Start_Date=@start_time,End_Date=@end_time where ID=@id";

                command.Parameters.Add("@id", SqlDbType.Int).Value = this.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = this.Name;
                command.Parameters.Add("@start_time", SqlDbType.VarChar).Value = this.Start_Date;
                command.Parameters.Add("@end_time", SqlDbType.VarChar).Value = this.End_Date;
                command.ExecuteNonQuery();
                this.Message = "Record Inserted Successfully";
                //try
                //{
                    
                //    this.Message = "Record Inserted Successfully";
                //}
                //catch(Exception ex)

                //{
                //    this.Message = ex.Message;
                //}
            }
        }

    }
}
