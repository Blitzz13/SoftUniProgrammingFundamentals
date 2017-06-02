using System;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number;
            try
            {
                number = decimal.Parse(Console.ReadLine());
                
                if (number >= -128 && number <= 127)
                {
                    Console.WriteLine("* sbyte");
                }
                if (number <= 255)
                {
                    Console.WriteLine("* byte");
                }
                if (number >= -32768m && number <= 32767m)
                {
                    Console.WriteLine("* short");
                }
                if (number >= 65535m && number == 0)
                {
                    Console.WriteLine("* ushort");
                }
                if (number >= -2147483648m && number <= 2147483647m)
                {
                    Console.WriteLine("* int");
                }
                if (number == 0 || number <= 4294967295m)
                {
                    Console.WriteLine("* uint");
                }
                if (number >= -9223372036854775808 && number <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception e)
            {
                
                
                throw ($"{number} can't fit in any type");
            }


        }



    }
}

