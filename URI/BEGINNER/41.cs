using System; 

class URI {

    static void Main(string[] args) { 

        int a, i;
            int tmp = 0;

            for (i = 0; i < 5; ++i)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    tmp++;
                }
            }

            Console.WriteLine(tmp + " valores pares");

    }

}