using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program {
        public static void Main()
        {
            int inp = int.Parse(Console.ReadLine());
            int a = 0, b = 1;
            int c, d, y;
            if(inp > 1)Console.Write(a + " " + b);
            if (inp <= 1) Console.Write(a);
            for (int i = 2; i < inp; i++)
            {
                c = a + b;
                d = a;
                a = b;
                b = c;

                Console.Write(" " + c);
            }
            Console.WriteLine();
        }
    }                    
}