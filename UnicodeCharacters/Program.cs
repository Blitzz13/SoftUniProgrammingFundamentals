using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write($"{GetEscapeSequence(word[i])}");
            }
            Console.WriteLine();
        }
        private static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("x4");
        }
    }
}
