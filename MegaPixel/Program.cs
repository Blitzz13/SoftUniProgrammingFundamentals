using System;

namespace MegaPixel
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());

            double megaPixel = (width * height) / 1000000;
            Console.WriteLine($"{width}x{height} => {Math.Round(megaPixel,1)}MP");
        }
    }
}
