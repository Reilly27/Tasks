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
            double b = 0, c = 0, y = -1; 
            while(b >= 0)
            {
                double imput = double.Parse(Console.ReadLine());
                if(imput > 0)c += imput; 
                b = imput;
                y++;
            }
            double ouput = c / y;
            Console.WriteLine("{0:0.00}", ouput);          
        }
        

    }
}