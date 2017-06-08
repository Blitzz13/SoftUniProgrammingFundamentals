using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            CubeProperties(side, property);
        }

        static void CubeProperties(double side,string property)
        {
            double volume = side * side * side;
            double faceDiagonal = side * Math.Sqrt(2);
            double spaceDiagonals = Math.Sqrt(3 * Math.Pow(side, 2));
            double area = 6 * (side * side);
            if (property == "volume")
            {
                Console.WriteLine($"{volume:F2}");
            }
            else if (property == "space")
            {
                Console.WriteLine($"{spaceDiagonals:F2}");
            }
            else if (property == "face")
            {
                Console.WriteLine($"{faceDiagonal:F2}");
            }
            else if (property == "area")
            {
                Console.WriteLine($"{area:F2}");
            }
        }
    }
}
