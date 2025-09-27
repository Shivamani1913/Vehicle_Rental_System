using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechile_Rental_System
{
    //Abstraction and Encapsulation

    //Declares an abstract class named Vehicle. Abstract classes can have both fully implemented and abstract (non-implemented) members.
    //You can't create instances of Vehicle directly—it is meant to be a common base for all vehicles.
    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double BaseRent { get; set; }
        
    //Properties enable encapsulation, controlling data access and protecting internal state.
        
        public Vehicle(string make, string model, double baseRent)
        {
            Make = make;
            Model = model;
            BaseRent = baseRent;
        }
    //Declares an abstract method. There is no body provided: only the signature.
    //This method must be implemented in all subclasses to define the logic for calculating rent based on days.
    //This is abstraction in action—it forces derived classes to provide specific behavior.
        
        public abstract double CalculateRent(int days);
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Make} {Model}, Rent: {BaseRent}/day");
        }
    }
    // Inheritance and Polymorphism

    //Inherits from Vehicle (demonstrating inheritance).
   //Adds a new property, IsAutomatic, to indicate transmission type.
    class Car : Vehicle
    {
        public bool IsAutomatic { get; set; }

        public Car(string make, string model, double baseRent, bool isAutomatic)
            : base(make, model, baseRent)
        {
            IsAutomatic = isAutomatic;
        }

        public override double CalculateRent(int days)
        {

        //Provides the required implementation of CalculateRent as declared abstract in Vehicle.
        //Override adds logic that automatic cars incur extra charges per day.
        
            double rent = BaseRent * days;
            if (IsAutomatic)
                rent += 100 * days; // extra for automatic transmission
            return rent;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(IsAutomatic ? "Automatic" : "Manual");
        }
    }
    
//Inherits from Vehicle (demonstrating inheritance).

    class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }

        public Bike(string make, string model, double baseRent, bool hasCarrier)
            : base(make, model, baseRent)
        {
            HasCarrier = hasCarrier;
        }

        public override double CalculateRent(int days)
        {
            double rent = BaseRent * days;
            if (HasCarrier)
                rent += 20 * days; // extra for carrier
            return rent;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(HasCarrier ? "With Carrier" : "No Carrier");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Honda", "Civic", 500, true),
            new Bike("Yamaha", "FZ", 200, false),
            new Car("Suzuki", "Swift", 450, false),
            new Bike("Hero", "Splendor", 150, true)
        };

            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine();
            }

            Console.Write("Select vehicle index (0-3): ");
            int idx = int.Parse(Console.ReadLine());
            Console.Write("Enter rental days: ");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total Rent: {vehicles[idx].CalculateRent(days)}");
        }
    }

}
