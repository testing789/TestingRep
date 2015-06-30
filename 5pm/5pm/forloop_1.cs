using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class forloop_1
    {
        static void Main()
        {
            int n;
            Console.Write("Enter any number : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The factors of {0} are :", n);
            for (int i=1; i<=n;i++ )
            {
                if (n % i == 0)
                {
                    Console.Write(""+i);
                }
            }
            Console.Read();
            
        }
    }
}
