using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string messege = string.Empty;
            for (int i = 0; i < n; i++)
            {
                
                string digit = Console.ReadLine();
                int mainDigit = int.Parse(digit[0].ToString());
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int letterIndex = offset + digit.Length - 1;

                if (mainDigit == 0)
                {
                    messege += " ";
                }
                else
                {
                    messege +=(char) (97 + letterIndex);
                }
            }
            Console.WriteLine(messege);
        }
    }
}
