using System;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number ; i++)
            {
                if (SumOfDigits(i) && IsPalindrome(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumOfDigits(int number)
        {
            int digitsCount = number.ToString().Length;
            int sum = 0;
            int oldNum = 0;
            for (int i = 0; i < digitsCount; i++)
            {
                oldNum = number % 10;
                sum += oldNum;
                number /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsPalindrome(int number)
        {

            string numberString = number.ToString();
            char[] charArray = numberString.ToCharArray();
            Array.Reverse(charArray);
            numberString = string.Join("", charArray);
            int newNumber = int.Parse(numberString);

            if (newNumber == number)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool ContainsEvenDigit(int number)
        {
            int digitsCount = number.ToString().Length;
            int oldNum = 0;
            for (int i = 0; i < digitsCount; i++)
            {
                oldNum = number % 10;
                if (oldNum % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }
    }
}
