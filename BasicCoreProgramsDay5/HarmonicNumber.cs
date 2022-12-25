using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class HarmonicNumber
    {
        public static void harmonicNumber() 
        {
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            for(int i=1; i<=n; i++)
            {
                Console.Write("1/{0} + ", i);
                sum =sum + 1 / (float)i;
            }
            Console.WriteLine("\nHarmonic Number of {0} is :{1}", n, sum);
        }
        
    }
}
