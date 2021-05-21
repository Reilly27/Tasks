using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program {
        public static void Main() {
            string input;
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++){
                input = Console.ReadLine();
                int[] result = input.Split().Select(int.Parse).ToArray();
                int q1 = result[0];
                int q2 = result[1];
                int oput = 0;
                if (q1 % 2 != 0){
                    oput += q1;
                }
                else{
                      q1 += 1;
                    oput += q1;
                }

                for (int j = 0; j < q2 - 1; j++)
                {
                    q1 += 2;
                    oput += q1;
                }
                Console.WriteLine(oput); 
            }                        
        }        
    }
}