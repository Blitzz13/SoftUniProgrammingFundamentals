using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long number1 = long.Parse(Console.ReadLine());
            long number2 = long.Parse(Console.ReadLine());
            bool isOtherNumber1 = false;
            bool isOtherNumber2 = false;
            if (number1 >= sbyte.MinValue && number1 <= sbyte.MaxValue)
            {
                number1 *= 4;
                isOtherNumber1 = true;
            }
            else if (number2 >= sbyte.MinValue && number2 <= sbyte.MaxValue)
            {
                number2 *= 4;
                isOtherNumber2 = true;
            }
            if (number1 >= int.MinValue && number1 <= int.MaxValue && !isOtherNumber1)
            {
                number1 *= 10;
            }
            else if (number2 >= int.MinValue && number2 <= int.MaxValue && !isOtherNumber2)
            {
                number2 *= 10;
            }

            long sum = number1 + number2;
            Console.WriteLine(sum);
        }
    }
}
