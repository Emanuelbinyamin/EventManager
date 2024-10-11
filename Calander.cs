using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    internal class Calander
    {
        public List<Event> Events { get; set; }
        public List<User> Users { get; set; }

        public Calander()
        {
            Events = new List<Event>();
            Users = new List<User>();
        }

        // Add a new event to the calendar
        public void AddEvent(string title, string description, string location, DateTime date_Time)
        {
            Events.Add(new Event(title, description, location, date_Time));
        }

        // Display the current events in a well-formatted manner
        public void Display_Current_Events()
        {
            if (Events.Count == 0)
            {
                Console.WriteLine("No events available.");
                return;
            }

            Console.WriteLine("----- Current Events -----\n");
            int count = 1;
            foreach (Event e in Events)
            {
                Console.WriteLine($"{count}. Event:");
                Console.WriteLine($"   Title: {e.Title}");
                Console.WriteLine($"   Description: {e.Description}");
                Console.WriteLine($"   Location: {e.Location}");
                Console.WriteLine($"   Date and Time: {e.Date_Time:MMMM dd, yyyy h:mm tt}\n"); // Better date format
                count++;
            }
            Console.WriteLine("--------------------------\n");
        }

        // Add a new user to the system
        public void AddUser(string userName, string password)
        {
            Users.Add(new User(userName, password, new List<Event>()));
        }

        // Display the current users and their subscribed events
        public void Display_Current_Users()
        {
            if (Users.Count == 0)
            {
                Console.WriteLine("No users available.");
                return;
            }

            Console.WriteLine("----- Current Users -----\n");
            int userCount = 1;
            foreach (User u in Users)
            {
                Console.WriteLine($"{userCount}. User:");
                Console.WriteLine($"   Username: {u.UserName}");
                // Only display password for testing, should be removed in production for security
                Console.WriteLine($"   Password: {u.Password}");

                if (u.Events.Count == 0)
                {
                    Console.WriteLine("   No events subscribed.");
                }
                else
                {
                    Console.WriteLine("   Subscribed Events:");
                    int eventCount = 1;
                    foreach (Event e in u.Events)
                    {
                        Console.WriteLine($"      {eventCount}. {e.Title} - {e.Date_Time:MMMM dd, yyyy h:mm tt}");
                        eventCount++;
                    }
                }

                Console.WriteLine(); // Blank line to separate users
                userCount++;
            }
            Console.WriteLine("--------------------------\n");
        }

        // Subscribe a user to an event based on the title
        public void SubscribeToEvent(string userName, string title)
        {
            var user = Users.Find(u => u.UserName == userName);
            var ev = Events.Find(e => e.Title == title);

            if (user != null && ev != null)
            {
                user.Events.Add(ev);
                Console.WriteLine($"{userName} successfully subscribed to the event: {title}.");
            }
            else
            {
                Console.WriteLine("Subscription failed. Either the user or event was not found.");
            }
        }
    }
}
