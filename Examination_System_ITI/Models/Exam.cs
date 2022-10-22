using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Exam
    {
        static Context context;
        public static bool IsSuccessful;
        public static string Message;

        static Exam()
        {
            context = new Context();
            IsSuccessful = true;
            Message = "";
        }

        public int Id { get; set; }

        [MaxLength(100),MinLength(10),Required]
        public string Code { get; set; }
        
        [MaxLength(50),MinLength(10),Required]
        public string Name { get; set; }

        [Required]
        public DateTime St_Time { get; set; }
        public DateTime En_Time { get; set; }

        [Required]
        public bool Exam_Type { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public ICollection<Exam_Result> Exam_Results { get; set; } = new HashSet<Exam_Result>();

        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        public ICollection<Exam_Question> Exam_Questions { get; set; } = new HashSet<Exam_Question>();

        public static int ExamsCount()
        {
            return context.Exams.Count();
        }

        #region Methods

        public static void AddExam(Exam exam)
        {
            try
            {
                    var c = context.Courses.FirstOrDefault(a => a.Name.Equals(exam.Name));
                    if (c == null)
                    {
                        context.Exams.Add(exam);
                        context.SaveChanges();
                        IsSuccessful = true;
                        Message = "Course Added Successfully!";
                    }
                    else
                    {
                        Message = "The Exam Name !";
                        IsSuccessful = false;
                    }
              
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                IsSuccessful = false;
            }

        }
        public static IList<Exam> GetAllExams()
        {

            return context.Exams.ToList();

        }

        public static IList<Exam> GetAllByValue(string value)
        {
            return context.Exams.Where(E => E.Name.Contains(value) || E.Instructor.User_Name.Contains(value)).ToList();
        }
        #endregion

    }
}
