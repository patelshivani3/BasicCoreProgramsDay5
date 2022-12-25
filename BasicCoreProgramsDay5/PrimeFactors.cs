using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class PrimeFactors
    {
        public static void Factors()
        { 
            Console.WriteLine("\nEnter the number to find prime factors : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i<=n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i+ " ");
                    n=n/i;
                }
            }

        }
    }
}
