using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int chese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int callorieSum = 0;
            int counter = 1;
            int i = int.Parse(Console.ReadLine());
            do
            {

                string ingredient = Console.ReadLine();

                if (String.Compare(ingredient, "Cheese", true) == 0)
                {
                    callorieSum += chese;
                }
                else if (String.Compare(ingredient, "Tomato sauce", true) == 0)
                {
                    callorieSum += tomatoSauce;
                }
                else if (String.Compare(ingredient, "Salami", true) == 0)
                {
                    callorieSum += salami;
                }
                else if (String.Compare(ingredient, "Pepper", true) == 0)
                {
                    callorieSum += pepper;
                }else
                {
                    callorieSum += 0;
                }
                counter++;
                
            } while (counter <= i);

            Console.WriteLine($"Total calories: {callorieSum}");

        }
    }
}
