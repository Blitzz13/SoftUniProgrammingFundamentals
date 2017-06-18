using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters1 = Console.ReadLine();
            string letters2 = Console.ReadLine();

            ComapreArrays(letters1, letters2);

        }
        static void ComapreArrays(string letters1, string letters2)
        {
            string[] items1 = letters1.Split(' ');
            char[] firstArr = items1.Select(char.Parse).ToArray();

            string[] items2 = letters2.Split(' ');
            char[] secondArr = items2.Select(char.Parse).ToArray();

            int length = Math.Min(firstArr.Length, secondArr.Length);

            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine(String.Join("", secondArr));
                Console.WriteLine(String.Join("", firstArr));
            }
            else if (firstArr.Length == secondArr.Length)
            {
                bool resolved = false;
                for (int i = 0; i < length; i++)
                {
                    if (firstArr[i] > secondArr[i])
                    {
                        Console.WriteLine(String.Join("", secondArr));
                        Console.WriteLine(String.Join("", firstArr));
                        resolved = true;
                        break;
                    }
                    if (secondArr[i] > firstArr[i])
                    {
                        Console.WriteLine(String.Join("", firstArr));
                        Console.WriteLine(String.Join("", secondArr));
                        resolved = true;
                        break;
                    }
                }
                if (!resolved)
                {
                    Console.WriteLine(String.Join("", firstArr));
                    Console.WriteLine(String.Join("", secondArr));
                }
            }
            else
            {
                Console.WriteLine(String.Join("", firstArr));
                Console.WriteLine(String.Join("", secondArr));
            }

        }

    }
}

