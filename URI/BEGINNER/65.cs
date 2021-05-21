using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int numb = int.Parse(Console.ReadLine());
            for (int i = 0; i < numb; i++)
            {
                input = Console.ReadLine();
                int[] result = input.Split().Select(int.Parse).ToArray();
                int q1 = result[0];
                int q2 = result[1];
                if (q2 == 0) Console.WriteLine("divisao impossivel");
                double x = Convert.ToDouble(q1);
                double y = Convert.ToDouble(q2);
                if (q2 != 0)
                {
                    double oput = x / y;
                    Console.WriteLine("{0:0.0}",oput);
                    
                }


            }
        } 
    }
}
