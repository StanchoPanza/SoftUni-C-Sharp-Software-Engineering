using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, double power)
        {
            this.TypeOfVehicle = type;
            this.Brand = model;
            this.Model = color;
            this.HorsePower = power;

        }

        public string TypeOfVehicle { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public  void PrintVehicle()
        {
            string value = "kg";
            if (this.TypeOfVehicle == "Car")
            {
                value = "hp";
            }
            Console.WriteLine($"{this.Brand}: {this.Model} - {this.HorsePower}{value}");
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            double carpower = 0;
            double truckpower = 0;
            double carCount = 0;
            double truckCount = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    Console.WriteLine("Cars:");

                    cars = cars.OrderBy(c => c.Brand).ToList();
                    trucks = trucks.OrderBy(c => c.Brand).ToList();

                    foreach (Vehicle car in cars)
                    {
                        car.PrintVehicle();
                    }
                    Console.WriteLine("Trucks:");
                    foreach (Vehicle truck in trucks)
                    {
                        truck.PrintVehicle();
                    }

                    break;
                }

                string[] vehicleData = input.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string currentType = UppercaseFirst(vehicleData[0]);
                string currentBrand = vehicleData[1];
                string CurrentModel = vehicleData[2];
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

                Vehicle newVehicle = new Vehicle(currentType, currentBrand, CurrentModel, currentPower);
                if (newVehicle.TypeOfVehicle == "Truck")
                {
                    trucks.Add(newVehicle);
                }
                else
                {
                    cars.Add(newVehicle);
                }
            }


        }
        static string UppercaseFirst(string s)
        {

            return char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}
