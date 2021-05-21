using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program {
        public static void Main() {
         
            int inp;
            int a = int.Parse(Console.ReadLine());
            int b;
            for (int i = 0; i < a; i++)
            {
                inp = int.Parse(Console.ReadLine());
                b = 0;
                for (int j = 1; j < inp; j++)
                    if (inp % j == 0)
                    {
                        b += j;
                       
                    }
                if (b == inp)
                    Console.WriteLine(inp + " eh perfeito");
                else
                    Console.WriteLine(inp + " nao eh perfeito");
            }

        }        
    }
}