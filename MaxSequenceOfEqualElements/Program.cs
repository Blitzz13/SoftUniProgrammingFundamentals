using System;
using System.Linq;


namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var startIndex = 0;
            var sequenceLenght = 1;
            var bestStartIndex = 0;
            var bestSequenceLenght = 0;

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] == arr[i - 1])
                {
                    sequenceLenght++;
                    if (sequenceLenght > bestSequenceLenght)
                    {
                        bestStartIndex = startIndex;
                        bestSequenceLenght = sequenceLenght;
                    }
                }
                else
                {
                    startIndex = i;
                    sequenceLenght = 1;
                }
            }

            for (int i = bestStartIndex; i < bestStartIndex + bestSequenceLenght; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
