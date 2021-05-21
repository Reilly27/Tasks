using System; 

class URI {

    static void Main(string[] args) { 

        int v, a1 = 0, a2 =0, a3=0, a4=0 ;

            for (int i = 0; i < 5; ++i)
            {
                v = int.Parse(Console.ReadLine());

                if (v % 2 == 0)
                {
                    a1++;
                }
                if (v % 2 != 0)
                {
                    a2++;
                }

                if (v > 0)
                {
                    a3 += 1;
                }
                if (v < 0)
                {
                    a4 += 1;
                }


            }

            Console.WriteLine(a1 + " valor(es) par(es)");
            Console.WriteLine(a2 + " valor(es) impar(es)");
            Console.WriteLine(a3 + " valor(es) positivo(s)");
            Console.WriteLine(a4 + " valor(es) negativo(s)");

    }

}