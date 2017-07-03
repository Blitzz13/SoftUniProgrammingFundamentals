using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = Console.ReadLine();
            string[] keyWords = input.Split(new[] { '|', '\\', '<' },StringSplitOptions.RemoveEmptyEntries);

            string startKeyWord = keyWords.First();
            string endKeyWord = keyWords.Last();

            Regex regex = new Regex(@"(?<start>" + startKeyWord + ")(?<word>.*?)(?<end>" + endKeyWord + ")");

            var matches = regex.Matches(text);
            List<string> newMatches = new List<string>();
            foreach (Match match in matches)
            {
                if (match.Groups["word"].Value != "")
                {
                    newMatches.Add(match.Groups["word"].Value);
                }
            }
            if (newMatches == null || newMatches.Count() == 0)
            {
                Console.Write("Empty result");
            }
            else
            {
                Console.WriteLine(string.Join("",newMatches));
            }
        }
    }
}
