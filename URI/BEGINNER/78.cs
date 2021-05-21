using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program {
        public static void Main() {
            int imput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= imput; i++) {
                if (imput % i == 0) Console.WriteLine(i);
            }                        
        }        
    }
}
