using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());


            double distance1 = CalculateDistanceBetweenPoints(x1, y1, x2, y2);
            double distance2 = CalculateDistanceBetweenPoints(x3, y3, x4, y4);
            if (distance1 > distance2)
            {
                if (Point1IsCloserToCenter(x1, y1, x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (Point1IsCloserToCenter(x3, y3, x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }

        }
        static bool Point1IsCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = CalculateDistanceBetweenPoints(x1, y1, 0, 0);
            double distance2 = CalculateDistanceBetweenPoints(x2, y2, 0, 0);

            if (distance1 <= distance2)
            {
                return true;
            }

            return false;
        }

        private static double CalculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }

    }
}
