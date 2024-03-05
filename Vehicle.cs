// Vehicle.cs
using System;

namespace VehicleExample
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Year = 0;
        }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public virtual string DisplayInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Year: {Year}";
        }
    }
}
