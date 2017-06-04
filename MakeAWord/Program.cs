using System;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            string word = "";
            for (int letters = 0; letters < lines; letters++)
            {
                char letter = char.Parse(Console.ReadLine());
                word = word + letter;
            }
            Console.Write("The word is: ");
            Console.WriteLine(word);
        }
    }
}
