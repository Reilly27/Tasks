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
            
            int[] N = new int[1000];
            int A = 0;
            int i;
            int X = int.Parse(Console.ReadLine());
            for (i = 0; i < 1000; i++)
            {
                N[i] = A;
                A++;

                if (A == X) A = 0;
            }

            for (i = 0; i < 1000; i++)
            {
                Console.WriteLine("N[" + i + "] = " + N[i]);
            }
            
        }
    }
}