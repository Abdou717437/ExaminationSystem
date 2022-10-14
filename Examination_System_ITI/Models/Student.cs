using Examination_System_ITI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : User
    {
        static Context context;

        static Student()
        {
            context = new Context();
        }
        public Student()
        {
            Student_Answers = new HashSet<Student_Answer>();
            Exams = new HashSet<Exam>();
            Results = new HashSet<Exam_Result>();
        }
        [Required, MaxLength(10)]
        public string F_Name { get; set; }

        [Required, MaxLength(10)]
        public string L_Name { get; set; }

        //[Required, MaxLength(14)]
        public string N_ID { get; set; }

        public DateTime DOB { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Student_Answer> Student_Answers { get; set; }

        public virtual ICollection<Exam_Result> Results { get; set; }

        public int? TrackId { get; set; }
        public virtual Track Track { get; set; }
        
        public static int StudentsCount()
        {
            return context.Students.Count();
        }

        #region Add Student Method
        public static void AddStudent(Student student)
        {
            if(student.F_Name == String.Empty)
            {
                Message = "First Name Can't Be Empty!";
                IsSuccessful = false;
            }
            else if(student.L_Name == String.Empty)
            {
                Message = "Last Name Can't Be Empty!";
                IsSuccessful = false;
            }
            else if(student.User_Name == String.Empty)
            {
                Message = "Username Can't Be Empty!";
                IsSuccessful = false;
            }
            else if(student.Password == String.Empty)
            {
                Message = "Password Can't Be Empty!";
                IsSuccessful = false;
            }
            else if (student.Email == String.Empty)
            {
                Message = "Email Can't Be Empty!";
                IsSuccessful = false;
            }
            else if (student.N_ID == String.Empty)
            {
                Message = "NID Can't Be Empty!";
                IsSuccessful = false;
            }
            else
            {
                try
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    IsSuccessful = true;
                    Message = "Student Added Successfully!";
                }
                catch(Exception ex)
                {
                    IsSuccessful = false;
                    Message = ex.Message;
                }

            }
        }
        #endregion

        public static void GetAllStudents( FrmStudents frm)
        {
            frm.Students_Dgv.DataSource =
            frm.Tracks_ComBox.DataSource =
                context.Instructors.Where(I => I.Role.UserRole == "Student").Select(I => new
               
                {
                    Id = I.Id,
                    Name = I.F_Name + " " + I.L_Name,
                    Username = I.User_Name,
                    NID = I.National_Id,
                    Phone = I.Phone,
                    Email = I.Email,
                    Branch = I.Branch.Name,
                    Supervisor = I.Supervisor,
                }).ToList();
            frm.Students_Dgv.Refresh();
            frm.Tracks_ComBox.ValueMember = "Id";
            frm.Tracks_ComBox.DisplayMember = "Username";
        }

        public static IList<Student> GetAllByValue(string value)
        {
            var students = context.Students.Where(c => c.F_Name == value).ToList();
            return students;
        }
    }
}
