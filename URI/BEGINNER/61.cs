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

            for (int i = 0; i < 3; i++)
            {
                q = Console.ReadLine();


                int[] result = q.Split().Select(int.Parse).ToArray();
                int q1 = result[0];
                int q2 = result[1];
                int resul = 0;

                if (q1 > 0 && q1 > 0)
                {

                    if (q1 < q2)
                    {
                        for (int j = q1; j <= q2; j++)
                        {

                            Console.Write(j + " ");

                            resul += j;

                            if (j == q2) Console.Write("Sum=" + resul + "\n");
                        }
                    }
                    else if (q1 > q2)
                    {
                        for (int j = q2; j <= q1; j++)
                        {

                            Console.Write(j + " ");

                            resul += j;

                            if (j == q1) Console.Write("Sum=" + resul + "\n");

                        }
                    }
                    else Console.WriteLine(q1 + " Sum=" + q1 + "\n");
                }
                else if (q1 <= 0 || q2 <= 0) Environment.Exit(0);


            }
        } 
    }
}
