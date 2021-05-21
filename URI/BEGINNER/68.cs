using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54ав
{
    class Program
    {


        public static void Main()
        {

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X > Y) {
                int total = 0;

                for (int i = Y +1; i < X; i++){

                    if (i % 5 == 2 || i % 5 == 3){

                        
                        Console.WriteLine(i);
                    }
                }
                
            }
            else if (X < Y){

                int total2 = 0;

                for (int i = X +1; i < Y; i++){
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }                
            }
        }
    }    
}