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

                for (int i = Y; i <= X; i++){

                    if (i % 13 != 0){

                        total += i;
                    }
                }
                Console.WriteLine(total);
            }
            else if (X < Y){

                int total2 = 0;

                for (int i = X; i <= Y; i++){
                    if (i % 13 != 0){
                        total2 += i;
                    }
                }
                Console.WriteLine(total2);

            }
        }
    }    
}
