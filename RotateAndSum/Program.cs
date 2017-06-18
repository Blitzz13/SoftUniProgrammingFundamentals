using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrayNumbers = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            rotateArray(arrayNumbers, k);
        }

        static void rotateArray(string arrayNumbers, int k)
        {
            string[] items = arrayNumbers.Split(' ');

            int[] numbers = items.Select(int.Parse).ToArray();
          
            int[] oldNumers = new int[numbers.Length];
           
            int counter = 0;
            for (int i = 0; i < k; i++)
            {
                int lastNumber = numbers.Last();
               

                for (int j = oldNumers.Length - 1; j >= 1; j--)
                {
                    numbers[j] = numbers[j - 1];
                    oldNumers[j] += numbers[j];
                }
                numbers[0] = lastNumber;
                oldNumers[0] += numbers[0];


                counter++;


            }

            for (int i = 0; i < oldNumers.Length; i++)
            {
                Console.Write($"{oldNumers[i]} ");
            }

        }
    }
}
