# 📅 EventManager - A Simple Calendar and User Event Tracker

Welcome to **EventManager**, your all-in-one solution to effortlessly manage events, users, and subscriptions! 🚀

## 🌟 Features:
- **Add and Track Events**: Create events with titles, descriptions, locations, and specific dates & times.
- **User Management**: Add users and track which events they’re subscribed to.
- **Display Friendly**: Nicely formatted outputs for users and events — no more messy console screens! 🙌

## 🛠 How It Works:
1. **Add Events**: Create events with important details like location and time.
2. **Add Users**: Manage users who will be attending these events.
3. **Subscribe Users to Events**: Users can subscribe to the events they’re interested in.

## 🚀 Quick Start:
1. Clone the repo:
   ```bash
   git clone https://github.com/Emanuelbinyamin/EventManager.git
   ```
2. Open the project in your favorite IDE (like Visual Studio) and hit `Run`.
3. Add events, users, and have fun subscribing them to events! 🎉

## 📋 Example Usage:
```csharp
Calander calander = new Calander();

// Adding Events
calander.AddEvent("Team Meeting", "Discuss project updates", "Zoom", new DateTime(2024, 10, 15, 14, 0, 0));
calander.AddEvent("Product Launch", "Launch our new app", "Office HQ", new DateTime(2024, 12, 1, 9, 0, 0));

// Adding Users
calander.AddUser("johndoe", "password123");
calander.AddUser("alicewong", "alicepass");

// Subscribing Users to Events
calander.SubscribeToEvent("johndoe", "Team Meeting");
calander.SubscribeToEvent("alicewong", "Product Launch");

// Display Events and Users
calander.Display_Current_Events();
calander.Display_Current_Users();
```

## 🤖 Built With:
- **C#** for the core logic.
- **.NET Framework** for console app support.

## 🎯 To Do:
- [ ] Add event reminder notifications.
- [ ] Enhance user authentication (better password handling).
- [ ] Create a GUI version.

## 👏 Contributing:
Feel free to fork the repo, make changes, and submit a pull request! Let's build this tool together! 🛠

## 📄 License:
This project is open-source under the [MIT License](LICENSE).

