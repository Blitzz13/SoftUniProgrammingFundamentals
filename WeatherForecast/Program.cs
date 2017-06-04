using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nubmer = decimal.Parse(Console.ReadLine());

            if (nubmer >= sbyte.MinValue && nubmer <= sbyte.MaxValue)
            {
                if (nubmer % 1 != 0)
                {
                    Console.WriteLine("Rainy");
                    return;
                }
                Console.WriteLine("Sunny");

            }
            else if (nubmer >= int.MinValue && nubmer <= int.MaxValue)
            {
                if (nubmer % 1 != 0)
                {
                    Console.WriteLine("Rainy");
                    return;
                }
                Console.WriteLine("Cloudy");

            }
            else if (nubmer >= long.MinValue && nubmer <= long.MaxValue)
            {
                if (nubmer % 1 != 0)
                {
                    Console.WriteLine("Rainy");
                    return;
                }
                Console.WriteLine("Windy");

            }
        }
    }
}
