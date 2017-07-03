using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();


            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] == '0')
                {
                    num1 = num1.Remove(i, 1);
                    i--;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < num2.Length; i++)
            {
                if (num2[i] == '0')
                {
                    num2 = num2.Remove(i, 1);
                    i--;
                }
                else
                {
                    break;
                }
            }

            if (num1 == "" || num2 == "")
            {
                Console.WriteLine("0");
            }
            else
            {
                int maxLength = Math.Max(num1.Length, num2.Length);
                int minLength = Math.Min(num1.Length, num2.Length);

                string greaterNum;
                string smallerNum;

                if (num1.Length > num2.Length)
                {
                    greaterNum = num1;
                    smallerNum = num2;
                }
                else
                {
                    greaterNum = num2;
                    smallerNum = num1;
                }

                int sum = 0;
                int rem = 0;
                int lastNum1 = 0;
                int lastNum2 = 0;
                List<char> nums = new List<char>();
                nums.Add('0');
                int i1 = 0;
                for (int i = maxLength - 1; i >= 0; i--)
                {
                    int j1 = 0;
                    for (int j = minLength - 1; j >= 0; j--)
                    {
                        lastNum1 = greaterNum[i] - '0';
                        lastNum2 = smallerNum[j] - '0';
                        if (i1 + j1 > nums.Count - 1)
                        {
                            nums.Insert(i1 + j1, '0');
                        }
                        sum = (lastNum1 * lastNum2) + rem + nums[i1 + j1] - '0';
                        rem = sum / 10;
                        sum %= 10;          
                        nums[i1 + j1] = (char)(sum + '0');                        
                        j1++;
                    }
                    nums.Add((char)(rem + '0'));
                    rem = 0;
                    i1++;
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
}
