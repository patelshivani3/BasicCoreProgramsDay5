using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class Swapping
    {
        public static void Swap()
        {
            Console.Write("Enter A : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter B : ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            a = b; 
            b = c;
            Console.WriteLine("After Swapping....");
            Console.WriteLine("\n A : {0}\n B : {1}",a,b);
        }
    }
}
