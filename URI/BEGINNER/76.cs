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
            double i, b = 1, c, S = 0;
            for (i = 1; i <= 100; i++)
            {
                c = 1 / i;
                S += c;
            }

            Console.WriteLine("{0:0.00}",S);
            
            
        }
        

    }
}