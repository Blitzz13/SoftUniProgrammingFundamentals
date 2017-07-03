using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();

            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int[] checkPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                string driverName = drivers[i];
                double driverFuel = drivers[i].ToCharArray().First();

                for (int checkPoint = 0; checkPoint < zones.Length; checkPoint++)
                {
                    if (checkPoints.Contains(checkPoint))
                    {
                        driverFuel += zones[checkPoint];
                    }
                    else
                    {
                        driverFuel -= zones[checkPoint];
                    }
                    if (driverFuel <= 0)
                    {
                        Console.WriteLine($"{driverName} - reached {checkPoint}");
                        break;
                    }
                    else if (checkPoint == zones.Length - 1)
                    {
                        Console.WriteLine($"{driverName} - fuel left {driverFuel:f2}");
                    }
                    
                }

            }
        }
    }
}
