using System;
using System.Linq;


namespace LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
           
            string inputArrOne = Console.ReadLine();
            string inputArrTwo = Console.ReadLine();
            readWords(inputArrOne, inputArrTwo);
        }

        static void readWords(string inputArrOne, string inputArrTwo)
        {

            string[] items1 = inputArrOne.Split(' ');
            string[] items2 = inputArrTwo.Split(' ');
           
            int counterLeft = 0;
            int counterRight = 0;
            int legnht = 0;

            if (items1.Length < items2.Length)
            {
                legnht = items1.Length;
            }
            else
            {
                legnht = items2.Length;
            }
            for (int i = 0; i <= legnht; i++)
            {
                try{
                    if (items1[i] == items2[i])
                    {

                        counterLeft++;
                    }
                }
                catch
                {
                   
                }

            }

            Array.Reverse(items1);
            Array.Reverse(items2);
            

            for (int i = 0; i <= legnht; i++)
            {
                try
                {
                    if (items1[i] == items2[i])
                    {

                        counterRight++;
                    }
                }
                catch
                {

                }
            }
            if (counterLeft > counterRight)
            {
                Console.WriteLine(counterLeft);
            }
            else if (counterRight > counterLeft)
            {
                Console.WriteLine(counterRight);
            }
            else if (counterRight == counterLeft)
            {
                Console.WriteLine(counterRight);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
