using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class Division
    {
        public static void Div() 
        {
            Console.WriteLine("Enter the divident : ");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor : ");
            int d2 = Convert.ToInt32(Console.ReadLine());

            double remainder = d1 % d2;
            double quotient = d1 / d2;

            Console.WriteLine("\nQuotient : " + quotient);
            Console.WriteLine("\nRemainder : " + remainder);
        }
    }
}
