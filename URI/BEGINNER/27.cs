using System; 

class URI {

    static void Main(string[] args) { 

       int a1, a2 = 0, a3 = 0;

            var line = Console.ReadLine();
            var data = line.Split(' ');
            var X = int.Parse(data[0]);
            var Y = int.Parse(data[1]);
            var Z = int.Parse(data[2]);
            a1 = Math.Min(X, Math.Min(Y, Z));
            if (a1 == X)
            {
                a2 = Math.Min(Y, Z);
                a3 = Math.Max(Y, Z);
            }
            if (a1 == Y)
            {
                a2 = Math.Min(X, Z);
                a3 = Math.Max(X, Z);
            }
            if (a1 == Z)
            {
                a2 = Math.Min(X, Y);
                a3 = Math.Max(X, Y);
            }
            Console.WriteLine(a1 + "\n" + a2 + "\n" + a3 + "\n");
            Console.WriteLine(X + "\n" + Y + "\n" + Z );


    }

}