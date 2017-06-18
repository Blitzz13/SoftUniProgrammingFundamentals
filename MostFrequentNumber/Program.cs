using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int mostFrequendValue = 0;

            int oldCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }
                
                if (oldCounter < counter)
                {
                    oldCounter = counter;
                    mostFrequendValue = arr[i];
                }
            }
            Console.WriteLine(mostFrequendValue);
        }
    }
}
