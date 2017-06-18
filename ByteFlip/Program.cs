using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToList();
            //checking if hexNumber is has more than 2 chars
            for (int i = 0; i < numbers.Count; i++)
            {
                string hexNumber = numbers[i];
                if (hexNumber.Length != 2)
                {
                    numbers.Remove(hexNumber);
                    i--;
                }
            }
            //reversing hex numbers
            var reversedNumbers = new List<string>();
            for (int i = 0; i < numbers.Count; i++)
            {

                string hexNum = numbers[i];
                char[] charArray = hexNum.ToCharArray();
                Array.Reverse(charArray);
                hexNum = string.Join("", charArray);

                reversedNumbers.Add(hexNum);
            }

            reversedNumbers.Reverse();
            var decimalNumbers = new List<int>();
            for (int i = 0; i < reversedNumbers.Count; i++)
            {
                string hexValue = reversedNumbers[i];
                int decValue = Convert.ToInt32(hexValue, 16);
                decimalNumbers.Add(decValue);
            }
            for (int i = 0; i < decimalNumbers.Count; i++)
            {
                Console.Write($"{(char)(decimalNumbers[i])}");
            }
            Console.WriteLine();
        }
    }
}
