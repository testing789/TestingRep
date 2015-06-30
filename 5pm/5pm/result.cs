using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class result
    {
        static void Main()
        {
            int m1=0, m2=0, ttl=0;

            Console.Write("Enter m1 marks:");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter m2 marks:");
            m2 = Convert.ToInt32(Console.ReadLine());

            ttl = m1 + m2;

            if (m1 >= 35 && m2 >= 35)
            {
                Console.WriteLine("\n\n Passed with " + ttl + " marks");
            
            }
            else if (m1 < 35 || m2 < 35)
            {
                Console.WriteLine("\n\n Failed with " + ttl + " marks");
            }

            Console.ReadLine();
        
        }
    }
}
