using System; 

class URI {

    static void Main(string[] args) { 

        int X, Y, total = 0;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                for (int i = X - 1; i > Y; i--)
                {
                    if (i % 2 != 0)
                    {
                        total += i;
                    }
                }
            }
            else
            {
                for (int i = Y - 1; i > X; i--)
                {
                    if (i % 2 != 0)
                    {
                        total += i;
                    }
                }
            }

            Console.WriteLine(total);


    }

}