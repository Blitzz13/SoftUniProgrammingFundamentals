using System;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int firstLetter = 1; firstLetter <= 4; firstLetter++)
            {
                for (int secondsLetter = 1; secondsLetter <= 4; secondsLetter++)
                {
                    for (int thirdLetter = 1; thirdLetter <= 4; thirdLetter++)
                    {
                        counter++;
                        if (firstLetter + secondsLetter + thirdLetter >= n)
                        {
                            Console.Write("O"+("" + firstLetter + secondsLetter + thirdLetter).Replace('1','A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + firstLetter + secondsLetter + thirdLetter).Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }
                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
