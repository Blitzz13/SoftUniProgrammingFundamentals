using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var tokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bombNumber = tokens[0];
            int power = tokens[1];

            for (int i = 0; i < list.Count; i++)
            {
                var currentNum = list[i];
                if (currentNum == bombNumber)
                {
                    var leftIndex = Math.Max(i - power, 0);
                    var rightIndex = Math.Min(i + power, list.Count - 1);

                    var removeCount = rightIndex - leftIndex + 1;

                    list.RemoveRange(leftIndex, removeCount);
                    i = 0;
                }
            }

            Console.WriteLine(list.Sum());
        }
    }
}
