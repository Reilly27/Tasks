using System; 

class URI {

    static void Main(string[] args) { 

         var line = Console.ReadLine();
            var data = line.Split(' ');
            var a = int.Parse(data[0]);
            var b = int.Parse(data[1]);

            int c = 24;


            if (b < a)
            {

                int ot1 = c + (b - a);


                Console.WriteLine("O JOGO DUROU " + ot1 + " HORA(S)");

            }

            else if (a < b)

            {
                int ot2 = b - a; 
                Console.WriteLine("O JOGO DUROU " + ot2 + " HORA(S)");
            }
            else if (a==b)
            {

                Console.WriteLine("O JOGO DUROU " + c + " HORA(S)");

            }

    }

}