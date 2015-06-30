using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    
    class rough
    {
        static void Main()
        {
           
            int num, sum = 0;
            Console.Write("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int n=num;n>0 ;n=n/10 )
            {
                sum = sum + n % 10;
            }

            Console.Write("\n\n\tSum of the digits of the number is :" + sum);
            Console.Read();
        }
    }
}
