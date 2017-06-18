using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();
            
            for (int i = 0; i < list.Count; i++)
            {
                char[] charArray = list[i].ToCharArray();
                Array.Reverse(charArray);
                string word = new string(charArray);

                list[i] = word;

            }

            Console.WriteLine(list.Select(int.Parse).ToList().Sum());
        }
    }
}
