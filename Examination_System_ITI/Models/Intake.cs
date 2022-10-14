using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models

{
    [Table ("Intake")]
    public class Intake
    {
        static Context context;
        public static bool IsSuccessful;
        public static string Message;
        static Intake()
        {
            context = new Context();
            IsSuccessful = false;
            Message = "";
        }
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public virtual Branch Branch { get; set; }
        
        public virtual ICollection<Track> Tracks { get; set; }


        //Methods 

        public static void AddIntake(Intake intake)
        {
            if (intake == null)
            {
                Message = "Intake Name And Branch Are Required!";
                IsSuccessful = false;
            }
            else if (intake.Name == String.Empty)
            {
                Message = "Intake Name Can't Be Empty!";
                IsSuccessful = false;
            }
            else if (intake.Branch == null)
            {
                Message = "Please Select a Branch";
                IsSuccessful = false;
            }
            else
            {
                try
                {
                    context.Intakes.Add(intake);
                    context.SaveChanges();
                    Message = $"Intake {intake.Name} Added Successfully!";
                }
                catch(Exception ex)
                {
                    Message = ex.Message;
                    IsSuccessful = false;
                }
                
            }
            
        }

        public static IList<Intake> GetAllInataks()
        {
            return context.Intakes.ToList();
        }

        public static IList<Intake> GetIntakesByValue(string value)
        {
            return context.Intakes.Where(I => I.Name.Contains(value) || I.Start_Date.ToString().Contains(value)).ToList();
        }
        public static void UpdateIntake()
        {

        }
             
    }
}
