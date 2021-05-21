using System; 

class URI {

    static void Main(string[] args) { 

        int i, X, howManyOdd = 6;
            X = int.Parse(Console.ReadLine());
            for (i = X; i < (X + (howManyOdd * 2)); i += 2)
            {
                int odd;
                if (i % 2 == 0)
                {
                    odd = i + 1;
                    Console.WriteLine(odd);
                }
                else
                {
                    odd = i;
                    Console.WriteLine(odd);

                }
            }
    }

}