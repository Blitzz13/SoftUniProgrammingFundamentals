using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0.00, dvoika = 0.00, suite = 0.00;
            if (month == "May" || month == "October")
            {
                studio = 50;
                dvoika = 65;
                suite = 75;
                if (nights > 7)
                {
                    studio *= 0.95;

                }

            }
            else if (month == "June" || month == "September")
            {
                studio = 60;
                dvoika = 72;
                suite = 82;

                if (nights > 14)
                {
                    dvoika *= 0.90;

                }

            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                dvoika = 77;
                suite = 89;


                if (nights > 14)
                {
                    suite *= 0.85;

                }


            }

            double studioPrice = studio * nights;
            double dvoikaPrice = dvoika * nights;
            double suitePrice = suite * nights;

            if ((month == "September" || month == "October") && nights > 7)
            {
                studioPrice -= studio;
               
            }
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {dvoikaPrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");

        }
    }
}

