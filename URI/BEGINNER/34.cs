using System; 

class URI {

    static void Main(string[] args) { 

       double A = double.Parse(Console.ReadLine());


            if (A <= 400.0)
            {
                double ot1 = A * 1.15;
                double ot1_o = ot1 - A;

                Console.WriteLine("Novo salario: " + (String.Format("{0:F2}", ot1)));
                Console.WriteLine("Reajuste ganho: " + (String.Format("{0:F2}", ot1_o)));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (A > 400 && A <= 800)
            {
                double ot2 = A * 1.12;
                double ot2_o = ot2 - A;

                Console.WriteLine("Novo salario: " + (String.Format("{0:F2}", ot2)));
                Console.WriteLine("Reajuste ganho: " + (String.Format("{0:F2}", ot2_o)));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (A > 800 && A <= 1200)
            {
                double ot3 = A * 1.10;
                double ot3_o = ot3 - A;

                Console.WriteLine("Novo salario: " + (String.Format("{0:F2}", ot3)));
                Console.WriteLine("Reajuste ganho: " + (String.Format("{0:F2}", ot3_o)));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (A > 1200 && A <= 2000)
            {

                double ot4 = A * 1.07;
                double ot4_o = ot4 - A;

                Console.WriteLine("Novo salario: " + (String.Format("{0:F2}", ot4)));
                Console.WriteLine("Reajuste ganho: " + (String.Format("{0:F2}", ot4_o)));
                Console.WriteLine("Em percentual: 7 %");

            }
            else if (A > 2000)
            {
                double ot5 = A * 1.04;
                double ot5_o = ot5 - A;

                Console.WriteLine("Novo salario: " + (String.Format("{0:F2}", ot5)));
                Console.WriteLine("Reajuste ganho: " + (String.Format("{0:F2}", ot5_o)));
                Console.WriteLine("Em percentual: 4 %");


            }



    }

}