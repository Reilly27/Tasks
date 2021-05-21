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
            double[] A = new double[100];

            for (int i = 0; i < 100; i++)
            {
                double inp = double.Parse(Console.ReadLine());
                if (inp <= 10)
                {
                    A[i] = inp;
                    string result = A[i].ToString("0.0");
                    Console.WriteLine("A[" + i + "] = " + result);
                }              
            }                                 
        }
    }
}