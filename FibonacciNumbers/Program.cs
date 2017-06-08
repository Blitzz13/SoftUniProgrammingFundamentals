using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            FibonachiNumbers(num + 1);
        }
        static void FibonachiNumbers(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {

                int temp = a;
                a = b;
                b += temp;
            }
            Console.WriteLine(a);
        }
    }
}
