using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new[]
            {
               "01 01",
               "03 03",
               "01 05",
               "06 05",
               "24 05",
               "06 09",
               "22 09",
               "01 11",
               "24 12",
               "25 12",
               "26 12"

            }.Select(a => DateTime.ParseExact(a,"dd MM", CultureInfo.InvariantCulture)).ToArray();

            int wokingDaysCount = 0;

            for (DateTime currentdate = startDate; currentdate <= endDate; currentdate = currentdate.AddDays(1))
            {
                var isWeekend = currentdate.DayOfWeek == DayOfWeek.Saturday 
                    || currentdate.DayOfWeek == DayOfWeek.Sunday;

                var isHoliday = holidays.Any(d => d.Day == currentdate.Day && d.Month == currentdate.Month);

                var isWorkingDay = !(isWeekend || isHoliday);

                if (isWorkingDay)
                {
                    wokingDaysCount++;
                }
            }
            Console.WriteLine(wokingDaysCount);
        }
    }
}
