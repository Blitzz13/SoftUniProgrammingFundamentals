using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();

            number = number.Where(x => x % 2 == 0).ToList();
            double average = number.Average();
            for (int i = 0; i < number.Count; i++)
            {
                if(number[i] > average)
                   number[i] += 1;
                else if (number[i] <= average)
                    number[i] -= 1;
            }
            Console.WriteLine(string.Join(" ",number));
        }
    }
}
