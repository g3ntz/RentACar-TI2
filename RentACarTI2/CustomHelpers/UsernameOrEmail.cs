using RentACarTI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RentACarTI2.CustomHelpers
{
    public class UsernameOrEmail
    {
        public static User usernameOrEmail(User user)
        {
            // IF EMAIL JUST RETURN USER, IF NOT ASSIGN THE USERNAME TO USER.USERNAME AND RETURN USER
            if (validateEmail(user.Email))
                return user;
            else
            {
                user.Username = user.Email;
                user.Email = null;
            }
            return user;
        }

        public static string usernameOrEmail(string email)
        {
            // IF EMAIL RETURN EMAIL, IF NOT RETURN NULL
            if (validateEmail(email))
                return email;
            else
            {
                return null;
            }
        }

        public static bool validateEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
