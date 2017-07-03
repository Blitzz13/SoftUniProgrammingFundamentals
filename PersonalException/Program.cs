using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        throw new PersonalException();
                    }
                    Console.WriteLine(number);
                }
            }
            catch (PersonalException pe)
            {
                Console.WriteLine(pe.Message);
                return;
            }
        }
    }
    class PersonalException : Exception
    {
        public PersonalException() :base("My first exception is awesome!!!")
        {

        }
    }
}
