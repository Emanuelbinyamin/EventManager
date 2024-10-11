using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Event> Events { get; set; }

        public User(string userName, string password, List<Event> events)
        {
            UserName = userName;
            Password = password;
            Events = events;
        }
    }
}
