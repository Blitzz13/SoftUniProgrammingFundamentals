using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split()
                .Select(a => a.ToCharArray().Distinct().ToArray())
                .ToArray();

            var firstLenght = strings.First().Length;

            Console.WriteLine(strings.All(a => a.Length == firstLenght).ToString().ToLower());
        }
    }

}