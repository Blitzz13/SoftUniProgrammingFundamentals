using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());

            if (a >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
