// Car.cs
using System;

namespace VehicleExample
{
    // Derived class
    public class Car : Vehicle
    {
        public string LicensePlate { get; set; }

        // Default constructor
        public Car() : base() // Calls the default constructor of the Vehicle class
        {
            LicensePlate = "Unknown";
        }

        // Parametrized constructor
        public Car(string brand, string model, int year, string licensePlate)
            : base(brand, model, year) // Calls the parametrized constructor of the Vehicle class
        {
            LicensePlate = licensePlate;
        }

        // Overriding the DisplayInfo method to include LicensePlate
        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, License Plate: {LicensePlate}";
        }
    }
}
