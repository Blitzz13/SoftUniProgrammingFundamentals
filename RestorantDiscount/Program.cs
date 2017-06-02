using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupeSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int packagePrice;
            double packageDiscount;
            

            if (package == "Normal")
            {
                packagePrice = 500;
                packageDiscount = 0.95;
                if (groupeSize <= 50)
                {
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(((2500 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else if (groupeSize > 50 && groupeSize <= 100)
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(((5000 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else if (groupeSize > 100 && groupeSize <= 120)
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(((7500 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                packageDiscount = 0.90;
                if (groupeSize <= 50)
                {
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(((2500 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else if (groupeSize > 50 && groupeSize <= 100)
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(((5000 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else if (groupeSize > 100 && groupeSize <= 120)
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(((7500 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }
            else if (package == "Platinum")
            {
                packagePrice = 1000;
                packageDiscount = 0.85;
                if (groupeSize <= 50)
                {
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(((2500 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else if (groupeSize > 50 && groupeSize <= 100)
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(((5000 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else if (groupeSize > 100 && groupeSize <= 120)
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(((7500 + packagePrice) * packageDiscount) / groupeSize):F2}$");
                }
                else
                {
                    Console.WriteLine("We do not have an appropriate hall.");
                }
            }

          

            

        }
    }
}
