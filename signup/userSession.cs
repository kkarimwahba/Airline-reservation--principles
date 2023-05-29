using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signup
{
    public class userSession
    {
        //here if we need to add more session for the user info.
        public static bool IsLoggedIn { get; set; }
        public static int id { get; set; }
        public static string  name { get; set; }
        public static string email { get; set;}
        public static string username { get; set; }
        public static string phone { get; set; }
        public static string passport_number { get; set; }
        public static string password { get; set; }
        public static string gender { get; set; }
        public static string age { get; set; }
        public static string address { get; set; }
        public static string role { get; }
        public userSession()
        {

        }

        public userSession(int id,string name, string email, string username, string phone, string passport_number, string password,string gender,string age,string address)
        {
            id = id;
            name = name;
            email = email;
            username = username;
            phone = phone;
            passport_number = passport_number;
            password = password;
            gender = gender;
            age = age;
            address = address;
        }
    }

    internal class Session
    {
    }
}
//userSesssion usersesion = new usersession();
//usersession.sgks();