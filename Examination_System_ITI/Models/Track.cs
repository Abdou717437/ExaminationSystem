using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Branches = new HashSet<Branch>();
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

        public virtual ICollection<Branch> Branches { get; set; }

        public static int TracksCount()
        {
            return context.Tracks.Count();
        }

        public static IList<Track> GetAllTracks()
        {
            return context.Tracks.ToList();
        }

        public static void AddTrack(Track track)
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
                    Message = $"Track {track.Name} Added Successfully!";
                    IsSuccessful = true;
                }
                catch(Exception ex)
                {
                    Message = ex.Message;
                    IsSuccessful = false;
                }
            }
        }

        public static IList<Track> GetTracksByValue(string value)
        {
            return context.Tracks.Where(T => T.Name.Contains(value) || T.Description.Contains(value)).ToList();
        }

    }
}
