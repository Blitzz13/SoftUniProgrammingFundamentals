using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int difference = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = 0; j < sequence.Length; j++)
                {
                    if (sequence[i] - sequence[j] == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
