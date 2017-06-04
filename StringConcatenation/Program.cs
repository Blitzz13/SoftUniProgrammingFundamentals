using System;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string word = "";
            string newWord = "";
            int line = 0;
            for (line = 1; line <= n; line++)
            {
                 word = Console.ReadLine();
                if (line % 2 == 0)
                {
                    newWord += word;
                }
            }

            Console.WriteLine(newWord);
            

        }
    }
}
