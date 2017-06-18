using System;
using System.Linq;


namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            long newSum = 0;
            bool hasOcured = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == n)
                    {
                        hasOcured = true;
                        sum = 0;
                        for (int a = 0; a < j; a++)
                        {
                            sum += arr[a];
                            if (newSum < sum)
                            {
                                newSum = sum;
                            }
                        }
                    }

                }
            }

            if (hasOcured)
            {
                Console.WriteLine(newSum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
