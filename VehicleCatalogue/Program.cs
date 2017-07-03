using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] tokens = input.Split().ToArray();
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                long horsePower = long.Parse(tokens[3]);
                type = type.ToLower();
                type = ToUpperFirstLetter(type);
                Vehicle vehicle = new Vehicle()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = horsePower
                };

                vehicles.Add(vehicle);
            }
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Close the Catalogue")
                {
                    break;
                }

                input = ToUpperFirstLetter(input);

                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == input)
                    {
                        Console.WriteLine($"Type: {vehicle.Type}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                    if (vehicle.Type == "Car")
                    {
                        cars.Add(vehicle);

                    }
                    else
                    {
                        trucks.Add(vehicle);
                    }
                }
            }
            //try
            //{
            //    var carHorsePower = cars.Select(a => a.Horsepower).Average();
            //    Console.WriteLine($"Cars have average horsepower of: {carHorsePower:f2}.");
            //}
            //catch
            //{

            //    Console.WriteLine($"Cars have average horsepower of: 0.00.");
            //}
            //try
            //{
            //    var truckHorsePower = trucks.Select(a => a.Horsepower).Average();
            //    Console.WriteLine($"Trucks have average horsepower of: {truckHorsePower:f2}.");
            //}
            //catch
            //{
            //    Console.WriteLine($"Trucks have average horsepower of: 0.00.");

            //}

            if (cars.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            else
            {
                var carHorsePower = cars.Select(a => a.Horsepower).Average();
                Console.WriteLine($"Cars have average horsepower of: {carHorsePower:f2}.");
            }
            if (trucks.Count == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
            else
            {
                var truckHorsePower = trucks.Select(a => a.Horsepower).Average();
                Console.WriteLine($"Trucks have average horsepower of: {truckHorsePower:f2}.");
            }



        }

        static string ToUpperFirstLetter(string word)
        {
            
            char[] letters = word.ToCharArray();

            letters[0] = char.ToUpper(letters[0]);

            return new string(letters);
        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public long Horsepower { get; set; }
    }
}
