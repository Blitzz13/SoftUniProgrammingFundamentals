using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HideOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                string character = tokens.First();
                int timesToSearch =int.Parse(tokens.Last());
                if (character == "^")
                {
                    character = "\\^";
                }
                else if (character == @"\")
                {
                    character = @"\\";
                }
                else if (character == @"/")
                {
                    character = @"\/";
                }
                Regex regex = new Regex(@"["+character+"]{"+timesToSearch+",}");

                Match match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index {match.Index} and it is with size {match.Length}!");
                    break;
                }
            }
        }
    }
}
