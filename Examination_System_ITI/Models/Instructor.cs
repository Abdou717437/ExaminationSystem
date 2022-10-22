using Examination_System_ITI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models

{
    [Table ("Instructor")]
    public class Instructor : User
    {
        static Context context;
        static Instructor()
        {
            context = new Context();
            IsSuccessful = false;
            Message = "";
        }

        [Required, MaxLength(14)]
        public string National_Id { get; set; }

        [Required, MaxLength(20)]
        public string F_Name { get; set; }


        [Required, MaxLength(20)]
        public string L_Name { get; set; }

        [MaxLength(14),MinLength(11)]
        public string Phone { get; set; }

        public string Email { get; set; }

        public int? BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public int? SupervisorId { get; set; }
        public virtual Instructor Supervisor { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public static int InstructorsCount()
        {
            return context.Instructors.Count();
        }

        #region Methods
        public static void AddInstructor(Instructor instructor, Frm_Instructors frm)
        {
            if (instructor.F_Name == String.Empty)
            {
                Message = "First Name Can't Be Empty!";
                IsSuccessful = false;
            }
            else if (instructor.L_Name == String.Empty)
            {
                Message = "Last Name Can't Be Empty!";
                IsSuccessful = false;
            }
            else if (instructor.User_Name == String.Empty)
            {
                Message = "Username Can't Be Empty!";
                IsSuccessful = false;
            }
            else if (instructor.Password == String.Empty)
            {
                Message = "Password Can't Be Empty!";
                IsSuccessful = false;
            }
            else if (instructor.Email == String.Empty )
            {
                Message = "Email Can't Be Empty!";
                IsSuccessful = false;
            }
            else if (instructor.National_Id == String.Empty)
            {
                Message = "NID Can't Be Empty!";
                IsSuccessful = false;
            }
            else
            {
                try
                {
                    context.Instructors.Add(instructor);
                    context.SaveChanges();
                    IsSuccessful = true;
                    Message = "Instructor Added Successfully!";
                }
                catch (Exception ex)
                {
                    IsSuccessful = false;
                    Message = ex.Message;
                }

            }
        }

        public static void GetAllInstructors(Frm_Instructors frm)
        {
            frm.Instructors_Dgv.DataSource=
            frm.Instructor_ComBox.DataSource =
                context.Instructors.Select(I => new 
                    {
                        Id = I.Id ,Name = I.F_Name + " " +I.L_Name,Username = I.User_Name,
                        NID = I.National_Id, Phone = I.Phone, Email = I.Email, Branch = I.Branch.Name,
                        Supervisor  = I.Supervisor ,
                }).ToList();
            frm.Instructors_Dgv.Refresh();
            frm.Instructor_ComBox.ValueMember = "Id";
            frm.Instructor_ComBox.DisplayMember = "Username";
        }

        public static void GetAllByValue(string value, Frm_Instructors frm)
        {
            frm.Instructors_Dgv.DataSource =
                context.Instructors.Where(I => I.F_Name.Contains(value) ||
                                            I.L_Name.Contains(value))
                                            .Select(I => new
                                            {
                                                Id = I.Id,
                                                Name = I.F_Name + " " + I.L_Name,
                                                Username = I.User_Name,
                                                NID = I.National_Id,
                                                Phone = I.Phone,
                                                Email = I.Email,
                                                Branch = I.Branch.Name,
                                                Supervisor = I.Supervisor.User_Name
                                            }).ToList();

            frm.Instructors_Dgv.Refresh();
        }

        public static Instructor GetInstructor(int Id)
        {
            return context.Instructors.Find(Id);
        }

        #endregion
    }
}
