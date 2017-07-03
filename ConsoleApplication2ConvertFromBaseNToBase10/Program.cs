using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            //BigInteger[] tokens = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            //ulong baseNum = (ulong)tokens[0];
            //string number = tokens[1].ToString();
            //var charArr = number.ToCharArray();
            //var numsArr = charArr.Select(i => BigInteger.Parse(i.ToString())).ToArray();
            //numsArr = numsArr.Reverse().ToArray();
            //BigInteger c = 0;
            //BigInteger b = 1;
            //for (int i = 0; i < numsArr.Length; i++)
            //{
            //    c = c + (numsArr[i] * b);
            //    b *= baseNum;
            //}

             //Console.WriteLine(c);
            BigInteger[] tokens = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger basenumber = tokens[0];
            BigInteger number = tokens[1];
            //int power = 0;
            BigInteger theNewBaseNumber = 0;
            int letercount = number.ToString().Length;
            BigInteger c = 0;
            BigInteger b = 1;
            for (int i = 0; i < letercount; i++)
            {
                BigInteger lastNumber = number % 10;
                c = c + (lastNumber * b);
                b *= basenumber;
                number /= 10;
            }
            Console.WriteLine(c);
        }
    }
}
