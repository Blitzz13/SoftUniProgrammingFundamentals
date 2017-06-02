using System;

namespace ChooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string proffesion = Console.ReadLine();

            if (proffesion == "Athlete")
            {
                Console.WriteLine("Coffee");
            }
            else if (proffesion == "Businessman" || proffesion == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (proffesion == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }

        }
    }
}
