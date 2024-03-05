// Vehicle.cs
using System;

namespace VehicleExample
{
    // Base class
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Default constructor
        public Vehicle()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Year = 0;
        }

        // Parametrized constructor
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // Method to display basic vehicle info
        public virtual string DisplayInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}";
        }
    }
}
