using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            
            string firstWord = tokens[0];
            string secondWord = tokens.Last();

            int minLenght = Math.Min(firstWord.Length, secondWord.Length);
            var sum = 0;
            for (int i = 0; i < minLenght; i++)
            {
                char firstWordFirstLetter = firstWord.Skip(i).First();
                char secondWordFirstLetter = secondWord.Skip(i).First();
                sum += firstWordFirstLetter * secondWordFirstLetter;
            }
            char[] firstWordArr = firstWord.ToCharArray();
            char[] secondWordArr = secondWord.ToCharArray();
            int remLenght = 0;
            
            if (firstWord.Length == minLenght && secondWord.Length != firstWord.Length)
            {
                remLenght = secondWordArr.Length - minLenght;
                for (int i = secondWordArr.Length - remLenght; i < secondWordArr.Length; i++)
                {
                    sum += secondWordArr[i];
                }
            }
            else if (secondWord.Length == minLenght && firstWord.Length != secondWord.Length)
            {
                remLenght = firstWordArr.Length - minLenght;
                for (int i = firstWordArr.Length - remLenght; i < firstWordArr.Length; i++)
                {
                    sum += firstWordArr[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
