using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            long maxValue = 0L;
           

            if (type == "sbyte" )
            {
                maxValue = sbyte.MaxValue;
            }
            else if (type == "int")
            {
                maxValue = int.MaxValue;
            }
            else if (type == "long")
            {
                maxValue = long.MaxValue;
            }

            int n = int.Parse(Console.ReadLine());
            long thiefId = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                long tempId = long.Parse(Console.ReadLine());
                if (tempId > thiefId && tempId <= maxValue)
                {
                    thiefId = tempId;
                }
            }
            Console.WriteLine(thiefId);
        }
    }
}
