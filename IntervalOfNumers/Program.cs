using System;

namespace IntervalOfNumers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (n < m)
            {
                for (int i = n; i <= m; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (m < n)
            {
                for (int i = m; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
