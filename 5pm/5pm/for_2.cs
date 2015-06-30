using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class for_2
    {
        static void Main()
        {
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 4; c >= r; c--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();         
            }
            Console.Read();                  
        }
    
    }
}
