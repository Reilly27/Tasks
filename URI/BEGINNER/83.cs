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
            int[] x = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                if (inp <= 0)
                {
                    x[i] = 1;
                    Console.WriteLine("X["+i+"] = " + x[i]);
                }
                else
                {
                    x[i] = inp;
                    Console.WriteLine("X[" + i + "] = " + x[i]);
                }
            }           
        }
    }
}