using System;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToCensor = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = sentence.Replace(wordToCensor, new string('*', wordToCensor.Length));

            Console.WriteLine(sentence);
        }
    } 
}
