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
            for (int j = 1; j <= a; j++){
                    for (int i = 1; i <= 3; i++){
                    if(i == 1)Console.Write(j +" ");
                    if (i == 2) Console.Write(j * j + " ");
                    if (i == 3) Console.Write(j * j * j); 
                    }
                    Console.WriteLine();
                for (int i = 1; i <= 3; i++)
                {
                    if (i == 1) Console.Write(j + " ");
                    if (i == 2) Console.Write(j * j +1 + " ");
                    if (i == 3) Console.Write(j * j * j +1);
                }
                Console.WriteLine();
            }                 
        }
    }    
}
