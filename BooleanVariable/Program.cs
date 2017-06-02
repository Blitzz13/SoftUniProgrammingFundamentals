using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();
            bool yes = true;
            if (boolean == "True")
            {
                Console.WriteLine("Yes");
            }
            else if (boolean == "False")
            {
                Console.WriteLine("No");
            }
        }
    }
}
