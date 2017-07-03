using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            var splitedEmail = email.Split('@');
            List<char> firstPart = splitedEmail[0].ToList();
            List<char> secondPart = splitedEmail[1].ToList();
            int firstPartSum = firstPart.Sum(a => a);
            int secondPartSum = secondPart.Sum(a => a);
            if (firstPartSum - secondPartSum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }

        }
    }
}
