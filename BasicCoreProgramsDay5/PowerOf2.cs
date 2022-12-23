using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class PowerOf2
    {
        public static void powerOf2()
        {
            Console.WriteLine("Enter the power value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                num = 2 * i;
                Console.WriteLine("2 ^ {0} = {1}", i, num);
            }
            Console.WriteLine("================\n2 ^ {0} : {1}", n, num);

        }
    }
}
