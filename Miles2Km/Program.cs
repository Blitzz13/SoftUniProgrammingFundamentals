using System;

namespace Miles2Km
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double kilometer = mile * 1.60934;

            Console.WriteLine($"{kilometer:F2}");

        }
    }
}
