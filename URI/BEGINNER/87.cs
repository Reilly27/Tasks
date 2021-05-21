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
            int X, Z, inp;
            X = int.Parse(Console.ReadLine());
            Z = int.Parse(Console.ReadLine());
            while (Z <= X)
            {
                Z = int.Parse(Console.ReadLine());
            }
            inp = 0;
            for (int i = 1; true; i++)
            {
                inp += X;
                X++;
                if (inp > Z)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }                    
}