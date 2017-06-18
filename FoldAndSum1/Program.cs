using System;
using System.Linq;


namespace FoldAndSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = arr.Length / 4;

            var leftArr = new int[k];
            var middleArr = new int[2 * k];
            var rightArr = new int[k];

            var finalArr = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                leftArr[i] = arr[i];
            }
            for (int i = 0; i < 2 * k; i++)
            {
                middleArr[i] = arr[k + i];
            }

            Array.Reverse(arr);
            for (int i = 0; i < k; i++)
            {
                rightArr[i] = arr[i];
            }
            Array.Reverse(leftArr);
           
            for (int i = 0; i < k; i++)
            {
                finalArr[i] += middleArr[i] + leftArr[i];

                finalArr[i + k] += middleArr[i + k] + rightArr[i];
            }
          

            Console.WriteLine(String.Join(" ",finalArr));
        }
    }
}
