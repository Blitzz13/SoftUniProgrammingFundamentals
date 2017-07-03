using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            string firstWord = tokens[0];
            string secondWord = tokens.Last();

            int minLenght = Math.Min(firstWord.Length, secondWord.Length);
            //List<char> registeredLetters = new List<char>();
            Dictionary<char, char> registeredLetters = new Dictionary<char, char>();
            for (int i = 0; i < minLenght; i++)
            {
                char firstWordFirstLetter = firstWord.Skip(i).First();
                char secondWordFirstLetter = secondWord.Skip(i).First();
                //secondWordFirstLetter = firstWordFirstLetter;
                if (!registeredLetters.ContainsKey(firstWordFirstLetter) && !registeredLetters.ContainsValue(secondWordFirstLetter))
                {
                    registeredLetters.Add(firstWordFirstLetter,secondWordFirstLetter);
                }
            }
            bool areReplaceable = true;
            char[] firstWordArr = firstWord.ToCharArray();
            char[] secondWordArr = secondWord.ToCharArray();

            if (firstWord.Length == minLenght && firstWord.Length != secondWord.Length)
            {
                
                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (registeredLetters.ContainsValue(secondWord[i]))
                    {
                        areReplaceable = true;
                    }
                    else
                    {
                        areReplaceable = false;
                    }
                }
            }
            else if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (registeredLetters.ContainsValue(secondWord[i]))
                    {
                        areReplaceable = true;
                    }
                    else
                    {
                        areReplaceable = false;
                    }
                }
            }
            else
            {
               
                for (int i = 0; i < secondWordArr.Length; i++)
                {
                    if (registeredLetters.ContainsValue(secondWordArr[i]))
                    {
                        areReplaceable = true;
                    }
                    else
                    {
                        areReplaceable = false;
                    }
                }
            }
            int maxLenght = Math.Max(firstWord.Length, secondWord.Length);
            if (registeredLetters.Count < minLenght)
            {
                areReplaceable = false;
                if (registeredLetters.Count >= maxLenght)
                {
                    areReplaceable = true;
                }
            }
            else if (registeredLetters.Count == maxLenght - 1)
            {
                areReplaceable = true;
            }
            

            Console.WriteLine(areReplaceable.ToString().ToLower());
        }
    }
}
