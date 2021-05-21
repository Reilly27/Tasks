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

            string q;
            q = Console.ReadLine();
            int[] result = q.Split().Select(int.Parse).ToArray();
            int q1 = result[0];
            int q2 = result[1];
            
            for (int j = 1; j <= q2; j++){

                if (j % q1 == 0) Console.Write(j + "\n");
                if (j % q1 != 0) Console.Write(j + " ");               
            }
            
        }
    }    
}
