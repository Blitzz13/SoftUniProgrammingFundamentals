using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                TriangleArea();
            }
            else if (figure == "rectangle")
            {
                AreaRectangle();
            }
            else if (figure == "square")
            {
                AreaSquare();
            }
            else if (figure == "circle")
            {
                AreaCircle();
            }
        }

        static void TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (side * height)/2;
            Console.WriteLine($"{area:F2}");
        }

        static void AreaSquare()
        {
            double side = double.Parse(Console.ReadLine());

            double area = side * side;
            Console.WriteLine($"{area:F2}");
        }

        static void AreaRectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            Console.WriteLine($"{area:F2}");
        }

        static void AreaCircle()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * (radius * radius);
            Console.WriteLine($"{area:F2}");
        }
    }
}
