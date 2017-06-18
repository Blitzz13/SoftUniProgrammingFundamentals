using System;
using System.Collections.Generic;
using System.Linq;


namespace MaxSequenceOfEqualElementsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var maxSequenceOfEqualElements = FindMaxSequenceOfElements(inputArr);

            Console.WriteLine(string.Join(" ", maxSequenceOfEqualElements));
        }

        static int[] FindMaxSequenceOfElements(int[] inputArr)
        {
            var longestSequence = new List<int>();
            var currentSequence = new List<int>();
            currentSequence.Add(inputArr[0]);

            for (int i = 1; i < inputArr.Length; i++)
            {
                var currentNum = inputArr[i];
                var serchNum = currentSequence[0];
                if (currentNum == serchNum)
                {
                    currentSequence.Add(currentNum);
                }
                else
                {

                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }

                    currentSequence.Clear();
                    currentSequence.Add(currentNum);
                }

                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = new List<int>(currentSequence);
                }
            }
            return longestSequence.ToArray();
        }
    }
}

