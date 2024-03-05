// Program.cs
using System;
using VehicleExample;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter vehicle details to create a car:");

        Console.Write("Brand: ");
        string brand = Console.ReadLine();

        Console.Write("Model: ");
        string model = Console.ReadLine();

        Console.Write("Year: ");
        int year;
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.Write("Invalid input for year. Please enter a valid integer: ");
        }

        Console.Write("License Plate: ");
        string licensePlate = Console.ReadLine();

        Car myCar = new Car(brand, model, year, licensePlate);

        Console.WriteLine("\nCreated car details:");
        Console.WriteLine(myCar.DisplayInfo());
    }
}
