using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class dowhile
    {
        static void Main()
        {
            string choise;
            do
            {
                double n, p;
                Console.Write("Enter any number : ");
                n = Convert.ToInt32(Console.ReadLine());
                p = Math.Pow(n, 3);
                Console.Write("\n\n\t\tThe cube is : {0}", p);
                Console.Write("\n\n\t\tEnter/Press 'Y' to continue else 'N' :");
                choise = Console.ReadLine();

            }
            while (choise == "Y");
            Console.ReadLine();

        }
    }
}
