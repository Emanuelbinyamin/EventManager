using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Date_Time { get; set; }

        public Event(string title, string description, string location, DateTime date_Time)
        {
            Title = title;
            Description = description;
            Location = location;
            Date_Time = date_Time;
        }
    }
}
