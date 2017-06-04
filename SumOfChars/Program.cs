using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int letters = 0; letters < lines; letters++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum = sum + letter;
            }
            Console.Write("The sum equals: ");
            Console.WriteLine(sum);

        }
    }
}
