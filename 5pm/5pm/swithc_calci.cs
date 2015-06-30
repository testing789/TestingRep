using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class swithc_calci
    {
        static void Main()
        {
            int num1, num2, choise, rslt=0;
            Console.WriteLine("Enter any two numbers : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\tEnter your choise\n\t1. Add\t2. Sub\n\t3. Mult\t 4. Div");
            choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    rslt = num1 + num2;
                    break;
                case 2:
                    rslt = num1 - num2;
                    break;
                case 3:
                    rslt = num1 * num2;
                    break;
                case 4:
                    rslt = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Wrong Choise");
                    break;
            }
            Console.WriteLine("\n\n\t\t the first number is = {0} and the second number is = {1}\n\n\t\tResult = {2}",num1,num2,rslt);
            Console.Read();
        }
    }
}
