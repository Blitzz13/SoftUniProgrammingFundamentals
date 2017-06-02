using System;

namespace CackeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string ingrediant;
            do
            {
                ingrediant = Console.ReadLine();
                if (ingrediant == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingrediant}.");
                counter++;
            } while (ingrediant != "Bake!");
            if (ingrediant == "Bake!")
            {
                Console.WriteLine($"Preparing cake with {counter} ingredients.");
            }
        }
    }
}
