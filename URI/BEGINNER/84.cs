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
            int[] N = new int[10];
            int inp = int.Parse(Console.ReadLine());
            N[0] = inp;
            Console.WriteLine("N[" + 0 + "] = " + N[0]);
            for (int i = 1; i < 10; i++)
            {                       
                    N[i] = inp *= 2;
                    Console.WriteLine("N[" + i + "] = " + N[i]);                
            }           
        }
    }
}
