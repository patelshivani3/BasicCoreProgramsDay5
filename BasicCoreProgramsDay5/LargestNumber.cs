using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class LargestNumber
    {
        public static void Largest() 
        {
            Console.WriteLine("\nEnter 3 numbers : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("\n{0} is the largest Number",a);
            else if (b > a && b > c)
                Console.WriteLine("\n{0} is the largest Number",b);
            else
                Console.WriteLine("\n{0} is the largest Number",c);
        }
    }
}
