using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    public class admin : userSession
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; } = "admin";

        public admin(string email, string password)
        {
            Email = "admin@airline.com";
            Password = "admin123";
        }
    }
}
