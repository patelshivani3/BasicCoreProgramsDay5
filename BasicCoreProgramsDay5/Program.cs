﻿using System;
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
            Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.Power Of 2");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin.CoinPercentage();
                    break;

                case 2:
                    LeapYear.leapYear();
                    break;

                case 3:
                    PowerOf2.powerOf2();
                    break;
            }
            Console.ReadLine();

        }
    }
}