// Car.cs
using System;

namespace VehicleExample
{
    public class Car : Vehicle
    {
        public string LicensePlate { get; set; }

        public Car() : base()
        {
            LicensePlate = "Unknown";
        }

        public Car(string brand, string model, int year, string licensePlate)
            : base(brand, model, year)
        {
            LicensePlate = licensePlate;
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, License Plate: {LicensePlate}";
        }
    }
}
