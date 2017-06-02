using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            Console.WriteLine();
            if (Math.Abs(a - b) > eps)
            {
                Console.WriteLine("False");
            }
            else if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine("True");
            }
            else if(Math.Abs(a - b) == eps)
            {
                Console.WriteLine("False");
            }

        }
    }
}
