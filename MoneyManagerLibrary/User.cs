using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagerLibrary
{
    public class User
    {
        public string ID { get; set; }
        public string  Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public User(string id, string nama, string pass, string email, string question = null, string ans = null)
        {
            ID = id;
            Name = nama;
            Password = pass;
            Email = email;
            Question = question;
            Answer = ans;
        }
    }
}
