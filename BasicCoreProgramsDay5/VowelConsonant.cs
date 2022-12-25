using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class VowelConsonant
    {
        public static void Alphabet()
        {
            Console.Write("Enter any letter : ");
           char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                Console.WriteLine("\n{0} is Vowel.",ch);
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                 Console.WriteLine("\n{0} is Consonant.",ch);
            
        }
    }
}
