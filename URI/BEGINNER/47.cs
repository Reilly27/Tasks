using System; 

class URI {

    static void Main(string[] args) { 

       int Y, X, ot1 = 0, ot2 = 0;
            int a = 10, b = 20;

            Y = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Y; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= a && X <= b)
                {
                   ot1 += 1;
                }
                else
                {
                    ot2 += 1;
                }
            }
            Console.WriteLine(ot1 + " in");
            Console.WriteLine(ot2 + " out");

    }

}