using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int currentLiters = 0;
            int litersFittingToTank = 0;
            do
            {
                int literToPoor = int.Parse(Console.ReadLine());
                currentLiters += literToPoor;
                if (currentLiters > tankCapacity)
                {
                    if (litersFittingToTank + literToPoor <= tankCapacity)
                    {
                        litersFittingToTank += literToPoor;
                        n--;
                        continue;
                    }
                    Console.WriteLine("Insufficient capacity!");
                    n--;
                    continue;
                }
                litersFittingToTank += literToPoor;

                n--;
               
            } while (n != 0);

            Console.WriteLine(litersFittingToTank);
        }
    }
}
