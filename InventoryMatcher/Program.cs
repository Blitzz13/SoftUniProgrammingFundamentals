using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();
            var intArr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var douleArr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            string food;
            do
            {
                food = Console.ReadLine();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == food)
                    {
                        Console.WriteLine($"{arr[i]} costs: {douleArr[i]}; Available quantity: {intArr[i]}");
                    }
                }

            } while (food != "done");
        }
    }
}
