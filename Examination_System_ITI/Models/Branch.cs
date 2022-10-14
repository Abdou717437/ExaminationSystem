using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table ("Branch")]
    public class Branch
    {
        static Context context;
        static bool IsSuccessful;
        static string Message;
        static Branch()
        {
            context = new Context();
            IsSuccessful = false;
            Message = "";
        }
        public int Id { get; set; }

        [Required, MinLength(5), MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }

        public int? InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }


        #region Methods
        public static int BranchesCount()
        {
            return context.Branches.Count();
        }

        public static void AddBranch(Branch branch)
        {
            if(branch is null)
            {
                Message = "Branch Name And Manager Are Required Fields!";
                IsSuccessful = false;
            }
            else if(branch.Name is null)
            {
                Message = "Branch Name Can't be Empty!";
                IsSuccessful=false;
            }
            else if(branch.Instructor is null)
            {
                Message = "Branch Manager Is Required";
                IsSuccessful = false;
            }
            else
            {
                try
                {
                    context.Branches.Add(branch);
                    context.SaveChanges();
                    Message = $"Branch {branch.Name} Added Successfully!";
                    IsSuccessful = true;
                }
                catch(Exception ex)
                {
                    Message = ex.Message;
                    IsSuccessful = false;
                }
            }
        }

        public static IList<Branch> GetAllBranches()
        {
            return context.Branches.ToList();
        }  

        public static IList<Branch> GetBranchesByValue(string value)
        {
            return context.Branches.Where(B => B.Name.Contains(value) || B.Instructor.User_Name.Contains(value) || B.Description.Contains(value)).ToList();
        }
        #endregion
    }
}
