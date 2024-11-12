using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertData.Models
{
    public class CurrentUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IS_Admin { get; set; }

        public CurrentUser(string name, string password, bool is_admin)
        {
            Username = name;
            Password = password;
            IS_Admin = is_admin;
        }
        public CurrentUser()
        {
            Username = null;
            Password = null;
            IS_Admin = false; 
        }
    }
}
