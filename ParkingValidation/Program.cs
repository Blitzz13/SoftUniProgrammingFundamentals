using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> carPark = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];
                string userName = tokens[1];


                switch (command.ToLower())
                {
                    case "register":
                        string licensePlate = tokens[2];
                        Print(Register(carPark, userName, licensePlate));
                        break;
                    case "unregister":
                        Print(Unregister(carPark, userName));
                        break;
                }
            }
            foreach (KeyValuePair<string, string> item in carPark)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }

        private static string Unregister(Dictionary<string, string> carPark, string userName)
        {
            if (!carPark.ContainsKey(userName))
            {
                return $"ERROR: user {userName} not found";
            }
            carPark.Remove(userName);
            return $"user {userName} unregistered successfully";
        }

        private static string Register(Dictionary<string, string> carPark, string userName, string licensePlate)
        {
            if (carPark.ContainsKey(userName))
            {
                return $"ERROR: already registered with plate number {carPark[userName]}";
            }
            else if (!ValidatePlate(licensePlate))
            {
                return $"ERROR: invalid license plate {licensePlate}";
            }
            else if (carPark.ContainsValue(licensePlate))
            {
                return $"ERROR: license plate {licensePlate} is busy";
            }
            carPark.Add(userName, licensePlate);
            return $"{userName} registered {licensePlate} successfully";
        }

        private static bool ValidatePlate(string licensePlate)
        {
            bool isValidNumbers = licensePlate.ToCharArray().Skip(2).Take(4)
                .All(d => char.IsDigit(d));
            bool isValidLetter = licensePlate.ToCharArray().Take(2)
                .Concat(licensePlate.ToCharArray().Skip(6).Take(2).ToArray()).All(d => char.IsUpper(d));
            return licensePlate.Length == 8 && isValidLetter && isValidNumbers;
        }

        static void Print(string input)
        {
            Console.WriteLine(input);
        }
    }
}
