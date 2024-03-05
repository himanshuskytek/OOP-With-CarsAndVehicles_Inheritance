// Program.cs
using System;
using System.Runtime.ConstrainedExecution;
using VehicleExample;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Car
        Car myCar = new Car("Toyota", "Corolla", 2020, "XYZ123");

        // Displaying information about the car
        Console.WriteLine(myCar.DisplayInfo());
    }
}
