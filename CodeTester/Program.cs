using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheFigure = Console.ReadLine();
            if (nameOfTheFigure == "Triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                TriangleArea(side, height);
            }
            else if (nameOfTheFigure == "Square")
            {
                double side = double.Parse(Console.ReadLine());
                SquareArea(side);
            }
            else if (nameOfTheFigure == "Rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                RectangleArea(width, height);
            }
            else if (nameOfTheFigure == "Circle ")
            {
                double radius = double.Parse(Console.ReadLine());
                CircleArea(radius);
            }
        }

        static double CircleArea(double radius)
        {
            double areaOfCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{areaOfCircle:f2}");
            return areaOfCircle;
        }

        static double RectangleArea(double width, double height)
        {
            double areaOfRectangle = width * height;
            Console.WriteLine($"{areaOfRectangle:f2}");
            return areaOfRectangle;
        }

        static double SquareArea(double side)
        {
            double areaOfSquare = Math.Pow(side, 2);
            Console.WriteLine($"{areaOfSquare:f2}");
            return areaOfSquare;
        }

        static double TriangleArea(double side, double height)
        {
            double areaOfTriangle = (side * height) / 2;
            Console.WriteLine($"{areaOfTriangle:f2}");
            return areaOfTriangle;
        }
    }
}