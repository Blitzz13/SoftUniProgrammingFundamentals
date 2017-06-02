using System;

namespace MagickLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());
            int count = 0;

            for (char firstLetter = start; firstLetter <= end; firstLetter++)
            {
                for (char secondLetter = start; secondLetter <= end; secondLetter++)
                {
                    for (char thirdLetter = start; thirdLetter <= end; thirdLetter++)
                    {
                        if (firstLetter != skip && secondLetter != skip && thirdLetter != skip)
                        {

                            Console.Write("{0}{1}{2} ", firstLetter, secondLetter, thirdLetter);
                            count++;
                        }
                    }
                }
            }
        }
    }
}
