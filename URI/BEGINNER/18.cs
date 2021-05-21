using System; 

class URI {

    static void Main(string[] args) { 

     int A = int.Parse(Console.ReadLine());

            int ot = A / 100;
            int ot1 = (A - ot*100) / 50;
            int ot2 = (A - ot * 100 - ot1 * 50) / 20;
            int ot3 = (A - ot * 100 -ot1 * 50 - ot2*20) / 10;
            int ot4 = (A - ot * 100 - ot1 * 50-ot2 * 20 -ot3*10) / 5;
            int ot5 = (A - ot * 100 - ot1 * 50-ot2 * 20 - ot3 * 10 - ot4 * 5) / 2;
            int ot6 = A - ot * 100 - ot1 * 50 - ot2 * 20 - ot3 * 10 - ot4 * 5 - ot5 * 2; 



            Console.WriteLine(A);
            Console.WriteLine(ot + " nota(s) de R$ 100,00");
            Console.WriteLine(ot1 + " nota(s) de R$ 50,00");
            Console.WriteLine(ot2 + " nota(s) de R$ 20,00");
            Console.WriteLine(ot3 + " nota(s) de R$ 10,00");
            Console.WriteLine(ot4 + " nota(s) de R$ 5,00");
            Console.WriteLine(ot5 + " nota(s) de R$ 2,00");
            Console.WriteLine(ot6 + " nota(s) de R$ 1,00");


    }

}