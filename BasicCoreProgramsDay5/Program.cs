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
            Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.Power Of 2\n4.Harmonic Number\n5.Prime Factors\n6.Division\n7.Swapping\n8.EvenOdd Number\n9.Vowel&Consonant");
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
               
                case 4:
                    HarmonicNumber.harmonicNumber(); 
                    break;
                
                case 5:
                    PrimeFactors.Factors(); 
                    break;

                case 6:
                    Division.Div();
                    break;

                case 7:
                    Swapping.Swap();
                    break;

                case 8:
                    EvenOdd.Number();
                    break;

                case 9:
                    VowelConsonant.Alphabet();
                    break;
            }
            Console.ReadLine();

        }
    }
}
