using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5pm
{
    class sqr
    {
        int a, b;

        public void EnterVal()
        {
            Console.WriteLine("Please enter one integer value:");
            a = Convert.ToInt32(Console.ReadLine());

        }

        public void mult()
        {
            b = a * a;
            Console.Write("Square is :" + b);

        }

        public void cub()
        {
            b = a * a * a;
            Console.Write("Cube is:" + b);

        }

    }

    delegate void mydel();


    class roughcheck
    {
        static void Main()
        {
            sqr obj = new sqr();
            mydel objDel1 = new mydel(obj.EnterVal);
            objDel1 += obj.mult;
            objDel1 += obj.cub;
            objDel1();
            Console.Read();

        }

    }
}
