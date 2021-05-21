using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program {
        public static void Main() {
           
            for (int i = 0; i < 100; i++){
                int a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Environment.Exit(0);
                }
                    
                int oput = 0;
                if (a % 2 == 0){
                    oput += a;
                }
                else{
                      a += 1;
                    oput += a;
                }

                for (int j = 0; j < 5 - 1; j++)
                {
                    a += 2;
                    oput += a;
                }
                Console.WriteLine(oput);                 
            }                        
        }        
    }
}