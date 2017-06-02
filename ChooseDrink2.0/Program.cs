using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            if (proffesion == "Athlete")
            {
                Console.WriteLine($"The {proffesion} has to pay {(amount * 0.70):F2}.");
            }
            else if (proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                Console.WriteLine($"The {proffesion} has to pay {(amount * 1):F2}.");
            }
            else if (proffesion == "SoftUni Student")
            {
                Console.WriteLine($"The {proffesion} has to pay {(amount * 1.70):F2}.");
            }
            else
            {
                Console.WriteLine($"The {proffesion} has to pay {(amount * 1.20):F2}.");
            }
        }
    }
}
