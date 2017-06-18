using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var newList = new List<int>();
            for (int i = 0; i < arr[0]; i++)
            {
                newList.Add(list[i]);
            }
            for (int i = 0; i < arr[1]; i++)
            {
                newList.RemoveAt(0);
            }
            if (newList.Remove(arr[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
