using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vechile_Rental_System
{
    //Abstraction and Encapsulation
    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double BaseRent { get; set; }

        public Vehicle(string make, string model, double baseRent)
        {
            Make = make;
            Model = model;
            BaseRent = baseRent;
        }

        public abstract double CalculateRent(int days);
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Make} {Model}, Rent: {BaseRent}/day");
        }
    }
    // Inheritance and Polymorphism
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
