using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class ifelse
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter any number b/w 1-5:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.Write("The number U entered is ONE");
            
            }

           else if (num == 2)
            {
                Console.Write("The number U entered is TWO");

            }
            else if (num == 3)
            {
                Console.Write("The number U entered is THREE");

            }
           else if (num == 4)
            {
                Console.Write("The number U entered is FOUR");

            }
           else if (num == 5)
            {
                Console.Write("The number U entered is FIVE");

            }
            else
            {
                Console.Write("error");
            }
            Console.Read();

        }
    }
}
