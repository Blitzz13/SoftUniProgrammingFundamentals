using System;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            int counter = 1;
            double tempPrice = 0.00;
            double subtotalPrice = 0.00;
            do
            {
                if (numberOfItems == 0)
                {
                    break;
                }
                tempPrice = 0.00;
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                tempPrice = itemPrice * itemCount;
                subtotalPrice += tempPrice;
                if (itemCount > 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                counter++;

            } while (counter != numberOfItems + 1);
            Console.WriteLine($"Subtotal: ${subtotalPrice:F2}");
            if (budget > subtotalPrice)
            {
                Console.WriteLine($"Money left: ${(budget - subtotalPrice):F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget - subtotalPrice):F2} more.");
            }
        }
    }
}
