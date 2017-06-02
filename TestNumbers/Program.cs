using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            int moves = 0;
            int score = 0;

            for (int firstNumber = n; firstNumber >= 1; firstNumber--)
            {
                for (int secondNumber = 1; secondNumber <= m; secondNumber++)
                {
                    if (score >= controlNumber)
                    {
                        break;
                    }


                    score += 3 * (firstNumber * secondNumber);


                    moves++;
                }
            }
            if (score >= controlNumber)
            {
                Console.WriteLine($"{moves} combinations");
                Console.WriteLine($"Sum: {score} >= {controlNumber}");

            }
            else
            {
                Console.WriteLine($"{moves} combinations");
                Console.WriteLine($"Sum: {score}");
            }


        }
    }
}
