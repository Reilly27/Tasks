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

            Console.WriteLine("MUITO OBRIGADO");
            int alcool = 0, gasolina = 0, diesel = 0;
            for (int i = 0; i < 100; i++)
            {
                int a = int.Parse(Console.ReadLine());
                
                        if (a == 1) alcool++;
                        if (a == 2) gasolina++;
                        if (a == 3) diesel++;
                if (a == 4)
                {
                    Console.WriteLine("Alcool: " + alcool);
                    Console.WriteLine("Gasolina: " + gasolina);
                    Console.WriteLine("Diesel: " + diesel);
                    Environment.Exit(0);
                }
            }
        }
    }    
}
