using System;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            PrintNameOfLastDigitName(num);
            
        }

        static void PrintNameOfLastDigitName(long digit)
        {
            Math.Abs(digit %= 10);
            
            if (Math.Abs(digit) == 1)
            {
                Console.WriteLine("one");
            }
            else if (Math.Abs(digit) == 2)
            {
                Console.WriteLine("two");
            }
            else if (Math.Abs(digit) == 3)
            {
                Console.WriteLine("three");
            }
            else if (Math.Abs(digit) == 4)
            {
                Console.WriteLine("four");
            }
            else if (Math.Abs(digit) == 5)
            {
                Console.WriteLine("five");
            }
            else if (Math.Abs(digit) == 6)
            {
                Console.WriteLine("six");
            }
            else if (Math.Abs(digit) == 7)
            {
                Console.WriteLine("seven");
            }
            else if (Math.Abs(digit) == 8)
            {
                Console.WriteLine("eight");
            }
            else if (Math.Abs(digit) == 9)
            {
                Console.WriteLine("nine");
            }
            else if (Math.Abs(digit) == 0)
            {
                Console.WriteLine("zero");
            }
            
        }
    }
}
