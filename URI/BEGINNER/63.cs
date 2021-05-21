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
            

            for (int i = 0; i < 200; i++)
            {

                int a = int.Parse(Console.ReadLine());

                if (a != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                    Environment.Exit(0);
                }

            }
        } 
    }
}
