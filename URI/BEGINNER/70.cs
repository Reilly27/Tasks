using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program
    {


        public static void Main()
        {

            int a = int.Parse(Console.ReadLine());           
                for (int j = 1; j <= a * 4; j++)
                {
                    if (j % 4 != 0) Console.Write(j + " ");
                    if (j % 4 == 0) Console.Write("PUM" + "\n");
                }                           
        }
    }    
}