using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();
            Regex regex = new Regex(string.Format(@"[^.!?;]+\b({0})\b[^.?!;]+", keyWord));
            var results = regex.Matches(text);
            for (int i = 0; i < results.Count; i++)
                Console.WriteLine(results[i].Value.Trim());
        }
    }
}
