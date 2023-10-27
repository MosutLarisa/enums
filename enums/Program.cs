﻿using System.Transactions;

namespace enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DayOfWeek friday = DayOfWeek.Friday;
            Console.WriteLine(friday);

            int fridayAsInt = (int)friday;
            Console.WriteLine(fridayAsInt);

            DayOfWeek day = (DayOfWeek)100;
            Console.WriteLine(day); 


            /*
             * 2^0 = 0 0 0 0 0 0 0 1 (Monday)
             * 2^1 = 0 0 0 0 0 0 1 0 (Tuesday)
             * 2^2 = 0 0 0 0 0 1 0 0 (Wednseday)
             * 2^3 = 0 0 0 0 1 0 0 0 (Thursday)
             * 2^4 = 0 0 0 1 0 0 0 0 (Friday)
             * 2^5 = 0 0 1 0 0 0 0 0 (Saturday)
             * 2^6 = 0 1 0 0 0 0 0 0 (Sunday)
             * ----------------------------------
             *       0 1 1 0 0 0 0 0 (Saturday+Sunday)
             */

            DayOfWeek weekend = DayOfWeek.Saturday | DayOfWeek.Sunday; 
            Console.WriteLine(weekend);



            Console.WriteLine("enter a day= ");
            string dayValue = Console.ReadLine();

            /*
             *Console.Write("Enter a day = ");
             *string dayValue = Console.ReadLine();
             */


            //varianta 1
            bool canConvert = Enum.TryParse(typeof(DayOfWeek), dayValue, out object result);
            if (canConvert)
            {
                DayOfWeek converterDayOfWeek = (DayOfWeek)result;
            }
            else
            {
                Console.WriteLine($"' {dayValue} ' doesn't represent a valid DayOfWeek");
            }

            //varianta 2
            bool canConvert2 = Enum.TryParse( dayValue, out DayOfWeek resultDayOfWeek);
            if (canConvert2)
            {
                Console.WriteLine(resultDayOfWeek);
            }
            else
            {
                Console.WriteLine($"' {dayValue} ' doesn't represent a valid DayOfWeek");
            }
        }
    }
}