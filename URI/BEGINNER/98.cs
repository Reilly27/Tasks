using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program {
        public static void Main() {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++) {
                Console.Write("Ho");
                if (i < a) Console.Write(" ");
            }           
            Console.Write("!");
            Console.WriteLine();
        }
    } 