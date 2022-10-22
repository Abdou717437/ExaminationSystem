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
    [Table ("Branch")]
    public class Branch
    {
        static Context context;
        public static bool IsSuccessful;
        public static string Message;
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

        public static void GetAllBranches( Frm_Branches frm)
        {
            frm.Branches_Dgv.DataSource =
                context.Branches.Select(B => new
                {
                    Id = B.Id,
                    Name = B.Name,
                    Description = B.Description,
                    Manager = B.Instructor.User_Name
                }).ToList();
            frm.Branches_Dgv.Refresh();
        }

        public static Branch GetBranch(int Id)
        {
            return context.Branches.Find(Id);
        }

        public static void GetBranchesByValue(string value, Frm_Branches frm)
        {
            frm.Branches_Dgv.DataSource =
               context.Branches.Where(B => B.Name.Contains(value) || B.Description.Contains(value))
               .Select(B => new
               {
                   Id = B.Id,
                   Name = B.Name,
                   Description = B.Description,
                   Manager = B.Instructor.User_Name
               }).ToList();
            frm.Branches_Dgv.Refresh();
        }
        #endregion
    }
}
