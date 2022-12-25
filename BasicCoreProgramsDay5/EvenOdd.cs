using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class EvenOdd
    {
        public static void Number()
        {
            Console.Write("\nEnter the number to check : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("\n{0} is Even Number", n);
            else
                Console.WriteLine("\n{0} is Odd Number", n);
        }
    }
}
