using System;
using System.Linq;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SieveOfEratosthenes(n);

        }

        static void SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
            {
                prime[i] = true;
            }
            prime[0] = false;
            prime[1] = false;
            //int counter = 2;
            for (int i = 0; i < prime.Length; i++)
            {
                if (prime[i] == true)
                {
                    for (int p = 2; p * i <= n; p++)
                    {

                        prime[i * p] = false;

                    }
                }
            }
            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                {
                    Console.Write($"{i} ");

                }
            }
            Console.WriteLine();
        }
    }
}
