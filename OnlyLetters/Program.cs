using System;
using System.Text.RegularExpressions;

namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex regex = new Regex(@"(?<digits>[0-9]+)(?<leter>[a-zA-z])");
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var digits = match.Groups["digits"].Value;
                var letter = match.Groups["leter"].Value;

                input = input.Replace(digits,letter);
            }

            Console.WriteLine(input);
        }
    }
}
