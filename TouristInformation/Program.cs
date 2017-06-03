using System;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            if (imperialUnit == "miles")
            {
                Console.WriteLine($"{value} {imperialUnit} = {(value * 1.6):F2} kilometers");
            }
            else if (imperialUnit == "inches")
            {
                Console.WriteLine($"{value} {imperialUnit} = {(value * 2.54):F2} centimeters");
            }
            else if (imperialUnit == "feet")
            {
                Console.WriteLine($"{value} {imperialUnit} = {(value * 30):F2} centimeters");
            }
            else if (imperialUnit == "yards")
            {
                Console.WriteLine($"{value} {imperialUnit} = {(value * 0.91):F2} meters");
            }
            else if (imperialUnit == "gallons")
            {
                Console.WriteLine($"{value} {imperialUnit} = {(value * 3.8):F2} liters");
            }
        }
    }
}
