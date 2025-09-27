Vehicle Rental System
A simple console-based Vehicle Rental System written in C# to demonstrate the core Object-Oriented Programming (OOP) principles.

📖 Project Description
This project allows users to select and rent different types of vehicles (Cars, Bikes) with a user-friendly console interface. The solution is designed to help learners and beginners understand encapsulation, inheritance, abstraction, and polymorphism through practical code examples.

✨ Features
Abstract Classes & Methods:
Abstract Vehicle class with shared properties and methods that must be implemented by subclasses.

Inheritance:
Car and Bike classes inherit from Vehicle and provide their own data and logic.

Encapsulation:
Properties (Make, Model, BaseRent) protect internal state via getters and setters.

Polymorphism:
Overridden methods in derived classes, behavior chosen at runtime via base class reference.

Interactive Console App:

View available vehicles

Select a vehicle to rent

Enter rental period

Get the total rental cost

🛠️ Technologies Used
C#

.NET Framework (Console Application)

🚀 How to Run
Open the solution in Visual Studio.

Build the project.

Run the application.

Follow the prompts to select and rent a vehicle!

📂 Structure
Vehicle (abstract base class)

Car (inherits Vehicle, adds IsAutomatic property and rent logic)

Bike (inherits Vehicle, adds HasCarrier property and rent logic)

Main program: Handles user input/output.

🤝 Contributing
Feel free to fork, modify, and improve the project to add new vehicle types, better user experience, or advanced features!

📄 License
This project is for educational purposes. See LICENSE if available.

