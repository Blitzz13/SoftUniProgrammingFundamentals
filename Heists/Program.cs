using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceOfLoot = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int jewelPrice = priceOfLoot[0];
            int goldPrice = priceOfLoot[1];
            long totalLoot = 0l;
            long totalExpenses = 0;

            string[] tokens = Console.ReadLine().Split();

            while (!(tokens[0] == "Jail"))
            {
                string loot = tokens[0];
                int expenses = int.Parse(tokens[1]);
                totalExpenses += expenses;

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        totalLoot += jewelPrice;

                    }
                    else if (loot[i] == '$')
                    {
                        totalLoot += goldPrice;
                    }
                }

                tokens = Console.ReadLine().Split();

            }

            if (totalExpenses <= totalLoot )
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalLoot - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalLoot}.");
            }
        }
    }
}
