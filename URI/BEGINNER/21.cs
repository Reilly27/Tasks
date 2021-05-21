using System; 

class URI {

    static void Main(string[] args) { 

       string line = Console.ReadLine();
            var data = line.Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);
            int d = int.Parse(data[3]);

            if (b > c & d > a & c+d >a+b & a % 2 == 0)
            {
                Console.WriteLine( "Valores aceitos");
            }

            else
            {

                Console.WriteLine("Valores nao aceitos");

            }
       


    }

}