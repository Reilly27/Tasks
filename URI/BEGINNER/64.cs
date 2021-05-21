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

            for (int i = 0; i < 200; i++)
            {
                input = Console.ReadLine();
                int[] result = input.Split().Select(int.Parse).ToArray();
                int q1 = result[0];
                int q2 = result[1];

                if (q1 == 0 || q2 == 0)
                {
                    Environment.Exit(0);
                }
                
                    if (q1 > 0 && q2 > 0) Console.WriteLine("primeiro");
                    if (q1 < 0 && q2 > 0) Console.WriteLine("segundo");
                    if (q1 < 0 && q2 < 0) Console.WriteLine("terceiro");
                    if (q1 > 0 && q2 < 0) Console.WriteLine("quarto");
                
            }
        } 
    }
}