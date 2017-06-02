using System;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int repeat = n - 2;
            //top
            int spaces = 0;
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}",new string(' ', spaces++),new string(' ',repeat));
                
                repeat -= 2;
            }
            Console.WriteLine("{0}x{0}", new string(' ',spaces));
            repeat = 1;
            for (int i = 0; i < n / 2; i++)
            {
                spaces--;
                Console.WriteLine("{0}x{1}x{0}", new string(' ', spaces), new string(' ', repeat));
                repeat += 2;
            }
        }
    }
}
