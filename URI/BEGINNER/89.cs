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
            double[,] M = new double[12, 12];
            double soma = 0.0;
            int inp = int.Parse(Console.ReadLine());
            string inp1 = Console.ReadLine(); 
            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {

                    M[i, j] = double.Parse(Console.ReadLine());
                    if (j == inp) {
                        soma += M[i, j];                        
                    }
                }                    
            }
            if (inp1 == "S"){
                string result = soma.ToString("0.0");
                Console.WriteLine(result);
            }
            else{
                double q = soma / 12.0; 
                string result = q.ToString("0.0");
                Console.WriteLine(result);
            }
        }
    }                    
}