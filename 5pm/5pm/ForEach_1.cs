using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class ForEach_1
    {
        static void Main()
        {
            string[] ary = new string[5] {"Raju","Anil","Ajay","Mohit","Ram" };
            Console.Write("The elements of the array are : ");

            foreach (string x in ary)
            {
                Console.Write(x + "  ");
            }
            Console.Read(); 
        }

    }
}
