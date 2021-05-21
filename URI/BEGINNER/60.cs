using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program
    {
        static void Main (string[] args)
        {
            string q;
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i ++)
            {
                q = Console.ReadLine();
               

                int[] result = q.Split().Select(int.Parse).ToArray();
                int q1 = result[0];
                int q2 = result[1];
                int resul =0;

                if (q1 < q2)
                {
                    for (int j = q1; j != q2; j++)
                    {
                        if (j % 2 != 0 && j != q1 && j != q2)
                        {
                            resul += j;
                        }
                        if (j == q2 - 1) Console.WriteLine(resul);
                    }
                }
                else if (q1 > q2)
                {
                    for (int j = q2; j != q1; j++)
                    {
                        if (j % 2 != 0 && j != q1 && j != q2)
                        {
                            resul += j;
                        }
                        if (j == q1 - 1) Console.WriteLine(resul);

                    }                   
                }
                else Console.WriteLine(resul);
            }            
        }       
    }
}
