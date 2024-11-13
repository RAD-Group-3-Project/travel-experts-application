using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TravelExpertData.Data;
using TravelExpertData.Models;

namespace TravelExpertData.Repositories
{
    public class UserRepository
    {
        public static CurrentUser UserLogin(string login, string password)
        {
            using (TravelExpertContext ctx = new TravelExpertContext())
            {
                CurrentUser user1 = new();
                var user = ctx.Users
                .FirstOrDefault(u => u.UserLogin == login && u.UserPassword == password);

                if (user != null)
                {
                    user1.Username = user.UserLogin;
                    user1.Password = user.UserPassword;
                    user1.IS_Admin = user.IsAdmin;
                }

                return user1;
            }
        }
    }
}
