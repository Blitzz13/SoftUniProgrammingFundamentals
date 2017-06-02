using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            int grams = int.Parse(Console.ReadLine());

            Console.WriteLine($"{ml}ml {name}:");
            Console.WriteLine($"{kcal /100.0 * ml}kcal, {grams / 100.0 * ml}g sugars");

        }
    }
}
