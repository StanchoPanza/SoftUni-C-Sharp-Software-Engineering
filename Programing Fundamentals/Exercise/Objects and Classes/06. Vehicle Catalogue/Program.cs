using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double power)
        {
            TypeOfVehicle = type;
            ModelOfVehicle = model;
            ColorOfVehicle = color;
            HorsePower = power;

        }

        public string TypeOfVehicle { get; set; }
        public string ModelOfVehicle { get; set; }
        public string ColorOfVehicle { get; set; }
        public double HorsePower { get; set; }

        public static void PrintVehicle(List<Vehicle> allVehicles, int index)
        {
            Console.WriteLine($"Type: {allVehicles[index].TypeOfVehicle}");
            Console.WriteLine($"Model: {allVehicles[index].ModelOfVehicle}");
            Console.WriteLine($"Color: {allVehicles[index].ColorOfVehicle}");
            Console.WriteLine($"Horsepower: {allVehicles[index].HorsePower}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allVehicles = new List<Vehicle>();

            double carpower = 0;
            double truckpower = 0;
            double carCount = 0;
            double truckCount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] vehicleData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string currentType = UppercaseFirst(vehicleData[0]);
                string currentModel = vehicleData[1];
                string currentColor = vehicleData[2];
                double currentPower = double.Parse(vehicleData[3]);

                if (currentType == "Car")
                {
                    carpower += currentPower;
                    carCount++;
                }
                else
                {
                    truckpower += currentPower;
                    truckCount++;
                }

                Vehicle newVehicle = new Vehicle(currentType, currentModel, currentColor, currentPower);
                allVehicles.Add(newVehicle);
            }
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Close the Catalogue")
                {
                    break;
                }

                int index = allVehicles.FindIndex(x => x.ModelOfVehicle == command);

                Vehicle.PrintVehicle(allVehicles, index);
            }

            double avarageCarPower = carpower / carCount;
            double avaragetruckPower = truckpower / truckCount;

            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avarageCarPower:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avaragetruckPower:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }


        }
        static string UppercaseFirst(string s)
        {

            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
