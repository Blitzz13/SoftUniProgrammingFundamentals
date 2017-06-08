using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
         {
            long n = long.Parse(Console.ReadLine());
            var primeChecker = PrimeChecker(n);
            Console.WriteLine(primeChecker);
        }
        static bool PrimeChecker(long prime)
        {
            if (prime == 1 || prime == 0)
            {
                return false;
            }

            else if (prime == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(prime); i++)
            {
                if (prime % i == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}

