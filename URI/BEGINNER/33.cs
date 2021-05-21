using System; 

class URI {

    static void Main(string[] args) { 

        var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);
            var a1 = int.Parse(data[1]);
            var b = int.Parse(data[2]);
            var b1 = int.Parse(data[3]);

            int c = b - a;
            int c1 = b1 - a1;

            if (c < 0)
            {
                c = 24 + (b - a);
            }          

            if (c1 < 0)

            {
                c1 = 60 + (b1 - a1);
                c--;
            }

            if (a == b && a1 == b1)

            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
                Console.WriteLine("O JOGO DUROU "+ c + " HORA(S) E "+ c1 + " MINUTO(S)");



    }

}