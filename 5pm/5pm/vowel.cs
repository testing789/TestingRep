using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class vowel
    {
        static void Main()
        {
            string s;
            Console.Write("Enter any alphabet: ");
            s = Console.ReadLine();

            if (s == "a" || s == "i" || s == "o" || s == "u" || s == "e")
            {
                Console.WriteLine("The character is VOWEL");
            }

            else
            {
                Console.WriteLine("The character you entered is not VOWEL");
            }

            Console.Read();
        
        }
    }
}
