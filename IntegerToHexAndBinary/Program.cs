using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decValue = int.Parse(Console.ReadLine()) ;

            string hexValue = decValue.ToString("X");
            Console.WriteLine(hexValue);
            string binary = Convert.ToString(decValue, 2);
            Console.WriteLine(binary);
        }
    }
}
