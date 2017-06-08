using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Coordinates(x1, x2, y1, y2);

        }
        static void Coordinates(double x1, double x2, double y1, double y2)
        {
            double newX = 0;
            double newY = 0;
            if (Math.Abs(x1) < Math.Abs(x2))
            {
                newX = x1;
            }
            else
            {
                newX = x2;
            }
            if (Math.Abs(y2) < Math.Abs(y1))
            {
                newY = y2;
            }
            else
            {
                newY = y1;
            }
            if ((Math.Abs(x1) == Math.Abs(x2)) && (Math.Abs(y1) == Math.Abs(y2)))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {

                Console.WriteLine($"({newX}, {newY})");
            }
        }
    }
}
