using System;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double p = 2 * a + 2 * b;
            double s = a * b;
            double diagonal = Math.Sqrt(a * a + b * b);
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(diagonal);

        }
    }
}
