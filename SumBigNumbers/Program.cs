using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int length = Math.Max(num1.Length, num2.Length);

            num1.Reverse();
            num2.Reverse();
            int sum = 0;
            int rem = 0;
            int lastNum1 = 0;
            int lastNum2 = 0;

            List<char> nums = new List<char>();
            for (int i = 0; i < length; i++)
            {
                if ((num1.Length - 1 - i) >= 0)
                {
                    lastNum1 = num1.Skip(num1.Length - 1 - i).First() - '0';
                }
                else
                {
                    lastNum1 = 0;
                }

                if ((num2.Length - 1 - i) >= 0)
                {
                    lastNum2 = num2.Skip(num2.Length - 1 - i).First() - '0';
                }
                else
                {
                    lastNum2 = 0;
                }

                sum = lastNum1 + lastNum2 + rem;
                rem = sum / 10;
                sum %= 10;
                nums.Add((char)(sum + '0'));
            }
            if (rem > 0)
            {
                nums.Add((char)(rem + '0'));
            }
            nums.Reverse();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == '0')
                {
                    nums.RemoveAt(i);
                    i--;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join("", nums));
        }
    }
}
