using System;

namespace RectaleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            float s;
            float a, b;

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            s = a * b;

            Console.WriteLine($"{s:F2}");
        }
    }
}
