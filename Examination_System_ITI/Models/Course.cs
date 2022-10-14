using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Models
{
    [Table ("Course")] 
    public class Course
    {
        static Context context;
        public static bool IsSuccessful;
        public static string Message;
        static Course()
        {
            context = new Context();
            IsSuccessful = false;
            Message = "";
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxDegree { get; set; }
        public int MinDegree { get; set; }

        public virtual ICollection<Question_Bank> Questions { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }

        public virtual Instructor Instructor { get; set; }

        public static int CoursesCount()
        {
            return context.Courses.Count();
        }

        public static void AddCourse(Course course)
        {
            try
            {
                if (course.Name != String.Empty)
                {
                    var c = context.Courses.FirstOrDefault(a => a.Name.Equals(course.Name));
                    if (c == null)
                    {
                        context.Courses.Add(course);
                        context.SaveChanges();
                        IsSuccessful = true;
                        Message = "Course Added Successfully!";
                    }
                    else
                    {
                        Message = "This Course Is Existed!";
                        IsSuccessful = false;
                    }
                }
                else
                {
                    IsSuccessful = false;
                    Message = "Name Can't Be Empty!";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                IsSuccessful = false;
            }

        }
        public static IList<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            courses = context.Courses.ToList();
            return courses;
        }

        public static IList<Course> GetAllByValue(string value)
        {
            return context.Courses.Where(C => C.Name.Contains(value) || C.Description.Contains(value)).ToList();

        }
    }
}
