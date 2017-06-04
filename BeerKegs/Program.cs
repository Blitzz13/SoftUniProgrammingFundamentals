using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sections = int.Parse(Console.ReadLine());
            double volume = 0;
            double oldVolume = 0;
            string name = "";
            for (int keg = 0; keg < sections; keg++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * radius * radius * height;
                if (oldVolume < volume)
                {
                    name = kegName;
                    oldVolume = volume;
                }    
            }
            Console.WriteLine(name);
        }
    }
}
