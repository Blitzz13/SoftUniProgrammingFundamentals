using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] tokens = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            int baseN = (int)tokens[0];
            List<BigInteger> rest = new List<BigInteger>();
            BigInteger number = tokens[1];
            int counter = 0;
            int lenght = number.ToString().Length;
            while (number != 0)
            {
                BigInteger rem = number % baseN;
                rest.Add(rem);
                number /= baseN;
                counter++;
            }
            rest.Reverse();
            Console.WriteLine(String.Join("", rest));

        }
    }
}
