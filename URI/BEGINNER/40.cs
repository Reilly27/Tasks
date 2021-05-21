using System; 

class URI {

    static void Main(string[] args) { 

     
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double a3 = double.Parse(Console.ReadLine());
            double a4 = double.Parse(Console.ReadLine());
            double a5 = double.Parse(Console.ReadLine());
            double a6 = double.Parse(Console.ReadLine());

            if (a1 > 0)
            {
                a1 = 1;

                if (a2 >0)
                {
                    a2 = 1;
                }
                if (a3 > 0)
                {
                    a3 = 1;
                }
                if (a4 > 0)
                {
                    a4 = 1;
                }
                if (a5 > 0)
                {
                    a5 = 1;
                }
                if (a6 > 0)
                {
                    a6 = 1;
                }
                if (a2 < 0)
                {
                    a2 = 0;
                }
                if (a3 < 0)
                {
                    a3 = 0;
                }
                if (a4 < 0)
                {
                    a4 = 0;
                }
                if (a5 < 0)
                {
                    a5 = 0;
                }
                if (a6 < 0)
                {
                    a6 = 0;
                }
                if (a1 < 0)
                {
                    a1 = 0;
                }

                double otv = a1 + a2 + a3 + a4 + a5 + a6;

                Console.WriteLine(otv + " valores positivos");












            }

    }

}