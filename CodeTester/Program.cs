using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();

            int letterLenght = int.Parse(Console.ReadLine());
            string[] ingrediense = new string[arr.Length]; ;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];
                if (word.Length == letterLenght)
                {
                    Console.WriteLine($"Adding {word}.");
                    ingrediense.SetValue(word, counter);
                    counter++;
                }

            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.Write("The ingredients are:");
            for (int i = 0; i < 10; i++)
            {
                if (i == counter - 1)
                {
                    Console.Write($" {ingrediense[i]}.");
                    break;
                }
                Console.Write($" {ingrediense[i]},");
            }
            Console.WriteLine();
        }
    }
}