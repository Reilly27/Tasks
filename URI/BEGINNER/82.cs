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

            int inp;
            int i1 = 2;
            int a = int.Parse(Console.ReadLine());
            int b;
            for (int i = 0; i < a; i++)
            {
                inp = int.Parse(Console.ReadLine());
                for (i1 = 2; i1 <= (inp - 1); i1++)
                {
                    if (inp % i1 == 0)
                    {
                        Console.WriteLine(inp + " nao eh primo");
                        break;
                    }
                }
                if (i1 == inp)
                {
                    Console.WriteLine(inp + " eh primo");

                }

            }
        }
    }
}
