using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calander calander = new Calander();

            // Add events to the calendar:
            calander.AddEvent("Team Meeting", "Discuss project progress", "Zoom", new DateTime(2024, 10, 15, 14, 0, 0));
            calander.AddEvent("Company Outing", "Annual outdoor event for all employees", "Central Park", new DateTime(2024, 11, 5, 10, 30, 0));
            calander.AddEvent("Product Launch", "Launch of the new software product", "Office HQ", new DateTime(2024, 12, 1, 9, 0, 0));
            calander.AddEvent("Client Presentation", "Present solution to client", "Client Office", new DateTime(2024, 10, 20, 16, 0, 0));

            calander.Display_Current_Events();

            // Add users:
            calander.AddUser("johndoe", "pass1234");
            calander.AddUser("janesmith", "mypassword");
            calander.AddUser("alicewong", "password1");
            calander.AddUser("boblee", "securepass");
            calander.AddUser("charliekim", "letmein");
            calander.AddUser("danbrown", "admin123");

            // Subscribe users to events:
            calander.SubscribeToEvent("johndoe", "Team Meeting");
            calander.SubscribeToEvent("janesmith", "Product Launch");

            calander.Display_Current_Users();
        }
    }
}
