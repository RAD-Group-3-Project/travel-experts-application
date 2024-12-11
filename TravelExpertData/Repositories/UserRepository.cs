using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                var user = ctx.AspNetUsers
                .FirstOrDefault(u => u.UserName == login && u.PasswordHash == password);

                if (user != null)
                {
                    user1.Username = user.UserName;
                    user1.Password = user.PasswordHash;
                    user1.IS_Admin = user.IsAdmin;
                }

                return user1;
            }
        }
    }
}
