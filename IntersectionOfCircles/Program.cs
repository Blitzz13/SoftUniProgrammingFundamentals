using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    class Circle
    {
        //public Point center { get; set; }
        public int radius { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] properties = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] properties2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle c1 = new Circle();
            //int x = properties[0];
            c1 = new Circle()
            {
                X = properties[0],
                Y = properties[1],
                radius = properties[2]

            };

            Circle c2 = new Circle()
            {

                X = properties2[0],
                Y = properties2[1],
                radius = properties2[2]
            };


            if (Intersect(c1, c2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        static bool Intersect(Circle c1, Circle c2)
        {
            double a = c2.X - c1.X;
            double b = c2.Y - c1.Y;
            double distance = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            if (distance <= c1.radius + c2.radius)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
