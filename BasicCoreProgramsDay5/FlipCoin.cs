using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class FlipCoin
    {
        public static void CoinPercentage()
        {
            int tailCount = 0, headCount = 0;
            Console.WriteLine("Enter the number to flip the coin : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for (int i = 1; i < n; i++)
            {
                double input = random.NextDouble();
                if (input < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("TailCount:{0} & HeadCount:{1}", tailCount, headCount);
            double tailPercentage = (tailCount * 100) / n;
            double headPercentage = (headCount * 100) / n;
            Console.WriteLine("TailCount:{0}% & HeadCount:{1}%", tailPercentage, headPercentage);
        }
    }
}


