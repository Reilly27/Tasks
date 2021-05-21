using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program
    {


        public static void Main() {
            double i, b = 3, c, S = 0, a = 2;
            for (i = 1; i <= 100; i++)
            {
                c = b / a;                
                b += 2;
                a *= 2;
                S += c;
            }

            Console.WriteLine("{0:0.00}",S + 1);
            
            
        }
        

    }
}