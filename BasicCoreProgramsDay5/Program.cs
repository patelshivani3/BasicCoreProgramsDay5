using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic core programs");
            Console.WriteLine("1.FlipCoin");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin.CoinPercentage();
                    break;
            }
            Console.ReadLine();

        }
    }
}
