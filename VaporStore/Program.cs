using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double gamePrice = 0;
            double spentMoney = 0;
            string game;
            do
            {
                game = Console.ReadLine();
                if (game == "OutFall 4")
                {
                    gamePrice = 39.99;
                }
                else if (game == "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (game == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                }
                else if (game == "Honored 2")
                {
                    gamePrice = 59.99;
                }
                else if (game == "RoverWatch")
                {
                    gamePrice = 29.99;
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                }
                else if (game == "Game Time")
                {
                    break;
                }
                else
                {

                    Console.WriteLine("Not Found");
                    //game = Console.ReadLine();
                    continue;
                }
                if (balance < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                balance -= gamePrice;
                spentMoney += gamePrice;
                Console.WriteLine($"Bought {game}");
                if (balance < 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

            } while (balance > 0 || game != "Game Time" || balance >= 15.99);

            if (game == "Game Time" || balance > 0)
            {
                Console.WriteLine($"Total spent: ${spentMoney:F2}. Remaining: ${balance:F2}");
            }
        }
    }
}
