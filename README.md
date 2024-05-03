# AutoShop Management System
## Description:
The AutoShop Management System is a C# console application designed to simulate the management of various types of vehicles in an auto shop. It includes a base class `Vehicle` and derived classes such as `Car`, `Boat`, `HatchBack`, and `Sedan`, each with unique attributes and behaviors. The application demonstrates object-oriented programming principles such as inheritance, encapsulation, and polymorphism.

## Structure:
- **`Vehicle.cs`**: Base class for all vehicle types with common properties like vehicleIdNumber, mileage, make, and model.
- **`Car.cs`**: Derived class from Vehicle, adds specific attributes such as seats.
- **`Boat.cs`**: Specialized vehicle class handling properties like radar.
- **`HatchBack.cs`**: Extends Vehicle with features like foldableSeats.
- **`Sedan.cs`**: Another derivative of Vehicle, includes luxury attributes such as backseatFridge and backseatRecliner.
- **`Program.cs`**: Contains the Main method, and entry point of the application where instances of vehicle classes are manipulated.

## Installation and Running the Project:
1. Ensure you have .NET SDK installed that supports C# and is compatible with the net5.0 target framework.
2. Clone the repository or download the project files.  https://github.com/YasamanMVS/Semester3-Advanced-OOP-AutoShop.git
3. Navigate to the project directory, and run the `AutoShop.sln` file.

## Features:
- **Vehicle Management**: Allows creation and manipulation of various types of vehicle objects.
- **Console Interface**: Simple console interface for interacting with the vehicle objects and observing the polymorphic behaviors.   
