using System;

namespace VowelОrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'o' || a == 'u' || a == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsDigit(a))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
