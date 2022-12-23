using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class LeapYear
    {
        public static void leapYear() 
        {
            Console.WriteLine("Enter the 4 digit year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            
                Console.WriteLine("Year {0} is leap year", year);
            else
                Console.WriteLine("Year {0} is not a leap year",year);
        }
    }
}
