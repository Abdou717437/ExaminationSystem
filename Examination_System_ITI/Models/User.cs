using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examination_System_ITI.Views;

namespace Models
{
    public class User
    {
        static Context ctx;
        public static bool IsSuccessful;
        public static string Message;
        public static User CurrentUser { get; set; }
        static User()
        {
            ctx = new Context();
            IsSuccessful = false;
            Message = "";
            CurrentUser = new User();
        }
        public int Id { get; set; }
        [Required, MaxLength(10), MinLength(3)]
        public string User_Name { get; set; }
        [Required, MaxLength(16), MinLength(8)]
        public string Password { get; set; }

        public bool Status { get; set; }

        public string Profile_Image_Src { get; set; } 

        public virtual Role Role { get; set; }

        #region Model Functions

        public static void Login(User user)
        {
            try
            {
                if (user.User_Name != string.Empty && user.Password != string.Empty)
                {
                    user = ctx.Users.FirstOrDefault(a => a.User_Name.Equals(user.User_Name));
                    if (user != null)
                    {
                        if (user.Password.Equals(user.Password))
                        {
                            CurrentUser = user;
                            Message = $"Login Success! Welcom {CurrentUser.User_Name}";
                            IsSuccessful = true;
                            return;
                        }
                        else
                        {
                            Message = "Password Not Valid!";
                            IsSuccessful = false;
                            return;
                        }
                            
                    }
                    else
                    {
                        Message = "User Name Not Valid!";
                        IsSuccessful = false;
                        return;
                    }
                }
                else
                {
                    Message = "User Name and Password Can't be Empty!";
                    IsSuccessful = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                IsSuccessful = false;
            }
        }

        #endregion
    }
}