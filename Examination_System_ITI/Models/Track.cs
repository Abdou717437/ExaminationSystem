using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_System_ITI.Views;

namespace Models
{
    [Table ("Track")]
    public class Track
    {
        static Context context;
        public static bool IsSuccessful;
        public static string Message;

        static Track()
        {
            context = new Context();
            IsSuccessful = false;
            Message = "";
        }
        public Track()
        {
            Students = new HashSet<Student>();
            Courses = new HashSet<Course>();
            Intakes = new HashSet<Intake>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Intake> Intakes { get; set; }

        public static int TracksCount()
        {
            return context.Tracks.Count();
        }

        public static void AddTrack(Track track, IList<Course> courses)
        {
            if(track.Name == String.Empty)
            {
                IsSuccessful = false;
                Message = "Track Name Can't Be Empty";
            }
            else if(track.Instructor == null)
            {
                Message = "Please Determine Track Manager";
                IsSuccessful = false;
            }
            else
            {
                try
                {
                    context.Tracks.Add(track);
                    context.SaveChanges();
                    var context2 = new Context();
                    int id = context2.Tracks.FirstOrDefault(T => T.Name == track.Name).Id;
                    AddCoursesToTrack(id,courses);
                    Message = $"Track {track.Name} Added Successfully!";
                    IsSuccessful = true;
                }
                catch(Exception ex)
                {
                    Message = ex.Source.ToString();
                    IsSuccessful = false;
                }
            }
        }

        private static void AddCoursesToTrack(int trackId,IList<Course> courses)
        {
            if(courses != null)
            {
                try
                {
                    var context2 = new Context();
                    foreach(var course in courses)
                        context2.Tracks.FirstOrDefault(T => T.Id == trackId).Courses.Add(course);
                    IsSuccessful = true;
                    context2.SaveChanges();
                }
                catch (Exception ex)
                {
                    Message = ex.Message;
                    IsSuccessful = false;
                }
            }
        }

        public static void GetAllTracks(Frm_Tracks frm)
        {
            frm.Tracks_Dgv.DataSource =
                context.Tracks.Select(T => new
                {
                    Id = T.Id,
                    Name = T.Name,
                    Description = T.Description,
                    Manager = T.Instructor.User_Name
                }).ToList();
            frm.Tracks_Dgv.Refresh();
        }
        public static void GetTracksByValue(string value,Frm_Tracks frm)
        {
            frm.Tracks_Dgv.DataSource =
                context.Tracks.Where(T => T.Name.Contains(value) || T.Description.Contains(value)).Select(T => new
                {
                    Id = T.Id,
                    Name = T.Name,
                    Description = T.Description,
                    Manager = T.Instructor.User_Name
                }).ToList();

            frm.Tracks_Dgv.Refresh();
        }

        public static Track GetTrack(int Id)
        {
            return context.Tracks.Find(Id);
        }
        public static void GetTracksManagers(Frm_Tracks frm)
        {
            frm.Manager_Combox.DataSource = context.Instructors.ToList();
            frm.Manager_Combox.ValueMember = "Id";
            frm.Manager_Combox.DisplayMember = "User_Name";

        }

    }
}
