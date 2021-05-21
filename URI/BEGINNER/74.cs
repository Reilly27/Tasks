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

            int a = int.Parse(Console.ReadLine());
            int b = 1;           
            for (int i = 0; i < (a - 1); i++){
                b *= (a - i);
            }
            Console.WriteLine(b);
            
        }
    }    
}