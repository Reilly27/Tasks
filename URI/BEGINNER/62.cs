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
            string q;

            for (int i = 0; i < 200; i++)
            {
                q = Console.ReadLine();


                int[] result = q.Split().Select(int.Parse).ToArray();
                int q1 = result[0];
                int q2 = result[1];
                int resul = 0;

                

                    if (q1 > q2)
                    {
                    Console.WriteLine("Decrescente");
                    }
                    else if (q1 < q2)
                    {

                    Console.WriteLine("Crescente");

                    }
                    else Environment.Exit(0);


            }
        } 
    }
}
